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
using EducationProject.Controller;

namespace EducationProject.View
{
    public partial class StudentsForm : Form
    {
        static EducationProjectEntities db = Controller.Controller.db;
        Students stud;
        List<StudentTasks> studTask;
        Tasks task;
        Groups studGroup;
        Teachers studTeacher;
        Mentors studMentor;
        List<Messages> studMessages;
        List<Messages> studSentMessages;
        List<Students> studGroupmates;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            stud = db.Students.ToList().Find(x => x.UserId == Controller.Controller.user.UserId);
            studTask = db.StudentTasks.Where(x => x.StudentId == stud.StudentId).ToList();
            studGroupmates = db.Students.Where(x => x.GroupId != null && x.GroupId == stud.GroupId && x.StudentId != stud.StudentId).ToList();

            if (stud.GroupId != null)
            {
                studGroup = db.Groups.ToList().Find(x => x.GroupId == stud.GroupId);
                studTeacher = db.Teachers.ToList().Find(x => x.TeacherId == studGroup.TeacherId);
                studMentor = db.Mentors.ToList().Find(x => x.MentorId == studGroup.MentorId);
            }

            lblStudentNameValue.Text = stud.StudentName;
            lblStudentSurnameValue.Text = stud.StudentSurname;
            lblStudentEmailValue.Text = stud.StudentEmail;
            string studentPassword = Controller.Controller.user.UserPassword;

            lblStudentPasswordValue.Text = Controller.Controller.HidePassword(studentPassword);
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

            if (!String.IsNullOrEmpty(stud.StudentBio))
            {
                rbxStudentBio.Text = stud.StudentBio;
            }
            else
            {
                rbxStudentBio.Text = "No info...";
            }

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
            Label noGroup = new Label()
            {
                AutoSize = true,
                Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                Text = "You dont have any group yet"
            };

            noGroup.Left = Width / 2 - noGroup.Width * 2;
            noGroup.Top = Height / 2 - noGroup.Height * 2;

            switch (tabControl.SelectedIndex)
            {
                case 1:
                    List<StudentTasks> studentTasks = db.StudentTasks.Where(x => x.StudentId == stud.StudentId).ToList();

                    List<Tasks> tasks = new List<Tasks>();

                    foreach (var item in studentTasks)
                    {
                        tasks.AddRange(db.Tasks.Where(x => x.TaskId == item.TaskId));
                    }
                    cbxSelectTask.DisplayMember = "TaskName";
                    cbxSelectTask.ValueMember = "TaskId";
                    cbxSelectTask.DataSource = tasks;

                    if (studTask.Where(x => x.TaskPoint != null).Count() != 0)
                    {
                        double studAvgPoint = (double)studTask.Average(x => x.TaskPoint);
                        lblStudentAvgPointValue.Text = studAvgPoint.ToString();
                    }
                    else
                    {
                        lblStudentAvgPointValue.Text = "You don`t have any points";
                    }
                    break;

                case 2:
                    if (stud.GroupId != null)
                    {
                        lblStudentTeacherNameValue.Text = studTeacher.TeacherName;
                        lblStudentTeacherSurnameValue.Text = studTeacher.TeacherSurname;
                        lblStudentTeacherEmailValue.Text = studTeacher.TeacherEmail;
                        lblStudentTeacherPhoneValue.Text = studTeacher.TeacherPhone;

                        if (!String.IsNullOrEmpty(studTeacher.TeacherBio))
                        {
                            rbxStudentTeacherBio.Text = studTeacher.TeacherBio;
                        }
                        else
                        {
                            rbxStudentTeacherBio.Text = "No info...";
                        }

                        if (!String.IsNullOrEmpty(studTeacher.TeacherPhoto))
                        {
                            pbxStudentTeacherPhoto.Image = Image.FromFile(studTeacher.TeacherPhoto);
                        }
                    }
                    else
                    {
                        tabControl.SelectedTab.Controls.Clear();
                        tabControl.SelectedTab.Controls.Add(noGroup);
                    }
                    break;

                case 3:
                    if (stud.GroupId != null)
                    {
                        lblStudentMentorNameValue.Text = studMentor.MentorName;
                        lblStudentMentorSurnameValue.Text = studMentor.MentorSurname;
                        lblStudentMentorEmailValue.Text = studMentor.MentorEmail;
                        lblStudentMentorPhoneValue.Text = studMentor.MentorPhone;

                        if (!String.IsNullOrEmpty(studMentor.MentorBio))
                        {
                            rbxStudentMentorBio.Text = studMentor.MentorBio;
                        }
                        else
                        {
                            rbxStudentMentorBio.Text = "No info";
                        }

                        if (!String.IsNullOrEmpty(studMentor.MentorPhoto))
                        {
                            pbxStudentMentorPhoto.Image = Image.FromFile(stud.StudentPhoto);
                        }
                    }
                    else
                    {
                        tabControl.SelectedTab.Controls.Clear();
                        tabControl.SelectedTab.Controls.Add(noGroup);
                    }
                    break;

                case 4:
                    studMessages = db.Messages.Where(x => x.ReceiverEmail == stud.StudentEmail).ToList();
                    studSentMessages = db.Messages.Where(x => x.SenderEmail == stud.StudentEmail).ToList();
                    dgvMessagesSent.DataSource = studSentMessages;
                    dgvInbox.DataSource = studMessages;
                    break;

                case 5:
                    if (studGroup != null)
                    {
                        cbxGroupmates.DisplayMember = "StudentName";
                        cbxGroupmates.ValueMember = "StudentId";
                        cbxGroupmates.DataSource = db.Students.Where(x => x.StudentId != stud.StudentId &&
                        x.GroupId == studGroup.GroupId).ToList();
                    }
                    else
                    {
                        tabGroupmates.Controls.Clear();
                        noGroup.Text = "You dont have any groupmates yet";
                        tabGroupmates.Controls.Add(noGroup);
                    }
                    break;

                default:
                    break;
            }
        }

