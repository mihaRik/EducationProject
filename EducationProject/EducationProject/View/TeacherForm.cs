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
        private static List<Messages> teacherMessages;
        private static List<Messages> teacherSentMessages;

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
            // TODO: This line of code loads data into the 'educationProjectDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.educationProjectDataSet.Messages);
            // TODO: This line of code loads data into the 'educationProjectDataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.educationProjectDataSet1.Students);
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

                case 2:
                    {
                        List<Groups> teacherGroups = db.Groups.Where(x => x.TeacherId == teacher.TeacherId).ToList();

                        cbxSelectGroup.DisplayMember = "GroupName";
                        cbxSelectGroup.ValueMember = "GroupId";

                        FillComboBox(teacherGroups, cbxSelectGroup);

                        cbxAssignTaskToStudentsSelectGroup.DisplayMember = "GroupName";
                        cbxAssignTaskToStudentsSelectGroup.ValueMember = "GroupId";

                        FillComboBox(teacherGroups, cbxAssignTaskToStudentsSelectGroup);

                        List<Tasks> tasks = db.Tasks.Where(x => x.TaskCategory == teacher.ProgramId).ToList();

                        cbxSelectTask.DisplayMember = "TaskName";
                        cbxSelectTask.ValueMember = "TaskId";

                        FillComboBox(tasks, cbxSelectTask);

                        //assign task

                        cbxAssignTaskToStudentsSelectTask.DisplayMember = "TaskName";
                        cbxAssignTaskToStudentsSelectTask.ValueMember = "TaskId";

                        FillComboBox(tasks, cbxAssignTaskToStudentsSelectTask);

                        cbxSelectSelectedAssignedTaskToStudents.DisplayMember = "TaskName";
                        cbxSelectSelectedAssignedTaskToStudents.ValueMember = "TaskId";

                        FillComboBox(tasks, cbxSelectSelectedAssignedTaskToStudents);

                        //point

                        cbxSelectTaskPoint.DisplayMember = "TaskName";
                        cbxSelectTaskPoint.ValueMember = "TaskId";

                        FillComboBox(tasks, cbxSelectTaskPoint);
                    }
                    break;

                case 3:
                    {
                        List<Groups> teacherGroups = db.Groups.Where(x => x.TeacherId == teacher.TeacherId).ToList();
                        List<Students> teacherStudents = new List<Students>();

                        cbxGroupsSelectGroup.DisplayMember = "GroupName";
                        cbxGroupsSelectGroup.ValueMember = "GroupId";
                        cbxGroupsSelectGroup.DataSource = teacherGroups;

                        foreach (Groups group in teacherGroups)
                        {
                            teacherStudents.AddRange(db.Students.Where(x => x.GroupId == group.GroupId));
                        }

                        dgvGroupsStudentsList.DataSource = teacherStudents;
                    }
                    break;

                case 4:
                    {
                        cbxMentorsSelectMentor.DisplayMember = "MentorName";
                        cbxMentorsSelectMentor.ValueMember = "MentorId";

                        List<Groups> teacherGroups = db.Groups
                            .Where(x => x.TeacherId == teacher.TeacherId).ToList();

                        List<Mentors> teacherMentors = new List<Mentors>();

                        foreach (Groups group in teacherGroups)
                        {
                            if (!teacherMentors.Exists(x => x.MentorId == group.MentorId))
                            {
                                teacherMentors.Add(db.Mentors
                                    .ToList().Find(x => x.MentorId == group.MentorId));
                            }
                        }
                        cbxMentorsSelectMentor.DataSource = teacherMentors;

                    }
                    break;

                case 5:
                    {
                        teacherMessages = db.Messages
                            .Where(x => x.ReceiverEmail == teacher.TeacherEmail).ToList();

                        teacherSentMessages = db.Messages
                            .Where(x => x.SenderEmail == teacher.TeacherEmail).ToList();

                        dgvMessagesSent.DataSource = teacherSentMessages;
                        dgvInbox.DataSource = teacherMessages;
                    }
                    break;

                case 6:
                    {
                        cbxWorkmatesSelectTeacher.DisplayMember = "TeacherName";
                        cbxWorkmatesSelectTeacher.ValueMember = "TeacherId";

                        cbxWorkmatesSelectTeacher.DataSource = db.Teachers
                            .Where(x => x.TeacherId != teacher.TeacherId).ToList();
                    }
                    break;

                default:
                    break;
            }
        }

        private void FillComboBox<T>(List<T> list, ComboBox comboBox)
        {
            if (list.Count == 0)
            {
                comboBox.Text = "No info";
            }
            else
            {
                comboBox.DataSource = list;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks()
            {
                TaskName = tbxAddTaskName.Text,
                TaskSubject = tbxAddTaskSubject.Text,
                TaskBody = rbxAddTaskBody.Text,
                TaskCategory = teacher.ProgramId
            };
            db.Tasks.Add(task);
            db.SaveChanges();

            LoadTask();
            MessageBox.Show("Task added!");
        }

        private void dgvTasksList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvTasksList.CurrentRow;
            Tasks selectedTask = db.Tasks.ToList()
                .Find(x => x.TaskId == (int)selectedRow.Cells[3].Value
                && teacher.ProgramId==x.TaskCategory);

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

            if (db.StudentTasks.ToList().Exists(x => x.TaskId == selectedTask.TaskId))
            {

                if (MessageBox.Show("Your student have this task!\nDo you want to delete this task from students too?",
                    "Delete task from student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.StudentTasks.RemoveRange(db.StudentTasks.Where(x => x.TaskId == selectedTask.TaskId));
                    db.Tasks.Remove(selectedTask);
                    db.SaveChanges();
                }
            }
            else
            {
                db.Tasks.Remove(selectedTask);
                db.SaveChanges();
            }

            LoadTask();
            btnUpdateTask.Enabled = false;
            btnRemoveTask.Enabled = false;
            MessageBox.Show("Task removed");
        }

        private void btnAssginTask_Click(object sender, EventArgs e)
        {
            List<Students> selectedGroupStudents = db.Students.Where(x => x.GroupId == (int)cbxSelectGroup.SelectedValue).ToList();

            foreach (Students student in selectedGroupStudents)
            {
                StudentTasks studentTask = new StudentTasks()
                {
                    StudentId = student.StudentId,
                    TaskId = (int)cbxSelectTask.SelectedValue,
                    TaskStartDate = dtpTaskEndDate.Value,
                    TaskEndDate = dtpTaskEndDate.Value
                };

                db.StudentTasks.Add(studentTask);
                db.SaveChanges();
            }

            MessageBox.Show("Task assigned to group!");
        }

        private void cbxAssignTaskToStudentsSelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbxSelectStudent.Items.Clear();

            List<Students> students = db.Students.Where(x => x.GroupId ==
            (int)cbxAssignTaskToStudentsSelectGroup.SelectedValue).ToList();

            foreach (Students student in students)
            {
                chbxSelectStudent.Items.Add(student.StudentName);
            }
        }

        private void btnAssignTaskToStudents_Click(object sender, EventArgs e)
        {
            var selectedStudents = chbxSelectStudent.CheckedItems;

            if (chbxSelectStudent.CheckedItems.Count != 0)
            {
                foreach (var item in selectedStudents)
                {
                    Students eachStudent = db.Students.ToList().Find(x => x.StudentName == item.ToString());

                    StudentTasks studentTask = new StudentTasks()
                    {
                        StudentId = eachStudent.StudentId,
                        TaskId = (int)cbxAssignTaskToStudentsSelectTask.SelectedValue,
                        TaskStartDate = dtpAssignTaskToStudentsStartDate.Value,
                        TaskEndDate = dtpAssignTaskToStudentsEndDate.Value,
                    };

                    db.StudentTasks.Add(studentTask);
                    db.SaveChanges();

                    MessageBox.Show("Task added for each student!");
                }
            }
            else
            {
                MessageBox.Show("Please select students!");
            }
        }

        private void btnShowTeacherAllStudents_Click(object sender, EventArgs e)
        {
            chbxSelectStudent.Items.Clear();

            List<Groups> teacherGroups = db.Groups.Where(x => x.TeacherId == teacher.TeacherId).ToList();
            List<Students> teacherAllStudents = new List<Students>();

            foreach (Groups group in teacherGroups)
            {
                teacherAllStudents.AddRange(db.Students.Where(x => x.GroupId == group.GroupId).ToList());
            }

            foreach (Students student in teacherAllStudents)
            {
                chbxSelectStudent.Items.Add(student.StudentName);
            }
        }

        private void cbxSelectSelectedAssignedTaskToStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxSelectedStudentFromAssignedTasks.Items.Clear();

            List<StudentTasks> studentTask = db.StudentTasks
                .Where(x => x.TaskId == (int)cbxSelectSelectedAssignedTaskToStudents.SelectedValue).ToList();

            foreach (StudentTasks task in studentTask)
            {
                lbxSelectedStudentFromAssignedTasks.Items
                    .Add(db.Students.ToList().Find(x => x.StudentId == task.StudentId).StudentName);
            }

        }

        private void cbxSelectTaskPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Students> students = new List<Students>();

            List<StudentTasks> studentTasks = db.StudentTasks
                .Where(x => x.TaskId == (int)cbxSelectTaskPoint.SelectedValue).ToList();

            foreach (StudentTasks task in studentTasks)
            {
                students.AddRange(db.Students.Where(x => x.StudentId == task.StudentId));
            }

            cbxSelectStudentForPoint.DisplayMember = "StudentName";
            cbxSelectStudentForPoint.ValueMember = "StudentId";

            cbxSelectStudentForPoint.DataSource = students;
        }

        private void cbxSelectStudentForPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentTasks selectedTask = db.StudentTasks.ToList()
                .Find(x => x.StudentId == (int)cbxSelectStudentForPoint.SelectedValue
                && x.TaskId == (int)cbxSelectTaskPoint.SelectedValue);

            dtpSelectedStudentTaskStartDate.Value = selectedTask.TaskStartDate;
            dtpSelectedStudentTaskEndDate.Value = selectedTask.TaskEndDate;

            if (selectedTask.TaskPoint != null)
            {
                tbxSelectedStudentPoint.Text = selectedTask.TaskPoint.ToString();
            }
            else
            {
                tbxSelectedStudentPoint.Text = "No point";
            }
        }

        private void btnAssignPoint_Click(object sender, EventArgs e)
        {
            int result;

            if (Int32.TryParse(tbxSelectedStudentPoint.Text, out result))
            {
                StudentTasks selectedTask = db.StudentTasks.ToList()
                    .Find(x => x.StudentId == (int)cbxSelectStudentForPoint.SelectedValue
                    && x.TaskId == (int)cbxSelectTaskPoint.SelectedValue);

                selectedTask.TaskPoint = result;
                db.SaveChanges();

                MessageBox.Show("Point added!");
            }
            else
            {
                MessageBox.Show("Please input correct info!");
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

            tbxGroupsInfoGroupMentor.Text = db.Mentors.ToList()
                .Find(x => x.MentorId == selectedGroup.MentorId).MentorName;
        }

        private void btnGoupsShowAllStudents_Click(object sender, EventArgs e)
        {
            List<Groups> teacherGroups = db.Groups.Where(x => x.TeacherId == teacher.TeacherId).ToList();
            List<Students> teacherStudents = new List<Students>();

            foreach (Groups group in teacherGroups)
            {
                teacherStudents.AddRange(db.Students.Where(x => x.GroupId == group.GroupId));
            }

            dgvGroupsStudentsList.DataSource = teacherStudents;
        }

        private void tbxGroupsSearchByName_TextChanged(object sender, EventArgs e)
        {
            List<Groups> teacherGroups = db.Groups.Where(x => x.TeacherId == teacher.TeacherId).ToList();
            List<Students> teacherStudents = new List<Students>();

            foreach (Groups group in teacherGroups)
            {
                teacherStudents.AddRange(db.Students.Where(x => x.GroupId == group.GroupId));
            }

            List<Students> filteredStudents = teacherStudents
                .Where(x => x.StudentName.Contains(tbxGroupsSearchByName.Text)).ToList();

            dgvGroupsStudentsList.DataSource = filteredStudents;
        }

        private void cbxMentorsSelectMentor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mentors selectedMentor = db.Mentors.ToList()
                .Find(x => x.MentorId == (int)cbxMentorsSelectMentor.SelectedValue);

            lblMentorsNameValue.Text = selectedMentor.MentorName;
            lblMentorsSurnameValue.Text = selectedMentor.MentorSurname;
            lblMentorsEmailValue.Text = selectedMentor.MentorEmail;
            lblMentorsPhoneValue.Text = selectedMentor.MentorPhone;

            if (selectedMentor.MentorBio != null)
            {
                rbxMentorsBioValue.Text = selectedMentor.MentorBio;
            }
            else
            {
                rbxMentorsBioValue.Text = "No info...";
            }

            if (selectedMentor.MentorPhoto != null)
            {
                pbxMentorsPhoto.Image = Image.FromFile(selectedMentor.MentorPhoto);
            }
        }

        private void btnSendMessage_Click_1(object sender, EventArgs e)
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
                        SenderEmail = teacher.TeacherEmail,
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
            teachersList.DataSource = db.Teachers.Where(x=>x.TeacherId!=teacher.TeacherId).ToList();

            teachersList.SelectedValueChanged += TeachersList_SelectedValueChanged;
        }

        private void TeachersList_SelectedValueChanged(object sender, EventArgs e)
        {
            SetTextboxOfReceiver(sender);
        }

        private void SetTextboxOfReceiver(object sender)
        {
            ComboBox comboBox = (ComboBox)sender as ComboBox;
            tbxMessageReceiver.Text = (string)comboBox.SelectedValue;
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

            mentorsList.DataSource = db.Mentors.ToList();

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

            List<Groups> teacherGroups = db.Groups.Where(x => x.TeacherId == teacher.TeacherId).ToList();

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
    }
}
