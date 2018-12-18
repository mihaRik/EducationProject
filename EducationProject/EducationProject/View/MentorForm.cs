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
    public partial class MentorForm : Form
    {
        private static EducationProjectEntities db = Controller.Controller.db;
        private static Mentors mentor;
        private static List<Messages> mentorMessages;
        private static List<Messages> mentorSentMessages;

        public MentorForm()
        {
            InitializeComponent();
        }

        private void Mentor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationProjectDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.educationProjectDataSet.Messages);
            // TODO: This line of code loads data into the 'educationProjectDataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.educationProjectDataSet1.Students);
            // TODO: This line of code loads data into the 'educationProjectDataSet5.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.educationProjectDataSet5.Tasks);
            mentor = db.Mentors.ToList().Find(x => x.UserId == Controller.Controller.user.UserId);

            lblTeacherNameValue.Text = mentor.MentorName;
            lblTeacherSurnameValue.Text = mentor.MentorSurname;
            lblTeacherEmailValue.Text = mentor.MentorEmail;
            tbxTeacherPhoneValue.Text = mentor.MentorPhone;
            tbxTeacherPasswordValue.Text = Controller.Controller.HidePassword(Controller.Controller.user.UserPassword);

            if (mentor.MentorPhoto != null)
            {
                pbxTeacherPhoto.Image = Image.FromFile(mentor.MentorPhoto);
            }

            if (mentor.MentorBio != null)
            {
                rbxTeacherBio.Text = mentor.MentorBio;
            }
            else
            {
                rbxTeacherBio.Text = "No info...";
            }
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
            mentor.MentorPhone = tbxTeacherPhoneValue.Text;
            db.SaveChanges();
        }

        private void btnTeacherSaveChangeBio_Click(object sender, EventArgs e)
        {
            mentor.MentorBio = rbxTeacherBio.Text;
            db.SaveChanges();

            btnTeacherSaveChangeBio.Visible = false;
            MessageBox.Show("Bio changed!");
        }

        private void rbxTeacherBio_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnTeacherSaveChangeBio.Visible = true;
        }

        private void dgvTasksList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvTasksList.CurrentRow;
            Tasks selectedTask = db.Tasks.ToList()
                .Find(x => x.TaskId == (int)selectedRow.Cells[3].Value
                && x.TaskCategory== mentor.ProgramId);

            tbxUpdateTaskName.Text = selectedTask.TaskName;
            tbxUpdateTaskSubject.Text = selectedTask.TaskSubject;
            rbxUpdateTaskBody.Text = selectedTask.TaskBody;
        }

        private void tabControlTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMentor.SelectedIndex)
            {
                case 2:
                    {
                        List<Groups> mentorGroups = db.Groups
                            .Where(x => x.MentorId == mentor.MentorId).ToList();
                        List<Students> mentorStudents = new List<Students>();

                        cbxGroupsSelectGroup.DisplayMember = "GroupName";
                        cbxGroupsSelectGroup.ValueMember = "GroupId";
                        cbxGroupsSelectGroup.DataSource = mentorGroups;

                        foreach (Groups group in mentorGroups)
                        {
                            mentorStudents.AddRange(db.Students
                                .Where(x => x.GroupId == group.GroupId));
                        }

                        dgvGroupsStudentsList.DataSource = mentorStudents;
                    }
                    break;

                case 3:
                    {
                        mentorMessages = db.Messages
                            .Where(x => x.ReceiverEmail == mentor.MentorEmail).ToList();

                        mentorSentMessages = db.Messages
                            .Where(x => x.SenderEmail == mentor.MentorEmail).ToList();

                        dgvMessagesSent.DataSource = mentorSentMessages;
                        dgvInbox.DataSource = mentorMessages;
                    }
                    break;

                case 4:
                    {
                        cbxWorkMatesSelectMentor.DisplayMember = "MentorName";
                        cbxWorkMatesSelectMentor.ValueMember = "MentorId";

                        cbxWorkMatesSelectMentor.DataSource = db.Mentors
                            .Where(x => x.MentorId != mentor.MentorId).ToList();

                        cbxWorkmatesSelectTeacher.DisplayMember="TeacherName";
                        cbxWorkmatesSelectTeacher.ValueMember = "TeacherId";

                        cbxWorkmatesSelectTeacher.DataSource = db.Teachers.ToList();
                    }
                    break;
                default:
                    break;
            }
        }

        private void cbxGroupsSelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Groups selectedGroup = db.Groups.ToList()
               .Find(x => x.GroupId == (int)cbxGroupsSelectGroup.SelectedValue);

            dgvGroupsStudentsList.DataSource = db.Students
                .Where(x => x.GroupId == selectedGroup.GroupId).ToList();

            tbxGroupsInfoName.Text = selectedGroup.GroupName;

            GroupTypes selectedGroupType = db.GroupTypes.ToList()
                .Find(x => x.GroupTypeId == selectedGroup.GroupTypeId);

            tbxGroupsInfoGroupType.Text = selectedGroupType.GroupTypeName;

            GroupLessonTimes selectedGroupTime = db.GroupLessonTimes.ToList()
                .Find(x => x.GroupLessonTimeId == selectedGroupType.GroupLessonTimeId);

            tbxGroupsInfoGroupTime.Text = selectedGroupTime.GroupLessonTimeName.
                Replace(selectedGroupType.GroupTypeName, "");

            tbxGroupsInfoGroupMentor.Text = db.Teachers.ToList()
                .Find(x => x.TeacherId == selectedGroup.TeacherId).TeacherName;
        }

        private void tbxGroupsSearchByName_TextChanged(object sender, EventArgs e)
        {
            List<Groups> teacherGroups = db.Groups
                .Where(x => x.MentorId == mentor.MentorId).ToList();
            List<Students> teacherStudents = new List<Students>();

            foreach (Groups group in teacherGroups)
            {
                teacherStudents.AddRange(db.Students.Where(x => x.GroupId == group.GroupId));
            }

            List<Students> filteredStudents = teacherStudents
                .Where(x => x.StudentName.Contains(tbxGroupsSearchByName.Text)).ToList();

            dgvGroupsStudentsList.DataSource = filteredStudents;
        }

        private void btnGoupsShowAllStudents_Click(object sender, EventArgs e)
        {
            List<Groups> mentorGroups = db.Groups
                .Where(x => x.MentorId == mentor.MentorId).ToList();
            List<Students> mentorStudents = new List<Students>();

            foreach (Groups group in mentorGroups)
            {
                mentorStudents.AddRange(db.Students
                    .Where(x => x.GroupId == group.GroupId));
            }

            dgvGroupsStudentsList.DataSource = mentorStudents;
        }

        private void btnSendToTeacher_Click(object sender, EventArgs e)
        {
            ComboBox teachersList = new ComboBox()
            {
                Left = tbxMessageReceiver.Left,
                Top = tbxMessageReceiver.Top,
                Width = tbxMessageReceiver.Width
            };

            tbxMessageReceiver.Hide();
            tabMessagesSendTo.Controls.Add(teachersList);

            teachersList.DisplayMember = "TeacherName";
            teachersList.ValueMember = "TeacherEmail";
            teachersList.DataSource = db.Teachers.ToList();

            teachersList.SelectedValueChanged += TeachersList_SelectedValueChanged;

        }

        private void SetTextboxOfReceiver(object sender)
        {
            ComboBox comboBox = (ComboBox)sender as ComboBox;
            tbxMessageReceiver.Text = (string)comboBox.SelectedValue;
        }

        private void TeachersList_SelectedValueChanged(object sender, EventArgs e)
        {
            SetTextboxOfReceiver(sender);
        }

        private void btnSendToMentor_Click(object sender, EventArgs e)
        {
            ComboBox mentorsList = new ComboBox()
            {
                Left = tbxMessageReceiver.Left,
                Top = tbxMessageReceiver.Top,
                Width = tbxMessageReceiver.Width
            };

            tbxMessageReceiver.Hide();
            tabMessagesSendTo.Controls.Add(mentorsList);

            mentorsList.DisplayMember = "MentorName";
            mentorsList.ValueMember = "MentorEmail";

            mentorsList.DataSource = db.Mentors.Where(x=>x.MentorId!=mentor.MentorId).ToList();

            mentorsList.SelectedValueChanged += MentorsList_SelectedValueChanged;
        }

        private void MentorsList_SelectedValueChanged(object sender, EventArgs e)
        {
            SetTextboxOfReceiver(sender);
        }

        private void btnSendToStudents_Click(object sender, EventArgs e)
        {
            ComboBox studentsList = new ComboBox()
            {
                Left = tbxMessageReceiver.Left,
                Top = tbxMessageReceiver.Top,
                Width = tbxMessageReceiver.Width
            };

            tbxMessageReceiver.Hide();
            tabMessagesSendTo.Controls.Add(studentsList);

            studentsList.DisplayMember = "StudentName";
            studentsList.ValueMember = "StudentEmail";

            List<Groups> teacherGroups = db.Groups
                .Where(x => x.MentorId == mentor.MentorId).ToList();

            List<Students> teacherStudents = new List<Students>();

            foreach (Groups group in teacherGroups)
            {
                teacherStudents.AddRange(db.Students.Where(x => x.GroupId == group.GroupId));
            }

            studentsList.DataSource = teacherStudents;

            studentsList.SelectedValueChanged += StudentsList_SelectedValueChanged;
        }

        private void StudentsList_SelectedValueChanged(object sender, EventArgs e)
        {
            SetTextboxOfReceiver(sender);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxMessageReceiver.Text) || String.IsNullOrEmpty(rbxMessagesBody.Text))
            {
                MessageBox.Show("Please fill out all required inputs!");
            }
            else
            {
                if (db.Users.ToList().Exists(x => x.UserEmail == tbxMessageReceiver.Text))
                {
                    Messages msg = new Messages()
                    {
                        SenderEmail = mentor.MentorEmail,
                        ReceiverEmail = tbxMessageReceiver.Text,
                        MessageSubject = tbxMessageSubject.Text,
                        MessageSendTime = DateTime.Now,
                        MessageBody = rbxMessagesBody.Text,
                    };
                    db.Messages.Add(msg);
                    db.SaveChanges();
                    MessageBox.Show("Message sent!");
                }
                else
                {
                    MessageBox.Show("Check receiver email!");
                }
            }
        }

        private void dgvInbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMessageInboxSenderValue.Text = dgvInbox.CurrentRow.Cells[0].Value.ToString();
            lblMessageInboxSubjectValue.Text = dgvInbox.CurrentRow.Cells[2].Value.ToString();
            rbxMessageInboxBody.Text = dgvInbox.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvMessagesSent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMessagesSentReceiverValue.Text = dgvMessagesSent.CurrentRow.Cells[0].Value.ToString();
            lblMessagesSentSubjectValue.Text = dgvMessagesSent.CurrentRow.Cells[2].Value.ToString();
            rbxMessagesSent.Text = dgvMessagesSent.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbxWorkmatesSelectTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teachers selectedTeacher = db.Teachers.ToList()
               .Find(x => x.TeacherId == (int)cbxWorkmatesSelectTeacher.SelectedValue);

            lblWorkmatesTeacherNameValue.Text = selectedTeacher.TeacherName;
            lblWorkmatesTeacherSurnameValue.Text = selectedTeacher.TeacherSurname;
            lblWorkmatesTeacherEmailValue.Text = selectedTeacher.TeacherEmail;
            lblWorkmatesTeacherPhoneValue.Text = selectedTeacher.TeacherPhone;

            if (selectedTeacher.TeacherBio != null)
            {
                rbxWorkmatesTeacherBioValue.Text = selectedTeacher.TeacherBio;
            }
            else
            {
                rbxWorkmatesTeacherBioValue.Text = "No info...";
            }

            if (selectedTeacher.TeacherPhoto != null)
            {
                pbxWorkmatesTeacherPhoto.Image = Image.FromFile(selectedTeacher.TeacherPhoto);
            }
        }

        private void cbxWorkMatesSelectMentor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mentors selectedMentor = db.Mentors.ToList()
               .Find(x => x.MentorId == (int)cbxWorkMatesSelectMentor.SelectedValue);

            lblWorkMatesMentorNameValue.Text = selectedMentor.MentorName;
            lblWorkMatesMentorSurnameValue.Text = selectedMentor.MentorSurname;
            lblWorkMatesMentorEmailValue.Text = selectedMentor.MentorEmail;
            lblWorkMatesMentorPhoneValue.Text = selectedMentor.MentorPhone;

            if (selectedMentor.MentorBio != null)
            {
                rbxWorkMatesMentorBioValue.Text = selectedMentor.MentorBio;
            }
            else
            {
                rbxWorkMatesMentorBioValue.Text = "No info...";
            }

            if (selectedMentor.MentorPhoto != null)
            {
                pbxWorkMatesMentorPhoto.Image = Image.FromFile(selectedMentor.MentorPhoto);
            }
        }
    }
}