        private void cbxSelectTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks selectedTask = db.Tasks.ToList().Find(x => x.TaskId ==
            (int)cbxSelectTask.SelectedValue);

            lblStudentTaskSubjectValue.Text = selectedTask.TaskSubject;
            rbxStudentTaskBody.Text = selectedTask.TaskBody;

            StudentTasks selectedStudentTask = db.StudentTasks.ToList().Find(x => x.TaskId == selectedTask.TaskId);

            if (selectedStudentTask.TaskPoint.HasValue)
            {
                lblStudentTaskPointValue.Text = selectedStudentTask.TaskPoint.ToString();
            }
            else
            {
                lblStudentTaskPointValue.Text = "No point yet...";
            }
            lblStudentTaskStartDateValue.Text = selectedStudentTask.TaskStartDate.ToString();
            lblStudentTaskEndDateValue.Text = selectedStudentTask.TaskEndDate.ToString();
        }

        private void btnStudentSaveChangeBio_Click(object sender, EventArgs e)
        {
            stud.StudentBio = rbxStudentBio.Text;
            db.SaveChanges();
            MessageBox.Show("Bio changed!");
        }

        private void rbxStudentBio_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnStudentSaveChangeBio.Visible = true;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxMessageReceiver.Text) || String.IsNullOrEmpty(rbxMessageInboxBody.Text))
            {
                MessageBox.Show("Please fill out all required inputs!");
            }
            else
            {
                if (db.Users.ToList().Exists(x => x.UserEmail == tbxMessageReceiver.Text))
                {
                    Messages msg = new Messages()
                    {
                        SenderEmail = stud.StudentEmail,
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

        private void btnSendToTeacher_Click(object sender, EventArgs e)
        {
            if (studTeacher != null)
            {
                tbxMessageReceiver.Text = studTeacher.TeacherEmail;
            }
            else
            {
                MessageBox.Show("You dont have a teacher!");
            }
        }

        private void btnSendToMentor_Click(object sender, EventArgs e)
        {
            if (studMentor != null)
            {
                tbxMessageReceiver.Text = studMentor.MentorEmail;
            }
            else
            {
                MessageBox.Show("You dont have a mentor!");
            }
        }

        private void dgvMessagesSent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMessagesSentReceiverValue.Text = dgvMessagesSent.CurrentRow.Cells[0].Value.ToString();
            lblMessagesSentSubjectValue.Text = dgvMessagesSent.CurrentRow.Cells[2].Value.ToString();
            rbxMessagesSent.Text = dgvMessagesSent.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSendToGroupMates_Click(object sender, EventArgs e)
        {
            if (studGroup != null)
            {
                tabMessagesSendTo.Controls.Remove(tbxMessageReceiver);

                ComboBox cbxSelecetReceiver = new ComboBox()
                {
                    Top = tbxMessageReceiver.Top,
                    Left = tbxMessageSubject.Left,
                    Width = tbxMessageSubject.Width
                };

                studGroupmates.ForEach(x => cbxSelecetReceiver.Items.Add(x.StudentEmail));

                tabMessagesSendTo.Controls.Add(cbxSelecetReceiver);
            }
            else
            {
                MessageBox.Show("You dont have groupmates!");
            }
        }

        private void cbxGroupmates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students selectedGroupmate = studGroupmates
                .Find(x => x.StudentId == (int)cbxGroupmates.SelectedValue);

            if (selectedGroupmate.StudentPhoto != null)
            {
                pbxGroupmatePhoto.Image = Image.FromFile(selectedGroupmate.StudentPhoto);
            }

            lblGroupmateNameValue.Text = selectedGroupmate.StudentName;
            lblGroupmateSurnameValue.Text = selectedGroupmate.StudentSurname;
            lblGroupmateEmailValue.Text = selectedGroupmate.StudentEmail;
            lblGroupmatePhoneValue.Text = selectedGroupmate.StudentPhone;
            lblGroupmateBirthdateValue.Text = selectedGroupmate.StudentBirthDate.ToString();
            lblGroupmateRegisterDateValue.Text = selectedGroupmate.StudentRegistrationDate.ToShortDateString();

            if (selectedGroupmate.GroupId != null)
            {
                Groups selectedMateGroup = db.Groups.ToList().Find(x => x.GroupId == selectedGroupmate.GroupId);
                lblGroupmateGroupValue.Text = selectedMateGroup.GroupName;
            }

            if (selectedGroupmate.StudentBio != null)
            {
                rbxGroupmateBio.Text = selectedGroupmate.StudentBio;
            }
            else
            {
                rbxGroupmateBio.Text = "No info...";
            }
        }
    }
}
