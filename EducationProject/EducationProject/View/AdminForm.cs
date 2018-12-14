using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.Controller;
using EducationProject.Database;

namespace EducationProject.View
{
    public partial class AdminForm : Form
    {
        EducationProjectEntities db = Controller.Controller.db;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //select education package combobox

            cbxSelectEducationPackage.DisplayMember = "ProgramName";
            cbxSelectEducationPackage.ValueMember = "ProgramId";
            cbxSelectEducationPackage.DataSource = db.EducationPackages.ToList();

            //select group

            cbxSelectGroup.DisplayMember = "GroupName";
            cbxSelectGroup.ValueMember = "GroupId";
            cbxSelectGroup.DataSource = db.Groups.ToList();

            //select grouptime
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudentsList.DataSource = db.Students.ToList();
        }

        private void cbxSelectEducationPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Groups> groups = db.Groups.Where(x => x.ProgramId == (int)cbxSelectEducationPackage.SelectedValue).ToList();
            List<Students> filteredStudents = new List<Students>();

            foreach (Groups group in groups)
            {
                filteredStudents
                    .AddRange(db.Students.ToList()
                    .Where(x => x.GroupId == group.GroupId));
            }

            dgvStudentsList.DataSource = filteredStudents;
        }

        private void cbxSelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Students> filteredStuds = db.Students.Where(x => x.GroupId == (int)cbxSelectGroup.SelectedValue).ToList();
            dgvStudentsList.DataSource = filteredStuds;
        }

        private void cbxSelectGroupType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewStudentAdd_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                UserEmail = tbxNewStudentEmail.Text,
                UserPassword = 12345.ToString(),
                UserTypeId = 3
            };
            db.Users.Add(user);
            db.SaveChanges();

            Students student = new Students()
            {
                UserId = user.UserId,
                StudentName = tbxNewStudentName.Text,
                StudentSurname = tbxNewStudentSurname.Text,
                StudentEmail = user.UserEmail,
                StudentPhone = tbxNewStudentPhone.Text,
                StudentRegistrationDate = DateTime.Now
            };
            db.Students.Add(student);
            db.SaveChanges();

            MessageBox.Show("Student added!");
        }

        private void dgvStudentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnStudentUpdate.Enabled = true;
            btnStudentUpdatePhoto.Enabled = true;
            btnStudentRemove.Enabled = true;

            tbxStudentUpdateName.Text = dgvStudentsList.CurrentRow.Cells[0].Value.ToString();
            tbxStudentUpdateSurname.Text = dgvStudentsList.CurrentRow.Cells[1].Value.ToString();
            tbxStudentUpdateEmail.Text = dgvStudentsList.CurrentRow.Cells[2].Value.ToString();
            tbxStudentUpdatePhone.Text = dgvStudentsList.CurrentRow.Cells[3].Value.ToString();

            try
            {
                rbxStudentUpdateBio.Text = dgvStudentsList.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                rbxStudentUpdateBio.Text = "No info...";
            }

            try
            {
                pbxStudentUpdatePhoto.Image = Image.FromFile(dgvStudentsList.CurrentRow.Cells["StudentPhoto"].Value.ToString());
            }
            catch (Exception)
            {
                pbxStudentUpdatePhoto.Image = pbxStudentUpdatePhoto.ErrorImage;
            }
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            int selectedStudId = Convert.ToInt32(dgvStudentsList.CurrentRow.Cells["StudentId"].Value.ToString());
            Students selectedStudent = db.Students.ToList().Find(x => x.StudentId == selectedStudId);

            selectedStudent.StudentName = tbxStudentUpdateName.Text;
            selectedStudent.StudentSurname = tbxStudentUpdateSurname.Text;
            selectedStudent.StudentEmail = tbxStudentUpdateEmail.Text;
            selectedStudent.StudentPhone = tbxStudentUpdatePhone.Text;
            selectedStudent.StudentBio = rbxStudentUpdateBio.Text;
            db.SaveChanges();

            LoadStudents();

            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlAdmin.SelectedIndex)
            {
                case 1:
                    //education package
                    cbxEducationPackage.DisplayMember = "ProgramName";
                    cbxEducationPackage.ValueMember = "ProgramId";
                    cbxEducationPackage.DataSource = db.EducationPackages.ToList();

                    //group type
                    cbxGroupType.Items.Add("Weekdays");
                    cbxGroupType.Items.Add("Weekend");

                    //group time
                    cbxGroupLessonTime.Items.Add("Morning");
                    cbxGroupLessonTime.Items.Add("Afternoon");
                    cbxGroupLessonTime.Items.Add("Evening");

                    //teacher
                    cbxGroupTeacher.DisplayMember = "TeacherName";
                    cbxGroupTeacher.ValueMember = "TeacherId";
                    cbxGroupTeacher.DataSource = db.Teachers.ToList();

                    //mentor
                    cbxGroupMentor.DisplayMember = "MentorName";
                    cbxGroupMentor.ValueMember = "MentorId";
                    cbxGroupMentor.DataSource = db.Mentors.ToList();
                    break;

                default:
                    break;
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxAddGroupName.Text))
            {
                MessageBox.Show("Please fill out all fields!");
            }
            else
            {
                if (cbxGroupLessonTime.SelectedItem.ToString() == "Evening" && cbxGroupType.SelectedItem.ToString() == "Weekend")
                {
                    MessageBox.Show("You cant create that type group!");
                }
                else
                {
                    string groupTimeName;
                    if (cbxGroupType.SelectedItem.ToString() == "Weekdays")
                    {
                        groupTimeName = cbxGroupLessonTime.SelectedItem.ToString();
                    }
                    else
                    {
                        groupTimeName = cbxGroupType.SelectedItem.ToString() + cbxGroupLessonTime.SelectedItem.ToString();
                    }

                    int groupTimeId = db.GroupLessonTimes.ToList().Find(x => x.GroupLessonTimeName == groupTimeName).GroupLessonTimeId;
                    GroupTypes groupType = db.GroupTypes.ToList().Find(x => x.GroupLessonTimeId == groupTimeId);

                    Groups group = new Groups()
                    {
                        GroupName = tbxAddGroupName.Text,
                        ProgramId = (int)cbxEducationPackage.SelectedValue,
                        GroupTypeId = groupType.GroupTypeId,
                        TeacherId = (int)cbxGroupTeacher.SelectedValue,
                        MentorId = (int)cbxGroupMentor.SelectedValue
                    };
                    db.Groups.Add(group);
                    db.SaveChanges();
                }
            }
        }
    }
}
