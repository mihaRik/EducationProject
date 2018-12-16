using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.Database;
using EducationProject.Controller;

namespace EducationProject.View
{
    public partial class TeacherForm : Form
    {
        private static EducationProjectEntities db = Controller.Controller.db;
        private static Teachers teacher;

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void LoadTask()
        {
            dgvTasksList.DataSource = db.Tasks.ToList();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationProjectDataSet5.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.educationProjectDataSet5.Tasks);
            teacher = db.Teachers.ToList().Find(x => x.UserId == Controller.Controller.user.UserId);

            lblTeacherNameValue.Text = teacher.TeacherName;
            lblTeacherSurnameValue.Text = teacher.TeacherSurname;
            lblTeacherEmailValue.Text = teacher.TeacherEmail;
            tbxTeacherPhoneValue.Text = teacher.TeacherPhone;
            tbxTeacherPasswordValue.Text = Controller.Controller.HidePassword(Controller.Controller.user.UserPassword);

            if (teacher.TeacherPhoto != null)
            {
                pbxTeacherPhoto.Image = Image.FromFile(teacher.TeacherPhoto);
            }

            if (teacher.TeacherBio != null)
            {
                rbxTeacherBio.Text = teacher.TeacherBio;
            }
            else
            {
                rbxTeacherBio.Text = "No info...";
            }
        }

        private void rbxTeacherBio_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnTeacherSaveChangeBio.Visible = true;
        }

        private void btnTeacherSaveChangeBio_Click(object sender, EventArgs e)
        {
            teacher.TeacherBio = rbxTeacherBio.Text;
            db.SaveChanges();

            btnTeacherSaveChangeBio.Visible = false;
            MessageBox.Show("Bio changed!");
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            tbxTeacherPasswordValue.ReadOnly = false;
            btnSaveChangePassword.Visible = true;
        }

        private void btnSaveChangePassword_Click(object sender, EventArgs e)
        {
            tbxTeacherPasswordValue.ReadOnly = true;
            btnSaveChangePassword.Visible = false;
            Controller.Controller.user.UserPassword = tbxTeacherPasswordValue.Text;
            tbxTeacherPasswordValue.Text = Controller.Controller.HidePassword(tbxTeacherPasswordValue.Text);
            db.SaveChanges();
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            btnSaveChangePhone.Visible = true;
            tbxTeacherPhoneValue.ReadOnly = false;
        }

        private void btnSaveChangePhone_Click(object sender, EventArgs e)
        {
            btnSaveChangePhone.Visible = false;
            tbxTeacherPhoneValue.ReadOnly = true;
            teacher.TeacherPhone = tbxTeacherPhoneValue.Text;
            db.SaveChanges();
        }

        private void tabControlTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlTeacher.SelectedIndex)
            {
                case 1:

                    LoadTask();
                    break;

                default:
                    break;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks()
            {
                TaskName = tbxAddTaskName.Text,
                TaskSubject = tbxAddTaskSubject.Text,
                TaskBody = rbxAddTaskBody.Text
            };
            db.Tasks.Add(task);
            db.SaveChanges();

            LoadTask();
            MessageBox.Show("Task added!");
        }

        private void dgvTasksList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvTasksList.CurrentRow;
            Tasks selectedTask = db.Tasks.ToList().Find(x => x.TaskId == (int)selectedRow.Cells[3].Value);

            tbxUpdateTaskName.Text = selectedTask.TaskName;
            tbxUpdateTaskSubject.Text = selectedTask.TaskSubject;
            rbxUpdateTaskBody.Text = selectedTask.TaskBody;

            btnUpdateTask.Enabled = true;
            btnRemoveTask.Enabled = true;
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvTasksList.CurrentRow;
            Tasks selectedTask = db.Tasks.ToList().Find(x => x.TaskId == (int)selectedRow.Cells[3].Value);

            selectedTask.TaskName = tbxUpdateTaskName.Text;
            selectedTask.TaskSubject = tbxUpdateTaskSubject.Text;
            selectedTask.TaskBody = rbxUpdateTaskBody.Text;

            db.SaveChanges();

            LoadTask();
            btnUpdateTask.Enabled = false;
            btnRemoveTask.Enabled = false;
            MessageBox.Show("Task updated");
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvTasksList.CurrentRow;
            Tasks selectedTask = db.Tasks.ToList().Find(x => x.TaskId == (int)selectedRow.Cells[3].Value);
            if (db.StudentTasks.ToList().Exists(x=>x.TaskId==selectedTask.TaskId))
            {
                MessageBox.Show("Your student have this task!");
            }

            db.Tasks.Remove(selectedTask);
            db.SaveChanges();

            LoadTask();
            btnUpdateTask.Enabled = false;
            btnRemoveTask.Enabled = false;
            MessageBox.Show("Task removed");
        }
    }
}
