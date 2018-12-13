using EducationProject.Database;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.View;

namespace EducationProject.View
{
    public partial class StudentsForm : Form
    {
        static EducationProjectEntities db = Controller.Controller.db;
        static Students stud = db.Students.ToList().Find(x => x.UserId == Controller.Controller.user.UserId);
        IQueryable<StudentTasks> studTask = db.StudentTasks.Where(x => x.StudentId == stud.StudentId);
        Tasks task;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            lblStudentNameValue.Text = stud.StudentName;
            lblStudentSurnameValue.Text = stud.StudentSurname;
            lblStudentEmailValue.Text = stud.StudentEmail;
            string studentPassword = Controller.Controller.user.UserPassword;
            string unvisiblePassword = studentPassword;

            for (int i = 0; i < studentPassword.Length - 2; i++)
            {
                unvisiblePassword = unvisiblePassword.Replace(studentPassword[i], '*');
            }

            lblStudentPasswordValue.Text = unvisiblePassword;
            lblStudentPhoneValue.Text = stud.StudentPhone;
            lblStudentBirthDateValue.Text = stud.StudentBirthDate.ToString();
            lblStudentRegisterDateValue.Text = stud.StudentRegistrationDate.ToString();
            string groupName = "";

            if (db.Groups.ToList().Exists(x => x.GroupId == stud.GroupId))
            {
                groupName = db.Groups.ToList().Find(x => x.GroupId == stud.GroupId).GroupName;
            }
            else
            {
                groupName = "No group";
                lblStudentStartDateValue.Text = groupName;
                lblStudentEndDateValue.Text = groupName;
            }

            lblStudentGroupValue.Text = groupName;

            if (!String.IsNullOrEmpty(stud.StudentPhoto))
            {
                pbxStudentPhoto.Image = Image.FromFile(stud.StudentPhoto);
            }
        }

        private void btnStudentChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string destPath = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                string studentPhotoName = Controller.Controller.user.UserEmail + Controller.Controller.user.UserId;
                string uploadFileName = Path.Combine(destPath, studentPhotoName);
                FileSystem.CopyFile(openFile.FileName, uploadFileName, UIOption.AllDialogs, UICancelOption.ThrowException);
                pbxStudentPhoto.Image = Image.FromFile(uploadFileName);
                db.Students.ToList().Find(x => x.StudentEmail == Controller.Controller.user.UserEmail).StudentPhoto = uploadFileName;
                db.SaveChanges();
                MessageBox.Show("Photo added!");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabTask)
            {
                foreach (StudentTasks studentTasks in studTask)
                {
                    task = db.Tasks.ToList().Find(x => x.TaskId == studentTasks.TaskId);
                    string taskName = task.TaskName;
                    cbxSelectTask.Items.Add(taskName);
                }

                if (studTask.ToList().Exists(x => x.TaskPoint >= 0))
                {
                    double studAvgPoint = (double)studTask.Where(x => x.TaskPoint >= 0).Average(x => x.TaskPoint);
                }
                else
                {
                    lblStudentAvgPointValue.Text = "You don`t have any points";
                }
            }
        }

        private void cbxSelectTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks selectedTask = null;

            foreach (StudentTasks task in studTask)
            {
                selectedTask = db.Tasks.ToList().Find(x => x.TaskId == task.TaskId &&
                x.TaskName == cbxSelectTask.SelectedItem.ToString());
            }

            lblStudentTaskSubjectValue.Text = selectedTask.TaskSubject;
            rbxStudentTaskBody.Text = selectedTask.TaskBody;

            StudentTasks selectedStudentTask = db.StudentTasks.ToList().Find(x => x.TaskId == selectedTask.TaskId);

            lblStudentTaskStartDateValue.Text = selectedStudentTask.TaskStartDate.ToString();
            lblStudentTaskEndDateValue.Text = selectedStudentTask.TaskEndDate.ToString();
        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
