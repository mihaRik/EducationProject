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
        static Students stud;
        IQueryable<StudentTasks> studTask;
        Tasks task;
        Groups studGroup;
        Teachers studTeacher;
        Mentors studMentor;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            stud = db.Students.ToList().Find(x => x.UserId == Controller.Controller.user.UserId);
            studTask = db.StudentTasks.Where(x => x.StudentId == stud.StudentId);
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
                    foreach (StudentTasks studentTasks in studTask)
                    {
                        task = db.Tasks.ToList().Find(x => x.TaskId == studentTasks.TaskId);
                        string taskName = task.TaskName;
                        cbxSelectTask.Items.Add(taskName);
                    }

                    if (studTask.Where(x => x.TaskPoint != null).Count() != 0)
                    {
                        double studAvgPoint = (double)studTask.Where(x => x.TaskPoint != null).Average(x => x.TaskPoint);
                    }
                    else
                    {
                        lblStudentAvgPointValue.Text = "You don`t have any points";
                    }
                    break;

                case 2:
                    if (stud.GroupId != null)
                    {
                        studGroup = db.Groups.ToList().Find(x => x.GroupId == stud.GroupId);
                        studTeacher = db.Teachers.ToList().Find(x => x.TeacherId == studGroup.TeacherId);
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
                        studMentor = db.Mentors.ToList().Find(x => x.MentorId == studGroup.MentorId);

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

                default:
                    break;
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
    }
}
