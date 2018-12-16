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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationProjectDataSet4.Mentors' table. You can move, or remove it, as needed.
            this.mentorsTableAdapter.Fill(this.educationProjectDataSet4.Mentors);
            // TODO: This line of code loads data into the 'educationProjectDataSet3.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.educationProjectDataSet3.Groups);
            //select education package combobox

            cbxSelectEducationPackage.DisplayMember = "ProgramName";
            cbxSelectEducationPackage.ValueMember = "ProgramId";
            cbxSelectEducationPackage.DataSource = db.EducationPackages.ToList();

            //group type
            cbxGroupType.Items.Add("Weekdays");
            cbxGroupType.Items.Add("Weekend");

            //select group

            cbxSelectGroup.DisplayMember = "GroupName";
            cbxSelectGroup.ValueMember = "GroupId";
            cbxSelectGroup.DataSource = db.Groups.ToList();

            //group time
            cbxGroupLessonTime.Items.Add("Morning");
            cbxGroupLessonTime.Items.Add("Afternoon");
            cbxGroupLessonTime.Items.Add("Evening");

            //select grouptime
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudentsList.DataSource = db.Students.ToList();
        }

        private void LoadTeachers()
        {
            dgvTeachersList.DataSource = db.Teachers.ToList();
        }

        private void LoadMentors()
        {
            dgvMentorsList.DataSource = db.Mentors.ToList();
        }

        private void LoadGroup()
        {
            dgvGroupsList.DataSource = db.Groups.ToList();
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
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

            btnStudentUpdate.Enabled = false;
            btnStudentUpdatePhoto.Enabled = false;
            btnStudentRemove.Enabled = false;

            MessageBox.Show("Student updated!");
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

                    //teacher
                    cbxGroupTeacher.DisplayMember = "TeacherName";
                    cbxGroupTeacher.ValueMember = "TeacherId";
                    cbxGroupTeacher.DataSource = db.Teachers.ToList();

                    //mentor
                    cbxGroupMentor.DisplayMember = "MentorName";
                    cbxGroupMentor.ValueMember = "MentorId";
                    cbxGroupMentor.DataSource = db.Mentors.ToList();

                    //
                    List<Students> noGroupStudents = db.Students.Where(x => x.GroupId == null).ToList();
                    dgvStudentsToGroup.DataSource = noGroupStudents;
                    cbxSelectWhicGroup.DisplayMember = "GroupName";
                    cbxSelectWhicGroup.ValueMember = "GroupId";
                    cbxSelectWhicGroup.DataSource = db.Groups.ToList();

                    //update

                    cbxUpdateGroupProgramId.DisplayMember = "ProgramName";
                    cbxUpdateGroupProgramId.ValueMember = "ProgramId";
                    cbxUpdateGroupProgramId.DataSource = db.EducationPackages.ToList();

                    cbxUpdateGroupTeacher.DisplayMember = "TeacherName";
                    cbxUpdateGroupTeacher.ValueMember = "TeacherId";
                    cbxUpdateGroupTeacher.DataSource = db.Teachers.ToList();

                    cbxUpdateGroupMentor.DisplayMember = "MentorName";
                    cbxUpdateGroupMentor.ValueMember = "MentorId";
                    cbxUpdateGroupMentor.DataSource = db.Mentors.ToList();

                    cbxUpdateGroupGroupType.DisplayMember = "GroupTypeName";
                    cbxUpdateGroupGroupType.ValueMember = "GroupTypeId";
                    cbxUpdateGroupGroupType.DataSource = db.GroupTypes.ToList();

                    LoadGroup();
                    break;

                case 2:

                    cbxNewTeacherEducationPackage.DisplayMember = "ProgramName";
                    cbxNewTeacherEducationPackage.ValueMember = "ProgramId";
                    cbxNewTeacherEducationPackage.DataSource = db.EducationPackages.ToList();

                    //education package seaarch
                    cbxSearchTeacherEducationPackage.DisplayMember = "ProgramName";
                    cbxSearchTeacherEducationPackage.ValueMember = "ProgramId";
                    cbxSearchTeacherEducationPackage.DataSource = db.EducationPackages.ToList();

                    //search group

                    cbxSearchTeacherGroup.DisplayMember = "GroupName";
                    cbxSearchTeacherGroup.ValueMember = "GroupId";
                    cbxSearchTeacherGroup.DataSource = db.Groups.ToList();

                    LoadTeachers();
                    break;

                case 3:

                    cbxNewMentorEducationPackage.DisplayMember = "ProgramName";
                    cbxNewMentorEducationPackage.ValueMember = "ProgramId";
                    cbxNewMentorEducationPackage.DataSource = db.EducationPackages.ToList();

                    //education package seaarch
                    cbxSearchMentorEducationPackage.DisplayMember = "ProgramName";
                    cbxSearchMentorEducationPackage.ValueMember = "ProgramId";
                    cbxSearchMentorEducationPackage.DataSource = db.EducationPackages.ToList();

                    //search group
                    cbxSearchMentorGroup.DisplayMember = "GroupName";
                    cbxSearchMentorGroup.ValueMember = "GroupId";
                    cbxSearchMentorGroup.DataSource = db.Groups.ToList();
                    LoadMentors();

                    //search education package
                    cbxSearchMentorEducationPackage.DisplayMember = "ProgramName";
                    cbxSearchMentorEducationPackage.ValueMember = "ProgramId";
                    cbxSearchMentorEducationPackage.DataSource = db.EducationPackages.ToList();

                    LoadMentors();
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
                        MentorId = (int)cbxGroupMentor.SelectedValue,
                        GroupStartDate = dtpGroupStartDate.Value
                    };
                    DateTime endDate = CalcuateGroupEndTime(dtpGroupStartDate.Value, group);
                    group.GroupEndDate = endDate;
                    db.Groups.Add(group);
                    db.SaveChanges();
                }
            }
            LoadGroup();
        }

        private void btnAddStudentToGroup_Click(object sender, EventArgs e)
        {
            var a = dgvStudentsToGroup.SelectedRows.Cast<DataGridViewRow>();
            foreach (var item in a)
            {
                item.Cells[5].Value = cbxSelectWhicGroup.SelectedValue;
            }
            db.SaveChanges();

            MessageBox.Show("Student added to group!");
        }

        private void dgvGroupsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvGroupsList.CurrentRow;
            tbxUpdateGroupName.Text = selectedRow.Cells["GroupName"].Value.ToString();
            cbxUpdateGroupProgramId.SelectedValue = (int)selectedRow.Cells[1].Value;
            cbxUpdateGroupTeacher.SelectedValue = (int)selectedRow.Cells[2].Value;
            cbxUpdateGroupMentor.SelectedValue = (int)selectedRow.Cells[3].Value;
            cbxUpdateGroupGroupType.SelectedValue = (int)selectedRow.Cells[4].Value;
            dtpUpdateGroupStartDate.Value = (DateTime)selectedRow.Cells[5].Value;
        }

        private void btnShowAllTeachers_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void dgvTeachersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateTeacher.Enabled = true;
            btnRemoveTeacher.Enabled = true;
            btnUpdateTeacherPhoto.Enabled = true;

            DataGridViewRow selectedRow = dgvTeachersList.CurrentRow;
            tbxUpdateTeacherName.Text = selectedRow.Cells[0].Value.ToString();
            tbxUpdateTeacherSurname.Text = selectedRow.Cells[1].Value.ToString();
            tbxUpdateTeacherEmail.Text = selectedRow.Cells[2].Value.ToString();
            tbxUpdateTeacherPhone.Text = selectedRow.Cells[3].Value.ToString();

            try
            {
                rbxUpdateTeacherBio.Text = selectedRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                rbxUpdateTeacherBio.Text = "No info...";
            }

            try
            {
                pbxUpdateTeacherPhoto.Image = Image.FromFile(selectedRow.Cells[5].Value.ToString());
            }
            catch (Exception)
            {
                pbxUpdateTeacherPhoto.Image = pbxUpdateTeacherPhoto.ErrorImage;
            }


        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            int selectedTeacherId = Convert.ToInt32(dgvTeachersList.CurrentRow.Cells[7].Value.ToString());
            Teachers selectedTeacher = db.Teachers.ToList().Find(x => x.TeacherId == selectedTeacherId);

            selectedTeacher.TeacherName = tbxUpdateTeacherName.Text;
            selectedTeacher.TeacherSurname = tbxUpdateTeacherSurname.Text;
            selectedTeacher.TeacherEmail = tbxUpdateTeacherEmail.Text;
            selectedTeacher.TeacherPhone = tbxUpdateTeacherPhone.Text;
            selectedTeacher.TeacherBio = rbxUpdateTeacherBio.Text;
            db.SaveChanges();

            MessageBox.Show("Teacher updated!");

            LoadTeachers();

            btnUpdateTeacher.Enabled = false;
            btnUpdateTeacherPhoto.Enabled = false;
            btnRemoveTeacher.Enabled = false;
        }

        private void btnAddNewTeacher_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                UserEmail = tbxNewTeacherEmail.Text,
                UserPassword = 12345.ToString(),
                UserTypeId = 1
            };
            db.Users.Add(user);
            db.SaveChanges();

            Teachers teacher = new Teachers()
            {
                UserId = user.UserId,
                TeacherName = tbxNewTeacherName.Text,
                TeacherSurname = tbxNewTeacherSurname.Text,
                TeacherEmail = user.UserEmail,
                TeacherPhone = tbxNewTeacherPhone.Text,
                ProgramId = (int)cbxNewTeacherEducationPackage.SelectedValue
            };
            db.Teachers.Add(teacher);
            db.SaveChanges();

            MessageBox.Show("Teacher added!");
        }

        private void dgvMentorsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateMentor.Enabled = true;
            btnRemoveMentor.Enabled = true;
            btnUpdateMentorPhoto.Enabled = true;

            DataGridViewRow selectedRow = dgvMentorsList.CurrentRow;
            tbxUpdateMentorName.Text = selectedRow.Cells[0].Value.ToString();
            tbxUpdateMentorSurname.Text = selectedRow.Cells[1].Value.ToString();
            tbxUpdateMentorEmail.Text = selectedRow.Cells[2].Value.ToString();
            tbxUpdateMentorPhone.Text = selectedRow.Cells[3].Value.ToString();

            try
            {
                rbxUpdateMentorBio.Text = selectedRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                rbxUpdateMentorBio.Text = "No info...";
            }

            try
            {
                pbxUpdateMentorPhoto.Image = Image.FromFile(selectedRow.Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                pbxUpdateMentorPhoto.Image = pbxUpdateTeacherPhoto.ErrorImage;
            }
        }

        private void btnUpdateMentor_Click(object sender, EventArgs e)
        {
            int selectedMentorId = Convert.ToInt32(dgvMentorsList.CurrentRow.Cells[8].Value.ToString());
            Mentors selectedMentor = db.Mentors.ToList().Find(x => x.MentorId == selectedMentorId);

            selectedMentor.MentorName = tbxUpdateMentorName.Text;
            selectedMentor.MentorSurname = tbxUpdateMentorSurname.Text;
            selectedMentor.MentorEmail = tbxUpdateMentorEmail.Text;
            selectedMentor.MentorPhone = tbxUpdateMentorPhone.Text;
            selectedMentor.MentorBio = rbxUpdateMentorBio.Text;
            db.SaveChanges();

            MessageBox.Show("Mentor updated!");

            LoadMentors();

            btnUpdateMentor.Enabled = false;
            btnRemoveMentor.Enabled = false;
            btnUpdateMentorPhoto.Enabled = false;
        }

        private void btnAddNewMentor_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                UserEmail = tbxNewMentorEmail.Text,
                UserPassword = 12345.ToString(),
                UserTypeId = 2
            };
            db.Users.Add(user);
            db.SaveChanges();

            Mentors mentor = new Mentors()
            {
                UserId = user.UserId,
                MentorName = tbxNewMentorName.Text,
                MentorSurname = tbxNewMentorSurname.Text,
                MentorEmail = user.UserEmail,
                MentorPhone = tbxNewTeacherPhone.Text,
                ProgramId = (int)cbxNewMentorEducationPackage.SelectedValue
            };
            db.Mentors.Add(mentor);
            db.SaveChanges();

            MessageBox.Show("Mentor added!");
        }

        private void btnShowAllMentors_Click(object sender, EventArgs e)
        {
            LoadMentors();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            Groups selectedGroup = db.Groups.ToList().Find(x => x.GroupId == Convert.ToInt32(dgvGroupsList.CurrentRow.Cells[7].Value.ToString()));
            selectedGroup.GroupName = tbxUpdateGroupName.Text;
            selectedGroup.ProgramId = (int)cbxUpdateGroupProgramId.SelectedValue;
            selectedGroup.TeacherId = (int)cbxUpdateGroupTeacher.SelectedValue;
            selectedGroup.MentorId = (int)cbxUpdateGroupMentor.SelectedValue;
            selectedGroup.GroupTypeId = (int)cbxUpdateGroupGroupType.SelectedValue;
            selectedGroup.GroupStartDate = dtpUpdateGroupStartDate.Value.Date;
            selectedGroup.GroupEndDate = CalcuateGroupEndTime(selectedGroup.GroupStartDate.Value, selectedGroup);

            db.SaveChanges();
            LoadGroup();

            MessageBox.Show("Group updated!");
        }

        private DateTime CalcuateGroupEndTime(DateTime _startDate, Groups _selectedGroup)
        {
            GroupTypes groupType = db.GroupTypes.ToList().Find(x => x.GroupTypeId == _selectedGroup.GroupTypeId);
            GroupLessonTimes groupLessonTime = db.GroupLessonTimes.ToList().Find(x => x.GroupLessonTimeId == groupType.GroupLessonTimeId);
            EducationPackages educationPackage = db.EducationPackages.ToList().Find(x => x.ProgramId == _selectedGroup.ProgramId);


            float programDuration = (float)educationPackage.ProgramDuration;
            float lessonDuration = Convert.ToSingle(groupLessonTime.GroupLessonTimeEnd.Hours - groupLessonTime.GroupLessonTimeStart.Hours);
            float sumDays = programDuration / lessonDuration;

            DateTime endDate = _startDate.Date;

            if (groupType.GroupTypeName.Contains("Weekdays"))
            {
                for (int i = 0; i < sumDays; i++)
                {
                    if (endDate.DayOfWeek != DayOfWeek.Friday
                        && endDate.DayOfWeek != DayOfWeek.Saturday
                        && endDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        endDate = endDate.AddDays(1);
                    }
                    else
                    {
                        endDate = endDate.AddDays(1);
                        i--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < sumDays; i++)
                {
                    if (endDate.DayOfWeek == DayOfWeek.Saturday || endDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        endDate = endDate.AddDays(1);
                    }
                    else
                    {
                        endDate = endDate.AddDays(1);
                        i--;
                    }
                }
            }

            return endDate;
        }

        private void cbxSearchEducationPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Teachers> filteredTeachers = db.Teachers.Where(x => x.ProgramId == (int)cbxSearchTeacherEducationPackage.SelectedValue).ToList();
            dgvTeachersList.DataSource = filteredTeachers;
        }

        private void cbxSearchTeacherGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Groups selectedGroup = db.Groups.ToList().Find(x => x.GroupId == (int)cbxSearchTeacherGroup.SelectedValue);
            List<Teachers> filteredTeachers = db.Teachers.Where(x => x.TeacherId == selectedGroup.TeacherId).ToList();
            dgvTeachersList.DataSource = filteredTeachers;
        }

        private void cbxSearchMentorEducationPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Mentors> filteredMentors = db.Mentors.Where(x => x.ProgramId == (int)cbxSearchMentorEducationPackage.SelectedValue).ToList();
            dgvMentorsList.DataSource = filteredMentors;
        }

        private void cbxSearchMentorGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Groups selectedGroup = db.Groups.ToList().Find(x => x.GroupId == (int)cbxSearchMentorGroup.SelectedValue);
            List<Mentors> filteredMentor = db.Mentors.Where(x => x.MentorId == selectedGroup.MentorId).ToList();
            dgvMentorsList.DataSource = filteredMentor;
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            switch (tabControlAdmin.SelectedIndex)
            {
                case 0:
                    List<Students> filteredStudents = db.Students.Where(x => x.StudentName.Contains(tbxSearchStudentByName.Text)).ToList();
                    dgvStudentsList.DataSource = filteredStudents;
                    break;

                case 2:
                    List<Teachers> filteredTeachers = db.Teachers.Where(x => x.TeacherName.Contains(tbxSearchTeacherByName.Text)).ToList();
                    dgvTeachersList.DataSource = filteredTeachers;
                    break;

                case 3:
                    List<Mentors> filteredMentors = db.Mentors.Where(x => x.MentorName.Contains(tbxSearchMentorByName.Text)).ToList();
                    dgvMentorsList.DataSource = filteredMentors;
                    break;

                default:
                    break;
            }
        }
    }
}
