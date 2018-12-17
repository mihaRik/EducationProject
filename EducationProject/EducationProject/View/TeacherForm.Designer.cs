namespace EducationProject.View
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.tabControlTeacher = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.btnSaveChangePhone = new System.Windows.Forms.Button();
            this.btnSaveChangePassword = new System.Windows.Forms.Button();
            this.tbxTeacherPhoneValue = new System.Windows.Forms.TextBox();
            this.tbxTeacherPasswordValue = new System.Windows.Forms.TextBox();
            this.btnTeacherSaveChangeBio = new System.Windows.Forms.Button();
            this.rbxTeacherBio = new System.Windows.Forms.RichTextBox();
            this.lblTeacherBio = new System.Windows.Forms.Label();
            this.btnTeacherChangePhoto = new System.Windows.Forms.Button();
            this.btnEditPhone = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.lblTeacherPassword = new System.Windows.Forms.Label();
            this.lblTeacherPhone = new System.Windows.Forms.Label();
            this.lblTeacherEmailValue = new System.Windows.Forms.Label();
            this.lblTeacherEmail = new System.Windows.Forms.Label();
            this.lblTeacherSurnameValue = new System.Windows.Forms.Label();
            this.lblTeacherSurname = new System.Windows.Forms.Label();
            this.lblTeacherNameValue = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherInfo = new System.Windows.Forms.Label();
            this.pbxTeacherPhoto = new System.Windows.Forms.PictureBox();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.gbxUpdateTask = new System.Windows.Forms.GroupBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.rbxUpdateTaskBody = new System.Windows.Forms.RichTextBox();
            this.label1lblUpdateTaskBody = new System.Windows.Forms.Label();
            this.tbxUpdateTaskSubject = new System.Windows.Forms.TextBox();
            this.lblUpdateTaskSubject = new System.Windows.Forms.Label();
            this.tbxUpdateTaskName = new System.Windows.Forms.TextBox();
            this.lblUpdateTaskName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.rbxAddTaskBody = new System.Windows.Forms.RichTextBox();
            this.lblAddTaskBody = new System.Windows.Forms.Label();
            this.tbxAddTaskSubject = new System.Windows.Forms.TextBox();
            this.lblAddTaskSubject = new System.Windows.Forms.Label();
            this.tbxAddTaskName = new System.Windows.Forms.TextBox();
            this.lblAddTaskName = new System.Windows.Forms.Label();
            this.dgvTasksList = new System.Windows.Forms.DataGridView();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet5 = new EducationProject.EducationProjectDataSet5();
            this.lblTasks = new System.Windows.Forms.Label();
            this.tabAssignTask = new System.Windows.Forms.TabPage();
            this.gbxAssignTaskToStudents = new System.Windows.Forms.GroupBox();
            this.btnShowTeacherAllStudents = new System.Windows.Forms.Button();
            this.lblAssignTaskToStidentsSelectEndDate = new System.Windows.Forms.Label();
            this.chbxSelectStudent = new System.Windows.Forms.CheckedListBox();
            this.lblAssignTaskToStidentsSelectStartDate = new System.Windows.Forms.Label();
            this.dtpAssignTaskToStudentsEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAssignTaskToStudentsStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAssignTaskToStudents = new System.Windows.Forms.Button();
            this.cbxAssignTaskToStudentsSelectTask = new System.Windows.Forms.ComboBox();
            this.lblAssignTaskToStidentsSelectTask = new System.Windows.Forms.Label();
            this.cbxAssignTaskToStudentsSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblAssignTaskToStidentsSelectGroup = new System.Windows.Forms.Label();
            this.gbxAssignTaskToGroup = new System.Windows.Forms.GroupBox();
            this.lblTaskEndDate = new System.Windows.Forms.Label();
            this.lblTaskStartDate = new System.Windows.Forms.Label();
            this.dtpTaskEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAssginTask = new System.Windows.Forms.Button();
            this.cbxSelectTask = new System.Windows.Forms.ComboBox();
            this.lblSelectTask = new System.Windows.Forms.Label();
            this.cbxSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.tabMentorInfo = new System.Windows.Forms.TabPage();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tabWorkMates = new System.Windows.Forms.TabPage();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.tasksTableAdapter = new EducationProject.EducationProjectDataSet5TableAdapters.TasksTableAdapter();
            this.groupsTableAdapter1 = new EducationProject.EducationProjectDataSet3TableAdapters.GroupsTableAdapter();
            this.gbxAssignedTasksToStudents = new System.Windows.Forms.GroupBox();
            this.cbxSelectSelectedAssignedTaskToStudents = new System.Windows.Forms.ComboBox();
            this.lblSelectAssignedTaskToStudents = new System.Windows.Forms.Label();
            this.lblSelectedStudentsFromAssignedTasks = new System.Windows.Forms.Label();
            this.lbxSelectedStudentFromAssignedTasks = new System.Windows.Forms.ListBox();
            this.gbxTaskPoint = new System.Windows.Forms.GroupBox();
            this.cbxSelectTaskPoint = new System.Windows.Forms.ComboBox();
            this.lblSelectTaskPoint = new System.Windows.Forms.Label();
            this.lblSelectedStudentsForPoints = new System.Windows.Forms.Label();
            this.cbxSelectStudentForPoint = new System.Windows.Forms.ComboBox();
            this.lblSelectedStudentTaskStartDate = new System.Windows.Forms.Label();
            this.lblSelectedStudentTaskEndDate = new System.Windows.Forms.Label();
            this.lblSelectedStudentTaskPoint = new System.Windows.Forms.Label();
            this.dtpSelectedStudentTaskEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSelectedStudentTaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbxSelectedStudentPoint = new System.Windows.Forms.TextBox();
            this.btnAssignPoint = new System.Windows.Forms.Button();
            this.lblGroupsSelectGroup = new System.Windows.Forms.Label();
            this.cbxGroupsSelectGroup = new System.Windows.Forms.ComboBox();
            this.gbxGroupsInfo = new System.Windows.Forms.GroupBox();
            this.dgvGroupsStudentsList = new System.Windows.Forms.DataGridView();
            this.educationProjectDataSet3 = new EducationProject.EducationProjectDataSet3();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGroups = new System.Windows.Forms.Label();
            this.lblGroupsSearchByName = new System.Windows.Forms.Label();
            this.tbxGroupsSearchByName = new System.Windows.Forms.TextBox();
            this.tbxGroupsInfoGroupType = new System.Windows.Forms.TextBox();
            this.lblGroupsInfoGroupType = new System.Windows.Forms.Label();
            this.lblGroupsInfoName = new System.Windows.Forms.Label();
            this.tbxGroupsInfoName = new System.Windows.Forms.TextBox();
            this.tbxGroupsInfoGroupTime = new System.Windows.Forms.TextBox();
            this.tbxGroupsInfoGroupMentor = new System.Windows.Forms.TextBox();
            this.lblGroupsInfoGroupMentor = new System.Windows.Forms.Label();
            this.lblGroupsInfoGroupTime = new System.Windows.Forms.Label();
            this.educationProjectDataSet1 = new EducationProject.EducationProjectDataSet1();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new EducationProject.EducationProjectDataSet1TableAdapters.StudentsTableAdapter();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGoupsShowAllStudents = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlTeacher.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).BeginInit();
            this.tabTask.SuspendLayout();
            this.gbxUpdateTask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet5)).BeginInit();
            this.tabAssignTask.SuspendLayout();
            this.gbxAssignTaskToStudents.SuspendLayout();
            this.gbxAssignTaskToGroup.SuspendLayout();
            this.tabGroups.SuspendLayout();
            this.tabMentorInfo.SuspendLayout();
            this.gbxAssignedTasksToStudents.SuspendLayout();
            this.gbxTaskPoint.SuspendLayout();
            this.gbxGroupsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTeacher
            // 
            this.tabControlTeacher.Controls.Add(this.tabInfo);
            this.tabControlTeacher.Controls.Add(this.tabTask);
            this.tabControlTeacher.Controls.Add(this.tabAssignTask);
            this.tabControlTeacher.Controls.Add(this.tabGroups);
            this.tabControlTeacher.Controls.Add(this.tabMentorInfo);
            this.tabControlTeacher.Controls.Add(this.tabMessages);
            this.tabControlTeacher.Controls.Add(this.tabWorkMates);
            this.tabControlTeacher.Controls.Add(this.tabLibrary);
            this.tabControlTeacher.Location = new System.Drawing.Point(0, 0);
            this.tabControlTeacher.Name = "tabControlTeacher";
            this.tabControlTeacher.SelectedIndex = 0;
            this.tabControlTeacher.Size = new System.Drawing.Size(804, 455);
            this.tabControlTeacher.TabIndex = 0;
            this.tabControlTeacher.SelectedIndexChanged += new System.EventHandler(this.tabControlTeacher_SelectedIndexChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.btnSaveChangePhone);
            this.tabInfo.Controls.Add(this.btnSaveChangePassword);
            this.tabInfo.Controls.Add(this.tbxTeacherPhoneValue);
            this.tabInfo.Controls.Add(this.tbxTeacherPasswordValue);
            this.tabInfo.Controls.Add(this.btnTeacherSaveChangeBio);
            this.tabInfo.Controls.Add(this.rbxTeacherBio);
            this.tabInfo.Controls.Add(this.lblTeacherBio);
            this.tabInfo.Controls.Add(this.btnTeacherChangePhoto);
            this.tabInfo.Controls.Add(this.btnEditPhone);
            this.tabInfo.Controls.Add(this.btnEditPassword);
            this.tabInfo.Controls.Add(this.lblTeacherPassword);
            this.tabInfo.Controls.Add(this.lblTeacherPhone);
            this.tabInfo.Controls.Add(this.lblTeacherEmailValue);
            this.tabInfo.Controls.Add(this.lblTeacherEmail);
            this.tabInfo.Controls.Add(this.lblTeacherSurnameValue);
            this.tabInfo.Controls.Add(this.lblTeacherSurname);
            this.tabInfo.Controls.Add(this.lblTeacherNameValue);
            this.tabInfo.Controls.Add(this.lblTeacherName);
            this.tabInfo.Controls.Add(this.lblTeacherInfo);
            this.tabInfo.Controls.Add(this.pbxTeacherPhoto);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(796, 429);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // btnSaveChangePhone
            // 
            this.btnSaveChangePhone.AutoSize = true;
            this.btnSaveChangePhone.Location = new System.Drawing.Point(401, 177);
            this.btnSaveChangePhone.Name = "btnSaveChangePhone";
            this.btnSaveChangePhone.Size = new System.Drawing.Size(83, 23);
            this.btnSaveChangePhone.TabIndex = 74;
            this.btnSaveChangePhone.Text = "Save";
            this.btnSaveChangePhone.UseVisualStyleBackColor = true;
            this.btnSaveChangePhone.Visible = false;
            this.btnSaveChangePhone.Click += new System.EventHandler(this.btnSaveChangePhone_Click);
            // 
            // btnSaveChangePassword
            // 
            this.btnSaveChangePassword.AutoSize = true;
            this.btnSaveChangePassword.Location = new System.Drawing.Point(409, 145);
            this.btnSaveChangePassword.Name = "btnSaveChangePassword";
            this.btnSaveChangePassword.Size = new System.Drawing.Size(83, 23);
            this.btnSaveChangePassword.TabIndex = 73;
            this.btnSaveChangePassword.Text = "Save";
            this.btnSaveChangePassword.UseVisualStyleBackColor = true;
            this.btnSaveChangePassword.Visible = false;
            this.btnSaveChangePassword.Click += new System.EventHandler(this.btnSaveChangePassword_Click);
            // 
            // tbxTeacherPhoneValue
            // 
            this.tbxTeacherPhoneValue.Location = new System.Drawing.Point(214, 180);
            this.tbxTeacherPhoneValue.Name = "tbxTeacherPhoneValue";
            this.tbxTeacherPhoneValue.ReadOnly = true;
            this.tbxTeacherPhoneValue.Size = new System.Drawing.Size(100, 20);
            this.tbxTeacherPhoneValue.TabIndex = 72;
            // 
            // tbxTeacherPasswordValue
            // 
            this.tbxTeacherPasswordValue.Location = new System.Drawing.Point(214, 148);
            this.tbxTeacherPasswordValue.Name = "tbxTeacherPasswordValue";
            this.tbxTeacherPasswordValue.ReadOnly = true;
            this.tbxTeacherPasswordValue.Size = new System.Drawing.Size(100, 20);
            this.tbxTeacherPasswordValue.TabIndex = 71;
            // 
            // btnTeacherSaveChangeBio
            // 
            this.btnTeacherSaveChangeBio.AutoSize = true;
            this.btnTeacherSaveChangeBio.Location = new System.Drawing.Point(342, 319);
            this.btnTeacherSaveChangeBio.Name = "btnTeacherSaveChangeBio";
            this.btnTeacherSaveChangeBio.Size = new System.Drawing.Size(86, 23);
            this.btnTeacherSaveChangeBio.TabIndex = 70;
            this.btnTeacherSaveChangeBio.Text = "Save changes";
            this.btnTeacherSaveChangeBio.UseVisualStyleBackColor = true;
            this.btnTeacherSaveChangeBio.Visible = false;
            this.btnTeacherSaveChangeBio.Click += new System.EventHandler(this.btnTeacherSaveChangeBio_Click);
            // 
            // rbxTeacherBio
            // 
            this.rbxTeacherBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxTeacherBio.Location = new System.Drawing.Point(171, 217);
            this.rbxTeacherBio.Name = "rbxTeacherBio";
            this.rbxTeacherBio.Size = new System.Drawing.Size(257, 96);
            this.rbxTeacherBio.TabIndex = 69;
            this.rbxTeacherBio.Text = "";
            this.rbxTeacherBio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbxTeacherBio_KeyPress);
            // 
            // lblTeacherBio
            // 
            this.lblTeacherBio.AutoSize = true;
            this.lblTeacherBio.Location = new System.Drawing.Point(123, 217);
            this.lblTeacherBio.Name = "lblTeacherBio";
            this.lblTeacherBio.Size = new System.Drawing.Size(28, 13);
            this.lblTeacherBio.TabIndex = 68;
            this.lblTeacherBio.Text = "Bio :";
            // 
            // btnTeacherChangePhoto
            // 
            this.btnTeacherChangePhoto.AutoSize = true;
            this.btnTeacherChangePhoto.Location = new System.Drawing.Point(6, 124);
            this.btnTeacherChangePhoto.Name = "btnTeacherChangePhoto";
            this.btnTeacherChangePhoto.Size = new System.Drawing.Size(84, 23);
            this.btnTeacherChangePhoto.TabIndex = 67;
            this.btnTeacherChangePhoto.Text = "Change photo";
            this.btnTeacherChangePhoto.UseVisualStyleBackColor = true;
            // 
            // btnEditPhone
            // 
            this.btnEditPhone.AutoSize = true;
            this.btnEditPhone.Location = new System.Drawing.Point(320, 177);
            this.btnEditPhone.Name = "btnEditPhone";
            this.btnEditPhone.Size = new System.Drawing.Size(75, 23);
            this.btnEditPhone.TabIndex = 65;
            this.btnEditPhone.Text = "Edit phone";
            this.btnEditPhone.UseVisualStyleBackColor = true;
            this.btnEditPhone.Click += new System.EventHandler(this.btnEditPhone_Click);
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.AutoSize = true;
            this.btnEditPassword.Location = new System.Drawing.Point(320, 145);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(83, 23);
            this.btnEditPassword.TabIndex = 64;
            this.btnEditPassword.Text = "Edit password";
            this.btnEditPassword.UseVisualStyleBackColor = true;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // lblTeacherPassword
            // 
            this.lblTeacherPassword.AutoSize = true;
            this.lblTeacherPassword.Location = new System.Drawing.Point(123, 151);
            this.lblTeacherPassword.Name = "lblTeacherPassword";
            this.lblTeacherPassword.Size = new System.Drawing.Size(59, 13);
            this.lblTeacherPassword.TabIndex = 62;
            this.lblTeacherPassword.Text = "Password :";
            // 
            // lblTeacherPhone
            // 
            this.lblTeacherPhone.AutoSize = true;
            this.lblTeacherPhone.Location = new System.Drawing.Point(123, 183);
            this.lblTeacherPhone.Name = "lblTeacherPhone";
            this.lblTeacherPhone.Size = new System.Drawing.Size(44, 13);
            this.lblTeacherPhone.TabIndex = 50;
            this.lblTeacherPhone.Text = "Phone :";
            // 
            // lblTeacherEmailValue
            // 
            this.lblTeacherEmailValue.AutoSize = true;
            this.lblTeacherEmailValue.Location = new System.Drawing.Point(211, 121);
            this.lblTeacherEmailValue.Name = "lblTeacherEmailValue";
            this.lblTeacherEmailValue.Size = new System.Drawing.Size(54, 13);
            this.lblTeacherEmailValue.TabIndex = 49;
            this.lblTeacherEmailValue.Text = "Loading...";
            // 
            // lblTeacherEmail
            // 
            this.lblTeacherEmail.AutoSize = true;
            this.lblTeacherEmail.Location = new System.Drawing.Point(123, 121);
            this.lblTeacherEmail.Name = "lblTeacherEmail";
            this.lblTeacherEmail.Size = new System.Drawing.Size(38, 13);
            this.lblTeacherEmail.TabIndex = 48;
            this.lblTeacherEmail.Text = "Email :";
            // 
            // lblTeacherSurnameValue
            // 
            this.lblTeacherSurnameValue.AutoSize = true;
            this.lblTeacherSurnameValue.Location = new System.Drawing.Point(211, 90);
            this.lblTeacherSurnameValue.Name = "lblTeacherSurnameValue";
            this.lblTeacherSurnameValue.Size = new System.Drawing.Size(54, 13);
            this.lblTeacherSurnameValue.TabIndex = 47;
            this.lblTeacherSurnameValue.Text = "Loading...";
            // 
            // lblTeacherSurname
            // 
            this.lblTeacherSurname.AutoSize = true;
            this.lblTeacherSurname.Location = new System.Drawing.Point(123, 90);
            this.lblTeacherSurname.Name = "lblTeacherSurname";
            this.lblTeacherSurname.Size = new System.Drawing.Size(55, 13);
            this.lblTeacherSurname.TabIndex = 46;
            this.lblTeacherSurname.Text = "Surname :";
            // 
            // lblTeacherNameValue
            // 
            this.lblTeacherNameValue.AutoSize = true;
            this.lblTeacherNameValue.Location = new System.Drawing.Point(211, 61);
            this.lblTeacherNameValue.Name = "lblTeacherNameValue";
            this.lblTeacherNameValue.Size = new System.Drawing.Size(54, 13);
            this.lblTeacherNameValue.TabIndex = 45;
            this.lblTeacherNameValue.Text = "Loading...";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(123, 61);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(41, 13);
            this.lblTeacherName.TabIndex = 44;
            this.lblTeacherName.Text = "Name :";
            // 
            // lblTeacherInfo
            // 
            this.lblTeacherInfo.AutoSize = true;
            this.lblTeacherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeacherInfo.Location = new System.Drawing.Point(118, 6);
            this.lblTeacherInfo.Name = "lblTeacherInfo";
            this.lblTeacherInfo.Size = new System.Drawing.Size(51, 25);
            this.lblTeacherInfo.TabIndex = 43;
            this.lblTeacherInfo.Text = "Info";
            // 
            // pbxTeacherPhoto
            // 
            this.pbxTeacherPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxTeacherPhoto.ErrorImage")));
            this.pbxTeacherPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxTeacherPhoto.Image")));
            this.pbxTeacherPhoto.Location = new System.Drawing.Point(6, 6);
            this.pbxTeacherPhoto.Name = "pbxTeacherPhoto";
            this.pbxTeacherPhoto.Size = new System.Drawing.Size(105, 112);
            this.pbxTeacherPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTeacherPhoto.TabIndex = 42;
            this.pbxTeacherPhoto.TabStop = false;
            // 
            // tabTask
            // 
            this.tabTask.Controls.Add(this.gbxUpdateTask);
            this.tabTask.Controls.Add(this.groupBox1);
            this.tabTask.Controls.Add(this.dgvTasksList);
            this.tabTask.Controls.Add(this.lblTasks);
            this.tabTask.Location = new System.Drawing.Point(4, 22);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(796, 429);
            this.tabTask.TabIndex = 1;
            this.tabTask.Text = "Task";
            this.tabTask.UseVisualStyleBackColor = true;
            // 
            // gbxUpdateTask
            // 
            this.gbxUpdateTask.Controls.Add(this.btnRemoveTask);
            this.gbxUpdateTask.Controls.Add(this.btnUpdateTask);
            this.gbxUpdateTask.Controls.Add(this.rbxUpdateTaskBody);
            this.gbxUpdateTask.Controls.Add(this.label1lblUpdateTaskBody);
            this.gbxUpdateTask.Controls.Add(this.tbxUpdateTaskSubject);
            this.gbxUpdateTask.Controls.Add(this.lblUpdateTaskSubject);
            this.gbxUpdateTask.Controls.Add(this.tbxUpdateTaskName);
            this.gbxUpdateTask.Controls.Add(this.lblUpdateTaskName);
            this.gbxUpdateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdateTask.Location = new System.Drawing.Point(406, 202);
            this.gbxUpdateTask.Name = "gbxUpdateTask";
            this.gbxUpdateTask.Size = new System.Drawing.Size(378, 214);
            this.gbxUpdateTask.TabIndex = 8;
            this.gbxUpdateTask.TabStop = false;
            this.gbxUpdateTask.Text = "Update task";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BackColor = System.Drawing.Color.Red;
            this.btnRemoveTask.Enabled = false;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveTask.Location = new System.Drawing.Point(216, 182);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 8;
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.UseVisualStyleBackColor = false;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Enabled = false;
            this.btnUpdateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateTask.Location = new System.Drawing.Point(297, 182);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTask.TabIndex = 7;
            this.btnUpdateTask.Text = "Update task";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // rbxUpdateTaskBody
            // 
            this.rbxUpdateTaskBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxUpdateTaskBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbxUpdateTaskBody.Location = new System.Drawing.Point(118, 80);
            this.rbxUpdateTaskBody.Name = "rbxUpdateTaskBody";
            this.rbxUpdateTaskBody.Size = new System.Drawing.Size(254, 96);
            this.rbxUpdateTaskBody.TabIndex = 6;
            this.rbxUpdateTaskBody.Text = "";
            // 
            // label1lblUpdateTaskBody
            // 
            this.label1lblUpdateTaskBody.AutoSize = true;
            this.label1lblUpdateTaskBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1lblUpdateTaskBody.Location = new System.Drawing.Point(6, 83);
            this.label1lblUpdateTaskBody.Name = "label1lblUpdateTaskBody";
            this.label1lblUpdateTaskBody.Size = new System.Drawing.Size(73, 16);
            this.label1lblUpdateTaskBody.TabIndex = 4;
            this.label1lblUpdateTaskBody.Text = "Task body";
            // 
            // tbxUpdateTaskSubject
            // 
            this.tbxUpdateTaskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTaskSubject.Location = new System.Drawing.Point(118, 52);
            this.tbxUpdateTaskSubject.Name = "tbxUpdateTaskSubject";
            this.tbxUpdateTaskSubject.Size = new System.Drawing.Size(254, 22);
            this.tbxUpdateTaskSubject.TabIndex = 3;
            // 
            // lblUpdateTaskSubject
            // 
            this.lblUpdateTaskSubject.AutoSize = true;
            this.lblUpdateTaskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTaskSubject.Location = new System.Drawing.Point(6, 55);
            this.lblUpdateTaskSubject.Name = "lblUpdateTaskSubject";
            this.lblUpdateTaskSubject.Size = new System.Drawing.Size(85, 16);
            this.lblUpdateTaskSubject.TabIndex = 2;
            this.lblUpdateTaskSubject.Text = "Task subject";
            // 
            // tbxUpdateTaskName
            // 
            this.tbxUpdateTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTaskName.Location = new System.Drawing.Point(118, 24);
            this.tbxUpdateTaskName.Name = "tbxUpdateTaskName";
            this.tbxUpdateTaskName.Size = new System.Drawing.Size(254, 22);
            this.tbxUpdateTaskName.TabIndex = 1;
            // 
            // lblUpdateTaskName
            // 
            this.lblUpdateTaskName.AutoSize = true;
            this.lblUpdateTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTaskName.Location = new System.Drawing.Point(6, 27);
            this.lblUpdateTaskName.Name = "lblUpdateTaskName";
            this.lblUpdateTaskName.Size = new System.Drawing.Size(76, 16);
            this.lblUpdateTaskName.TabIndex = 0;
            this.lblUpdateTaskName.Text = "Task name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTask);
            this.groupBox1.Controls.Add(this.rbxAddTaskBody);
            this.groupBox1.Controls.Add(this.lblAddTaskBody);
            this.groupBox1.Controls.Add(this.tbxAddTaskSubject);
            this.groupBox1.Controls.Add(this.lblAddTaskSubject);
            this.groupBox1.Controls.Add(this.tbxAddTaskName);
            this.groupBox1.Controls.Add(this.lblAddTaskName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(310, 182);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // rbxAddTaskBody
            // 
            this.rbxAddTaskBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxAddTaskBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbxAddTaskBody.Location = new System.Drawing.Point(118, 80);
            this.rbxAddTaskBody.Name = "rbxAddTaskBody";
            this.rbxAddTaskBody.Size = new System.Drawing.Size(267, 96);
            this.rbxAddTaskBody.TabIndex = 6;
            this.rbxAddTaskBody.Text = "";
            // 
            // lblAddTaskBody
            // 
            this.lblAddTaskBody.AutoSize = true;
            this.lblAddTaskBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddTaskBody.Location = new System.Drawing.Point(6, 83);
            this.lblAddTaskBody.Name = "lblAddTaskBody";
            this.lblAddTaskBody.Size = new System.Drawing.Size(73, 16);
            this.lblAddTaskBody.TabIndex = 4;
            this.lblAddTaskBody.Text = "Task body";
            // 
            // tbxAddTaskSubject
            // 
            this.tbxAddTaskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddTaskSubject.Location = new System.Drawing.Point(118, 52);
            this.tbxAddTaskSubject.Name = "tbxAddTaskSubject";
            this.tbxAddTaskSubject.Size = new System.Drawing.Size(267, 22);
            this.tbxAddTaskSubject.TabIndex = 3;
            // 
            // lblAddTaskSubject
            // 
            this.lblAddTaskSubject.AutoSize = true;
            this.lblAddTaskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddTaskSubject.Location = new System.Drawing.Point(6, 55);
            this.lblAddTaskSubject.Name = "lblAddTaskSubject";
            this.lblAddTaskSubject.Size = new System.Drawing.Size(85, 16);
            this.lblAddTaskSubject.TabIndex = 2;
            this.lblAddTaskSubject.Text = "Task subject";
            // 
            // tbxAddTaskName
            // 
            this.tbxAddTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddTaskName.Location = new System.Drawing.Point(118, 24);
            this.tbxAddTaskName.Name = "tbxAddTaskName";
            this.tbxAddTaskName.Size = new System.Drawing.Size(267, 22);
            this.tbxAddTaskName.TabIndex = 1;
            // 
            // lblAddTaskName
            // 
            this.lblAddTaskName.AutoSize = true;
            this.lblAddTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddTaskName.Location = new System.Drawing.Point(6, 27);
            this.lblAddTaskName.Name = "lblAddTaskName";
            this.lblAddTaskName.Size = new System.Drawing.Size(76, 16);
            this.lblAddTaskName.TabIndex = 0;
            this.lblAddTaskName.Text = "Task name";
            // 
            // dgvTasksList
            // 
            this.dgvTasksList.AutoGenerateColumns = false;
            this.dgvTasksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskNameDataGridViewTextBoxColumn,
            this.taskSubjectDataGridViewTextBoxColumn,
            this.taskBodyDataGridViewTextBoxColumn,
            this.taskIdDataGridViewTextBoxColumn});
            this.dgvTasksList.DataSource = this.tasksBindingSource;
            this.dgvTasksList.Location = new System.Drawing.Point(8, 35);
            this.dgvTasksList.Name = "dgvTasksList";
            this.dgvTasksList.Size = new System.Drawing.Size(782, 160);
            this.dgvTasksList.TabIndex = 1;
            this.dgvTasksList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasksList_CellClick);
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Task name";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            // 
            // taskSubjectDataGridViewTextBoxColumn
            // 
            this.taskSubjectDataGridViewTextBoxColumn.DataPropertyName = "TaskSubject";
            this.taskSubjectDataGridViewTextBoxColumn.HeaderText = "Task subject";
            this.taskSubjectDataGridViewTextBoxColumn.Name = "taskSubjectDataGridViewTextBoxColumn";
            // 
            // taskBodyDataGridViewTextBoxColumn
            // 
            this.taskBodyDataGridViewTextBoxColumn.DataPropertyName = "TaskBody";
            this.taskBodyDataGridViewTextBoxColumn.HeaderText = "Task body";
            this.taskBodyDataGridViewTextBoxColumn.Name = "taskBodyDataGridViewTextBoxColumn";
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.educationProjectDataSet5;
            // 
            // educationProjectDataSet5
            // 
            this.educationProjectDataSet5.DataSetName = "EducationProjectDataSet5";
            this.educationProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTasks.Location = new System.Drawing.Point(9, 7);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(75, 25);
            this.lblTasks.TabIndex = 0;
            this.lblTasks.Text = "Tasks";
            // 
            // tabAssignTask
            // 
            this.tabAssignTask.Controls.Add(this.gbxTaskPoint);
            this.tabAssignTask.Controls.Add(this.gbxAssignedTasksToStudents);
            this.tabAssignTask.Controls.Add(this.gbxAssignTaskToStudents);
            this.tabAssignTask.Controls.Add(this.gbxAssignTaskToGroup);
            this.tabAssignTask.Location = new System.Drawing.Point(4, 22);
            this.tabAssignTask.Name = "tabAssignTask";
            this.tabAssignTask.Size = new System.Drawing.Size(796, 429);
            this.tabAssignTask.TabIndex = 2;
            this.tabAssignTask.Text = "Assign task";
            this.tabAssignTask.UseVisualStyleBackColor = true;
            // 
            // gbxAssignTaskToStudents
            // 
            this.gbxAssignTaskToStudents.Controls.Add(this.btnShowTeacherAllStudents);
            this.gbxAssignTaskToStudents.Controls.Add(this.lblAssignTaskToStidentsSelectEndDate);
            this.gbxAssignTaskToStudents.Controls.Add(this.chbxSelectStudent);
            this.gbxAssignTaskToStudents.Controls.Add(this.lblAssignTaskToStidentsSelectStartDate);
            this.gbxAssignTaskToStudents.Controls.Add(this.dtpAssignTaskToStudentsEndDate);
            this.gbxAssignTaskToStudents.Controls.Add(this.dtpAssignTaskToStudentsStartDate);
            this.gbxAssignTaskToStudents.Controls.Add(this.btnAssignTaskToStudents);
            this.gbxAssignTaskToStudents.Controls.Add(this.cbxAssignTaskToStudentsSelectTask);
            this.gbxAssignTaskToStudents.Controls.Add(this.lblAssignTaskToStidentsSelectTask);
            this.gbxAssignTaskToStudents.Controls.Add(this.cbxAssignTaskToStudentsSelectGroup);
            this.gbxAssignTaskToStudents.Controls.Add(this.lblAssignTaskToStidentsSelectGroup);
            this.gbxAssignTaskToStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAssignTaskToStudents.Location = new System.Drawing.Point(294, 3);
            this.gbxAssignTaskToStudents.Name = "gbxAssignTaskToStudents";
            this.gbxAssignTaskToStudents.Size = new System.Drawing.Size(490, 193);
            this.gbxAssignTaskToStudents.TabIndex = 9;
            this.gbxAssignTaskToStudents.TabStop = false;
            this.gbxAssignTaskToStudents.Text = "Assign task to students";
            // 
            // btnShowTeacherAllStudents
            // 
            this.btnShowTeacherAllStudents.AutoSize = true;
            this.btnShowTeacherAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowTeacherAllStudents.Location = new System.Drawing.Point(289, 34);
            this.btnShowTeacherAllStudents.Name = "btnShowTeacherAllStudents";
            this.btnShowTeacherAllStudents.Size = new System.Drawing.Size(195, 26);
            this.btnShowTeacherAllStudents.TabIndex = 9;
            this.btnShowTeacherAllStudents.Text = "Show my all students";
            this.btnShowTeacherAllStudents.UseVisualStyleBackColor = true;
            this.btnShowTeacherAllStudents.Click += new System.EventHandler(this.btnShowTeacherAllStudents_Click);
            // 
            // lblAssignTaskToStidentsSelectEndDate
            // 
            this.lblAssignTaskToStidentsSelectEndDate.AutoSize = true;
            this.lblAssignTaskToStidentsSelectEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAssignTaskToStidentsSelectEndDate.Location = new System.Drawing.Point(199, 129);
            this.lblAssignTaskToStidentsSelectEndDate.Name = "lblAssignTaskToStidentsSelectEndDate";
            this.lblAssignTaskToStidentsSelectEndDate.Size = new System.Drawing.Size(62, 16);
            this.lblAssignTaskToStidentsSelectEndDate.TabIndex = 8;
            this.lblAssignTaskToStidentsSelectEndDate.Text = "End date";
            // 
            // chbxSelectStudent
            // 
            this.chbxSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxSelectStudent.FormattingEnabled = true;
            this.chbxSelectStudent.Location = new System.Drawing.Point(9, 69);
            this.chbxSelectStudent.Name = "chbxSelectStudent";
            this.chbxSelectStudent.Size = new System.Drawing.Size(184, 106);
            this.chbxSelectStudent.TabIndex = 2;
            // 
            // lblAssignTaskToStidentsSelectStartDate
            // 
            this.lblAssignTaskToStidentsSelectStartDate.AutoSize = true;
            this.lblAssignTaskToStidentsSelectStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAssignTaskToStidentsSelectStartDate.Location = new System.Drawing.Point(199, 101);
            this.lblAssignTaskToStidentsSelectStartDate.Name = "lblAssignTaskToStidentsSelectStartDate";
            this.lblAssignTaskToStidentsSelectStartDate.Size = new System.Drawing.Size(65, 16);
            this.lblAssignTaskToStidentsSelectStartDate.TabIndex = 7;
            this.lblAssignTaskToStidentsSelectStartDate.Text = "Start date";
            // 
            // dtpAssignTaskToStudentsEndDate
            // 
            this.dtpAssignTaskToStudentsEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpAssignTaskToStudentsEndDate.Location = new System.Drawing.Point(289, 124);
            this.dtpAssignTaskToStudentsEndDate.Name = "dtpAssignTaskToStudentsEndDate";
            this.dtpAssignTaskToStudentsEndDate.Size = new System.Drawing.Size(195, 22);
            this.dtpAssignTaskToStudentsEndDate.TabIndex = 6;
            // 
            // dtpAssignTaskToStudentsStartDate
            // 
            this.dtpAssignTaskToStudentsStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpAssignTaskToStudentsStartDate.Location = new System.Drawing.Point(289, 96);
            this.dtpAssignTaskToStudentsStartDate.Name = "dtpAssignTaskToStudentsStartDate";
            this.dtpAssignTaskToStudentsStartDate.Size = new System.Drawing.Size(195, 22);
            this.dtpAssignTaskToStudentsStartDate.TabIndex = 5;
            // 
            // btnAssignTaskToStudents
            // 
            this.btnAssignTaskToStudents.AutoSize = true;
            this.btnAssignTaskToStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssignTaskToStudents.Location = new System.Drawing.Point(380, 152);
            this.btnAssignTaskToStudents.Name = "btnAssignTaskToStudents";
            this.btnAssignTaskToStudents.Size = new System.Drawing.Size(104, 26);
            this.btnAssignTaskToStudents.TabIndex = 4;
            this.btnAssignTaskToStudents.Text = "Assign task";
            this.btnAssignTaskToStudents.UseVisualStyleBackColor = true;
            this.btnAssignTaskToStudents.Click += new System.EventHandler(this.btnAssignTaskToStudents_Click);
            // 
            // cbxAssignTaskToStudentsSelectTask
            // 
            this.cbxAssignTaskToStudentsSelectTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxAssignTaskToStudentsSelectTask.FormattingEnabled = true;
            this.cbxAssignTaskToStudentsSelectTask.Location = new System.Drawing.Point(289, 66);
            this.cbxAssignTaskToStudentsSelectTask.Name = "cbxAssignTaskToStudentsSelectTask";
            this.cbxAssignTaskToStudentsSelectTask.Size = new System.Drawing.Size(195, 24);
            this.cbxAssignTaskToStudentsSelectTask.TabIndex = 3;
            // 
            // lblAssignTaskToStidentsSelectTask
            // 
            this.lblAssignTaskToStidentsSelectTask.AutoSize = true;
            this.lblAssignTaskToStidentsSelectTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAssignTaskToStidentsSelectTask.Location = new System.Drawing.Point(199, 69);
            this.lblAssignTaskToStidentsSelectTask.Name = "lblAssignTaskToStidentsSelectTask";
            this.lblAssignTaskToStidentsSelectTask.Size = new System.Drawing.Size(74, 16);
            this.lblAssignTaskToStidentsSelectTask.TabIndex = 2;
            this.lblAssignTaskToStidentsSelectTask.Text = "Select task";
            // 
            // cbxAssignTaskToStudentsSelectGroup
            // 
            this.cbxAssignTaskToStudentsSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxAssignTaskToStudentsSelectGroup.FormattingEnabled = true;
            this.cbxAssignTaskToStudentsSelectGroup.Location = new System.Drawing.Point(96, 36);
            this.cbxAssignTaskToStudentsSelectGroup.Name = "cbxAssignTaskToStudentsSelectGroup";
            this.cbxAssignTaskToStudentsSelectGroup.Size = new System.Drawing.Size(178, 24);
            this.cbxAssignTaskToStudentsSelectGroup.TabIndex = 1;
            this.cbxAssignTaskToStudentsSelectGroup.SelectedIndexChanged += new System.EventHandler(this.cbxAssignTaskToStudentsSelectGroup_SelectedIndexChanged);
            // 
            // lblAssignTaskToStidentsSelectGroup
            // 
            this.lblAssignTaskToStidentsSelectGroup.AutoSize = true;
            this.lblAssignTaskToStidentsSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAssignTaskToStidentsSelectGroup.Location = new System.Drawing.Point(6, 39);
            this.lblAssignTaskToStidentsSelectGroup.Name = "lblAssignTaskToStidentsSelectGroup";
            this.lblAssignTaskToStidentsSelectGroup.Size = new System.Drawing.Size(84, 16);
            this.lblAssignTaskToStidentsSelectGroup.TabIndex = 0;
            this.lblAssignTaskToStidentsSelectGroup.Text = "Select group";
            // 
            // gbxAssignTaskToGroup
            // 
            this.gbxAssignTaskToGroup.Controls.Add(this.lblTaskEndDate);
            this.gbxAssignTaskToGroup.Controls.Add(this.lblTaskStartDate);
            this.gbxAssignTaskToGroup.Controls.Add(this.dtpTaskEndDate);
            this.gbxAssignTaskToGroup.Controls.Add(this.dtpTaskStartDate);
            this.gbxAssignTaskToGroup.Controls.Add(this.btnAssginTask);
            this.gbxAssignTaskToGroup.Controls.Add(this.cbxSelectTask);
            this.gbxAssignTaskToGroup.Controls.Add(this.lblSelectTask);
            this.gbxAssignTaskToGroup.Controls.Add(this.cbxSelectGroup);
            this.gbxAssignTaskToGroup.Controls.Add(this.lblSelectGroup);
            this.gbxAssignTaskToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAssignTaskToGroup.Location = new System.Drawing.Point(8, 3);
            this.gbxAssignTaskToGroup.Name = "gbxAssignTaskToGroup";
            this.gbxAssignTaskToGroup.Size = new System.Drawing.Size(280, 193);
            this.gbxAssignTaskToGroup.TabIndex = 1;
            this.gbxAssignTaskToGroup.TabStop = false;
            this.gbxAssignTaskToGroup.Text = "Assign task to group";
            // 
            // lblTaskEndDate
            // 
            this.lblTaskEndDate.AutoSize = true;
            this.lblTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskEndDate.Location = new System.Drawing.Point(6, 129);
            this.lblTaskEndDate.Name = "lblTaskEndDate";
            this.lblTaskEndDate.Size = new System.Drawing.Size(62, 16);
            this.lblTaskEndDate.TabIndex = 8;
            this.lblTaskEndDate.Text = "End date";
            // 
            // lblTaskStartDate
            // 
            this.lblTaskStartDate.AutoSize = true;
            this.lblTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskStartDate.Location = new System.Drawing.Point(6, 101);
            this.lblTaskStartDate.Name = "lblTaskStartDate";
            this.lblTaskStartDate.Size = new System.Drawing.Size(65, 16);
            this.lblTaskStartDate.TabIndex = 7;
            this.lblTaskStartDate.Text = "Start date";
            // 
            // dtpTaskEndDate
            // 
            this.dtpTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTaskEndDate.Location = new System.Drawing.Point(96, 124);
            this.dtpTaskEndDate.Name = "dtpTaskEndDate";
            this.dtpTaskEndDate.Size = new System.Drawing.Size(178, 22);
            this.dtpTaskEndDate.TabIndex = 6;
            // 
            // dtpTaskStartDate
            // 
            this.dtpTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTaskStartDate.Location = new System.Drawing.Point(96, 96);
            this.dtpTaskStartDate.Name = "dtpTaskStartDate";
            this.dtpTaskStartDate.Size = new System.Drawing.Size(178, 22);
            this.dtpTaskStartDate.TabIndex = 5;
            // 
            // btnAssginTask
            // 
            this.btnAssginTask.AutoSize = true;
            this.btnAssginTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssginTask.Location = new System.Drawing.Point(187, 152);
            this.btnAssginTask.Name = "btnAssginTask";
            this.btnAssginTask.Size = new System.Drawing.Size(87, 26);
            this.btnAssginTask.TabIndex = 4;
            this.btnAssginTask.Text = "Assign task";
            this.btnAssginTask.UseVisualStyleBackColor = true;
            this.btnAssginTask.Click += new System.EventHandler(this.btnAssginTask_Click);
            // 
            // cbxSelectTask
            // 
            this.cbxSelectTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectTask.FormattingEnabled = true;
            this.cbxSelectTask.Location = new System.Drawing.Point(96, 66);
            this.cbxSelectTask.Name = "cbxSelectTask";
            this.cbxSelectTask.Size = new System.Drawing.Size(178, 24);
            this.cbxSelectTask.TabIndex = 3;
            // 
            // lblSelectTask
            // 
            this.lblSelectTask.AutoSize = true;
            this.lblSelectTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectTask.Location = new System.Drawing.Point(6, 69);
            this.lblSelectTask.Name = "lblSelectTask";
            this.lblSelectTask.Size = new System.Drawing.Size(74, 16);
            this.lblSelectTask.TabIndex = 2;
            this.lblSelectTask.Text = "Select task";
            // 
            // cbxSelectGroup
            // 
            this.cbxSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectGroup.FormattingEnabled = true;
            this.cbxSelectGroup.Location = new System.Drawing.Point(96, 36);
            this.cbxSelectGroup.Name = "cbxSelectGroup";
            this.cbxSelectGroup.Size = new System.Drawing.Size(178, 24);
            this.cbxSelectGroup.TabIndex = 1;
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectGroup.Location = new System.Drawing.Point(6, 39);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(84, 16);
            this.lblSelectGroup.TabIndex = 0;
            this.lblSelectGroup.Text = "Select group";
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.btnGoupsShowAllStudents);
            this.tabGroups.Controls.Add(this.tbxGroupsSearchByName);
            this.tabGroups.Controls.Add(this.lblGroupsSearchByName);
            this.tabGroups.Controls.Add(this.lblGroups);
            this.tabGroups.Controls.Add(this.dgvGroupsStudentsList);
            this.tabGroups.Controls.Add(this.gbxGroupsInfo);
            this.tabGroups.Controls.Add(this.cbxGroupsSelectGroup);
            this.tabGroups.Controls.Add(this.lblGroupsSelectGroup);
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(796, 429);
            this.tabGroups.TabIndex = 3;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // tabMentorInfo
            // 
            this.tabMentorInfo.Controls.Add(this.label2);
            this.tabMentorInfo.Controls.Add(this.richTextBox1);
            this.tabMentorInfo.Controls.Add(this.label1);
            this.tabMentorInfo.Controls.Add(this.label3);
            this.tabMentorInfo.Controls.Add(this.label4);
            this.tabMentorInfo.Controls.Add(this.label5);
            this.tabMentorInfo.Controls.Add(this.label6);
            this.tabMentorInfo.Controls.Add(this.label7);
            this.tabMentorInfo.Controls.Add(this.label8);
            this.tabMentorInfo.Controls.Add(this.label9);
            this.tabMentorInfo.Controls.Add(this.label10);
            this.tabMentorInfo.Controls.Add(this.pictureBox1);
            this.tabMentorInfo.Location = new System.Drawing.Point(4, 22);
            this.tabMentorInfo.Name = "tabMentorInfo";
            this.tabMentorInfo.Size = new System.Drawing.Size(796, 429);
            this.tabMentorInfo.TabIndex = 4;
            this.tabMentorInfo.Text = "Mentor info";
            this.tabMentorInfo.UseVisualStyleBackColor = true;
            // 
            // tabMessages
            // 
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Size = new System.Drawing.Size(796, 429);
            this.tabMessages.TabIndex = 5;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // tabWorkMates
            // 
            this.tabWorkMates.Location = new System.Drawing.Point(4, 22);
            this.tabWorkMates.Name = "tabWorkMates";
            this.tabWorkMates.Size = new System.Drawing.Size(796, 429);
            this.tabWorkMates.TabIndex = 6;
            this.tabWorkMates.Text = "Work mates";
            this.tabWorkMates.UseVisualStyleBackColor = true;
            // 
            // tabLibrary
            // 
            this.tabLibrary.Location = new System.Drawing.Point(4, 22);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Size = new System.Drawing.Size(796, 429);
            this.tabLibrary.TabIndex = 7;
            this.tabLibrary.Text = "Library";
            this.tabLibrary.UseVisualStyleBackColor = true;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter1
            // 
            this.groupsTableAdapter1.ClearBeforeFill = true;
            // 
            // gbxAssignedTasksToStudents
            // 
            this.gbxAssignedTasksToStudents.Controls.Add(this.lbxSelectedStudentFromAssignedTasks);
            this.gbxAssignedTasksToStudents.Controls.Add(this.cbxSelectSelectedAssignedTaskToStudents);
            this.gbxAssignedTasksToStudents.Controls.Add(this.lblSelectAssignedTaskToStudents);
            this.gbxAssignedTasksToStudents.Controls.Add(this.lblSelectedStudentsFromAssignedTasks);
            this.gbxAssignedTasksToStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAssignedTasksToStudents.Location = new System.Drawing.Point(8, 202);
            this.gbxAssignedTasksToStudents.Name = "gbxAssignedTasksToStudents";
            this.gbxAssignedTasksToStudents.Size = new System.Drawing.Size(319, 214);
            this.gbxAssignedTasksToStudents.TabIndex = 9;
            this.gbxAssignedTasksToStudents.TabStop = false;
            this.gbxAssignedTasksToStudents.Text = "Assigned tasks to students";
            // 
            // cbxSelectSelectedAssignedTaskToStudents
            // 
            this.cbxSelectSelectedAssignedTaskToStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectSelectedAssignedTaskToStudents.FormattingEnabled = true;
            this.cbxSelectSelectedAssignedTaskToStudents.Location = new System.Drawing.Point(96, 30);
            this.cbxSelectSelectedAssignedTaskToStudents.Name = "cbxSelectSelectedAssignedTaskToStudents";
            this.cbxSelectSelectedAssignedTaskToStudents.Size = new System.Drawing.Size(178, 24);
            this.cbxSelectSelectedAssignedTaskToStudents.TabIndex = 3;
            this.cbxSelectSelectedAssignedTaskToStudents.SelectedIndexChanged += new System.EventHandler(this.cbxSelectSelectedAssignedTaskToStudents_SelectedIndexChanged);
            // 
            // lblSelectAssignedTaskToStudents
            // 
            this.lblSelectAssignedTaskToStudents.AutoSize = true;
            this.lblSelectAssignedTaskToStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectAssignedTaskToStudents.Location = new System.Drawing.Point(6, 33);
            this.lblSelectAssignedTaskToStudents.Name = "lblSelectAssignedTaskToStudents";
            this.lblSelectAssignedTaskToStudents.Size = new System.Drawing.Size(74, 16);
            this.lblSelectAssignedTaskToStudents.TabIndex = 2;
            this.lblSelectAssignedTaskToStudents.Text = "Select task";
            // 
            // lblSelectedStudentsFromAssignedTasks
            // 
            this.lblSelectedStudentsFromAssignedTasks.AutoSize = true;
            this.lblSelectedStudentsFromAssignedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedStudentsFromAssignedTasks.Location = new System.Drawing.Point(6, 60);
            this.lblSelectedStudentsFromAssignedTasks.Name = "lblSelectedStudentsFromAssignedTasks";
            this.lblSelectedStudentsFromAssignedTasks.Size = new System.Drawing.Size(60, 16);
            this.lblSelectedStudentsFromAssignedTasks.TabIndex = 0;
            this.lblSelectedStudentsFromAssignedTasks.Text = "Students";
            // 
            // lbxSelectedStudentFromAssignedTasks
            // 
            this.lbxSelectedStudentFromAssignedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxSelectedStudentFromAssignedTasks.FormattingEnabled = true;
            this.lbxSelectedStudentFromAssignedTasks.ItemHeight = 16;
            this.lbxSelectedStudentFromAssignedTasks.Location = new System.Drawing.Point(96, 60);
            this.lbxSelectedStudentFromAssignedTasks.Name = "lbxSelectedStudentFromAssignedTasks";
            this.lbxSelectedStudentFromAssignedTasks.Size = new System.Drawing.Size(178, 116);
            this.lbxSelectedStudentFromAssignedTasks.TabIndex = 5;
            // 
            // gbxTaskPoint
            // 
            this.gbxTaskPoint.Controls.Add(this.btnAssignPoint);
            this.gbxTaskPoint.Controls.Add(this.tbxSelectedStudentPoint);
            this.gbxTaskPoint.Controls.Add(this.dtpSelectedStudentTaskEndDate);
            this.gbxTaskPoint.Controls.Add(this.dtpSelectedStudentTaskStartDate);
            this.gbxTaskPoint.Controls.Add(this.lblSelectedStudentTaskPoint);
            this.gbxTaskPoint.Controls.Add(this.lblSelectedStudentTaskEndDate);
            this.gbxTaskPoint.Controls.Add(this.lblSelectedStudentTaskStartDate);
            this.gbxTaskPoint.Controls.Add(this.cbxSelectStudentForPoint);
            this.gbxTaskPoint.Controls.Add(this.cbxSelectTaskPoint);
            this.gbxTaskPoint.Controls.Add(this.lblSelectTaskPoint);
            this.gbxTaskPoint.Controls.Add(this.lblSelectedStudentsForPoints);
            this.gbxTaskPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxTaskPoint.Location = new System.Drawing.Point(333, 202);
            this.gbxTaskPoint.Name = "gbxTaskPoint";
            this.gbxTaskPoint.Size = new System.Drawing.Size(451, 214);
            this.gbxTaskPoint.TabIndex = 10;
            this.gbxTaskPoint.TabStop = false;
            this.gbxTaskPoint.Text = "Points";
            // 
            // cbxSelectTaskPoint
            // 
            this.cbxSelectTaskPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectTaskPoint.FormattingEnabled = true;
            this.cbxSelectTaskPoint.Location = new System.Drawing.Point(86, 30);
            this.cbxSelectTaskPoint.Name = "cbxSelectTaskPoint";
            this.cbxSelectTaskPoint.Size = new System.Drawing.Size(148, 24);
            this.cbxSelectTaskPoint.TabIndex = 3;
            this.cbxSelectTaskPoint.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTaskPoint_SelectedIndexChanged);
            // 
            // lblSelectTaskPoint
            // 
            this.lblSelectTaskPoint.AutoSize = true;
            this.lblSelectTaskPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectTaskPoint.Location = new System.Drawing.Point(6, 33);
            this.lblSelectTaskPoint.Name = "lblSelectTaskPoint";
            this.lblSelectTaskPoint.Size = new System.Drawing.Size(74, 16);
            this.lblSelectTaskPoint.TabIndex = 2;
            this.lblSelectTaskPoint.Text = "Select task";
            // 
            // lblSelectedStudentsForPoints
            // 
            this.lblSelectedStudentsForPoints.AutoSize = true;
            this.lblSelectedStudentsForPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedStudentsForPoints.Location = new System.Drawing.Point(240, 33);
            this.lblSelectedStudentsForPoints.Name = "lblSelectedStudentsForPoints";
            this.lblSelectedStudentsForPoints.Size = new System.Drawing.Size(60, 16);
            this.lblSelectedStudentsForPoints.TabIndex = 0;
            this.lblSelectedStudentsForPoints.Text = "Students";
            // 
            // cbxSelectStudentForPoint
            // 
            this.cbxSelectStudentForPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectStudentForPoint.FormattingEnabled = true;
            this.cbxSelectStudentForPoint.Location = new System.Drawing.Point(306, 30);
            this.cbxSelectStudentForPoint.Name = "cbxSelectStudentForPoint";
            this.cbxSelectStudentForPoint.Size = new System.Drawing.Size(139, 24);
            this.cbxSelectStudentForPoint.TabIndex = 4;
            this.cbxSelectStudentForPoint.SelectedIndexChanged += new System.EventHandler(this.cbxSelectStudentForPoint_SelectedIndexChanged);
            // 
            // lblSelectedStudentTaskStartDate
            // 
            this.lblSelectedStudentTaskStartDate.AutoSize = true;
            this.lblSelectedStudentTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedStudentTaskStartDate.Location = new System.Drawing.Point(6, 71);
            this.lblSelectedStudentTaskStartDate.Name = "lblSelectedStudentTaskStartDate";
            this.lblSelectedStudentTaskStartDate.Size = new System.Drawing.Size(97, 16);
            this.lblSelectedStudentTaskStartDate.TabIndex = 5;
            this.lblSelectedStudentTaskStartDate.Text = "Task start date";
            // 
            // lblSelectedStudentTaskEndDate
            // 
            this.lblSelectedStudentTaskEndDate.AutoSize = true;
            this.lblSelectedStudentTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedStudentTaskEndDate.Location = new System.Drawing.Point(6, 99);
            this.lblSelectedStudentTaskEndDate.Name = "lblSelectedStudentTaskEndDate";
            this.lblSelectedStudentTaskEndDate.Size = new System.Drawing.Size(95, 16);
            this.lblSelectedStudentTaskEndDate.TabIndex = 6;
            this.lblSelectedStudentTaskEndDate.Text = "Task end date";
            // 
            // lblSelectedStudentTaskPoint
            // 
            this.lblSelectedStudentTaskPoint.AutoSize = true;
            this.lblSelectedStudentTaskPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedStudentTaskPoint.Location = new System.Drawing.Point(6, 125);
            this.lblSelectedStudentTaskPoint.Name = "lblSelectedStudentTaskPoint";
            this.lblSelectedStudentTaskPoint.Size = new System.Drawing.Size(71, 16);
            this.lblSelectedStudentTaskPoint.TabIndex = 7;
            this.lblSelectedStudentTaskPoint.Text = "Task point";
            // 
            // dtpSelectedStudentTaskEndDate
            // 
            this.dtpSelectedStudentTaskEndDate.Enabled = false;
            this.dtpSelectedStudentTaskEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpSelectedStudentTaskEndDate.Location = new System.Drawing.Point(109, 94);
            this.dtpSelectedStudentTaskEndDate.Name = "dtpSelectedStudentTaskEndDate";
            this.dtpSelectedStudentTaskEndDate.Size = new System.Drawing.Size(336, 22);
            this.dtpSelectedStudentTaskEndDate.TabIndex = 10;
            // 
            // dtpSelectedStudentTaskStartDate
            // 
            this.dtpSelectedStudentTaskStartDate.Enabled = false;
            this.dtpSelectedStudentTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpSelectedStudentTaskStartDate.Location = new System.Drawing.Point(109, 66);
            this.dtpSelectedStudentTaskStartDate.Name = "dtpSelectedStudentTaskStartDate";
            this.dtpSelectedStudentTaskStartDate.Size = new System.Drawing.Size(336, 22);
            this.dtpSelectedStudentTaskStartDate.TabIndex = 9;
            // 
            // tbxSelectedStudentPoint
            // 
            this.tbxSelectedStudentPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSelectedStudentPoint.Location = new System.Drawing.Point(109, 122);
            this.tbxSelectedStudentPoint.Name = "tbxSelectedStudentPoint";
            this.tbxSelectedStudentPoint.Size = new System.Drawing.Size(336, 22);
            this.tbxSelectedStudentPoint.TabIndex = 11;
            // 
            // btnAssignPoint
            // 
            this.btnAssignPoint.AutoSize = true;
            this.btnAssignPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssignPoint.Location = new System.Drawing.Point(341, 173);
            this.btnAssignPoint.Name = "btnAssignPoint";
            this.btnAssignPoint.Size = new System.Drawing.Size(104, 26);
            this.btnAssignPoint.TabIndex = 10;
            this.btnAssignPoint.Text = "Assign point";
            this.btnAssignPoint.UseVisualStyleBackColor = true;
            this.btnAssignPoint.Click += new System.EventHandler(this.btnAssignPoint_Click);
            // 
            // lblGroupsSelectGroup
            // 
            this.lblGroupsSelectGroup.AutoSize = true;
            this.lblGroupsSelectGroup.Location = new System.Drawing.Point(9, 57);
            this.lblGroupsSelectGroup.Name = "lblGroupsSelectGroup";
            this.lblGroupsSelectGroup.Size = new System.Drawing.Size(67, 13);
            this.lblGroupsSelectGroup.TabIndex = 0;
            this.lblGroupsSelectGroup.Text = "Select group";
            // 
            // cbxGroupsSelectGroup
            // 
            this.cbxGroupsSelectGroup.FormattingEnabled = true;
            this.cbxGroupsSelectGroup.Location = new System.Drawing.Point(129, 54);
            this.cbxGroupsSelectGroup.Name = "cbxGroupsSelectGroup";
            this.cbxGroupsSelectGroup.Size = new System.Drawing.Size(196, 21);
            this.cbxGroupsSelectGroup.TabIndex = 1;
            this.cbxGroupsSelectGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroupsSelectGroup_SelectedIndexChanged);
            // 
            // gbxGroupsInfo
            // 
            this.gbxGroupsInfo.Controls.Add(this.tbxGroupsInfoGroupTime);
            this.gbxGroupsInfo.Controls.Add(this.tbxGroupsInfoGroupMentor);
            this.gbxGroupsInfo.Controls.Add(this.lblGroupsInfoGroupMentor);
            this.gbxGroupsInfo.Controls.Add(this.lblGroupsInfoGroupTime);
            this.gbxGroupsInfo.Controls.Add(this.tbxGroupsInfoName);
            this.gbxGroupsInfo.Controls.Add(this.tbxGroupsInfoGroupType);
            this.gbxGroupsInfo.Controls.Add(this.lblGroupsInfoGroupType);
            this.gbxGroupsInfo.Controls.Add(this.lblGroupsInfoName);
            this.gbxGroupsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxGroupsInfo.Location = new System.Drawing.Point(365, 10);
            this.gbxGroupsInfo.Name = "gbxGroupsInfo";
            this.gbxGroupsInfo.Size = new System.Drawing.Size(419, 174);
            this.gbxGroupsInfo.TabIndex = 2;
            this.gbxGroupsInfo.TabStop = false;
            this.gbxGroupsInfo.Text = "Group info";
            // 
            // dgvGroupsStudentsList
            // 
            this.dgvGroupsStudentsList.AutoGenerateColumns = false;
            this.dgvGroupsStudentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroupsStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentSurname,
            this.StudentEmail,
            this.StudentPhone,
            this.StudentBirthDate,
            this.StudentRegistrationDate,
            this.StudentBio,
            this.Column1,
            this.groupIdDataGridViewTextBoxColumn});
            this.dgvGroupsStudentsList.DataSource = this.studentsBindingSource;
            this.dgvGroupsStudentsList.Location = new System.Drawing.Point(12, 193);
            this.dgvGroupsStudentsList.Name = "dgvGroupsStudentsList";
            this.dgvGroupsStudentsList.Size = new System.Drawing.Size(772, 223);
            this.dgvGroupsStudentsList.TabIndex = 3;
            // 
            // educationProjectDataSet3
            // 
            this.educationProjectDataSet3.DataSetName = "EducationProjectDataSet3";
            this.educationProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.educationProjectDataSet3;
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroups.Location = new System.Drawing.Point(3, 10);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(88, 25);
            this.lblGroups.TabIndex = 4;
            this.lblGroups.Text = "Groups";
            // 
            // lblGroupsSearchByName
            // 
            this.lblGroupsSearchByName.AutoSize = true;
            this.lblGroupsSearchByName.Location = new System.Drawing.Point(9, 95);
            this.lblGroupsSearchByName.Name = "lblGroupsSearchByName";
            this.lblGroupsSearchByName.Size = new System.Drawing.Size(114, 13);
            this.lblGroupsSearchByName.TabIndex = 5;
            this.lblGroupsSearchByName.Text = "Search group by name";
            // 
            // tbxGroupsSearchByName
            // 
            this.tbxGroupsSearchByName.Location = new System.Drawing.Point(129, 92);
            this.tbxGroupsSearchByName.Name = "tbxGroupsSearchByName";
            this.tbxGroupsSearchByName.Size = new System.Drawing.Size(196, 20);
            this.tbxGroupsSearchByName.TabIndex = 6;
            this.tbxGroupsSearchByName.TextChanged += new System.EventHandler(this.tbxGroupsSearchByName_TextChanged);
            // 
            // tbxGroupsInfoGroupType
            // 
            this.tbxGroupsInfoGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxGroupsInfoGroupType.Location = new System.Drawing.Point(93, 62);
            this.tbxGroupsInfoGroupType.Name = "tbxGroupsInfoGroupType";
            this.tbxGroupsInfoGroupType.ReadOnly = true;
            this.tbxGroupsInfoGroupType.Size = new System.Drawing.Size(320, 22);
            this.tbxGroupsInfoGroupType.TabIndex = 10;
            // 
            // lblGroupsInfoGroupType
            // 
            this.lblGroupsInfoGroupType.AutoSize = true;
            this.lblGroupsInfoGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupsInfoGroupType.Location = new System.Drawing.Point(6, 65);
            this.lblGroupsInfoGroupType.Name = "lblGroupsInfoGroupType";
            this.lblGroupsInfoGroupType.Size = new System.Drawing.Size(74, 16);
            this.lblGroupsInfoGroupType.TabIndex = 9;
            this.lblGroupsInfoGroupType.Text = "Group type";
            // 
            // lblGroupsInfoName
            // 
            this.lblGroupsInfoName.AutoSize = true;
            this.lblGroupsInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupsInfoName.Location = new System.Drawing.Point(6, 27);
            this.lblGroupsInfoName.Name = "lblGroupsInfoName";
            this.lblGroupsInfoName.Size = new System.Drawing.Size(45, 16);
            this.lblGroupsInfoName.TabIndex = 7;
            this.lblGroupsInfoName.Text = "Name";
            // 
            // tbxGroupsInfoName
            // 
            this.tbxGroupsInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxGroupsInfoName.Location = new System.Drawing.Point(93, 24);
            this.tbxGroupsInfoName.Name = "tbxGroupsInfoName";
            this.tbxGroupsInfoName.ReadOnly = true;
            this.tbxGroupsInfoName.Size = new System.Drawing.Size(320, 22);
            this.tbxGroupsInfoName.TabIndex = 11;
            // 
            // tbxGroupsInfoGroupTime
            // 
            this.tbxGroupsInfoGroupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxGroupsInfoGroupTime.Location = new System.Drawing.Point(93, 101);
            this.tbxGroupsInfoGroupTime.Name = "tbxGroupsInfoGroupTime";
            this.tbxGroupsInfoGroupTime.ReadOnly = true;
            this.tbxGroupsInfoGroupTime.Size = new System.Drawing.Size(320, 22);
            this.tbxGroupsInfoGroupTime.TabIndex = 15;
            // 
            // tbxGroupsInfoGroupMentor
            // 
            this.tbxGroupsInfoGroupMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxGroupsInfoGroupMentor.Location = new System.Drawing.Point(93, 139);
            this.tbxGroupsInfoGroupMentor.Name = "tbxGroupsInfoGroupMentor";
            this.tbxGroupsInfoGroupMentor.ReadOnly = true;
            this.tbxGroupsInfoGroupMentor.Size = new System.Drawing.Size(320, 22);
            this.tbxGroupsInfoGroupMentor.TabIndex = 14;
            // 
            // lblGroupsInfoGroupMentor
            // 
            this.lblGroupsInfoGroupMentor.AutoSize = true;
            this.lblGroupsInfoGroupMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupsInfoGroupMentor.Location = new System.Drawing.Point(6, 142);
            this.lblGroupsInfoGroupMentor.Name = "lblGroupsInfoGroupMentor";
            this.lblGroupsInfoGroupMentor.Size = new System.Drawing.Size(49, 16);
            this.lblGroupsInfoGroupMentor.TabIndex = 13;
            this.lblGroupsInfoGroupMentor.Text = "Mentor";
            // 
            // lblGroupsInfoGroupTime
            // 
            this.lblGroupsInfoGroupTime.AutoSize = true;
            this.lblGroupsInfoGroupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupsInfoGroupTime.Location = new System.Drawing.Point(6, 104);
            this.lblGroupsInfoGroupTime.Name = "lblGroupsInfoGroupTime";
            this.lblGroupsInfoGroupTime.Size = new System.Drawing.Size(73, 16);
            this.lblGroupsInfoGroupTime.TabIndex = 12;
            this.lblGroupsInfoGroupTime.Text = "Group time";
            // 
            // educationProjectDataSet1
            // 
            this.educationProjectDataSet1.DataSetName = "EducationProjectDataSet1";
            this.educationProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.educationProjectDataSet1;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Student name";
            this.StudentName.Name = "StudentName";
            // 
            // StudentSurname
            // 
            this.StudentSurname.DataPropertyName = "StudentSurname";
            this.StudentSurname.HeaderText = "Student surname";
            this.StudentSurname.Name = "StudentSurname";
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "StudentEmail";
            this.StudentEmail.HeaderText = "Student email";
            this.StudentEmail.Name = "StudentEmail";
            // 
            // StudentPhone
            // 
            this.StudentPhone.DataPropertyName = "StudentPhone";
            this.StudentPhone.HeaderText = "Student phone";
            this.StudentPhone.Name = "StudentPhone";
            // 
            // StudentBirthDate
            // 
            this.StudentBirthDate.DataPropertyName = "StudentBirthDate";
            this.StudentBirthDate.HeaderText = "Student birthdate";
            this.StudentBirthDate.Name = "StudentBirthDate";
            // 
            // StudentRegistrationDate
            // 
            this.StudentRegistrationDate.DataPropertyName = "StudentRegistrationDate";
            this.StudentRegistrationDate.HeaderText = "Student registration date";
            this.StudentRegistrationDate.Name = "StudentRegistrationDate";
            // 
            // StudentBio
            // 
            this.StudentBio.DataPropertyName = "StudentBio";
            this.StudentBio.HeaderText = "Student bio";
            this.StudentBio.Name = "StudentBio";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentId";
            this.Column1.HeaderText = "StudentId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnGoupsShowAllStudents
            // 
            this.btnGoupsShowAllStudents.AutoSize = true;
            this.btnGoupsShowAllStudents.Location = new System.Drawing.Point(12, 149);
            this.btnGoupsShowAllStudents.Name = "btnGoupsShowAllStudents";
            this.btnGoupsShowAllStudents.Size = new System.Drawing.Size(100, 23);
            this.btnGoupsShowAllStudents.TabIndex = 7;
            this.btnGoupsShowAllStudents.Text = "Show all students";
            this.btnGoupsShowAllStudents.UseVisualStyleBackColor = true;
            this.btnGoupsShowAllStudents.Click += new System.EventHandler(this.btnGoupsShowAllStudents_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(176, 296);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(257, 96);
            this.richTextBox1.TabIndex = 89;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Bio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Loading...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Loading...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Surname :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Loading...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(129, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 76;
            this.label10.Text = "Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Loading...";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTeacher);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.tabControlTeacher.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).EndInit();
            this.tabTask.ResumeLayout(false);
            this.tabTask.PerformLayout();
            this.gbxUpdateTask.ResumeLayout(false);
            this.gbxUpdateTask.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet5)).EndInit();
            this.tabAssignTask.ResumeLayout(false);
            this.gbxAssignTaskToStudents.ResumeLayout(false);
            this.gbxAssignTaskToStudents.PerformLayout();
            this.gbxAssignTaskToGroup.ResumeLayout(false);
            this.gbxAssignTaskToGroup.PerformLayout();
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            this.tabMentorInfo.ResumeLayout(false);
            this.tabMentorInfo.PerformLayout();
            this.gbxAssignedTasksToStudents.ResumeLayout(false);
            this.gbxAssignedTasksToStudents.PerformLayout();
            this.gbxTaskPoint.ResumeLayout(false);
            this.gbxTaskPoint.PerformLayout();
            this.gbxGroupsInfo.ResumeLayout(false);
            this.gbxGroupsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTeacher;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.TabPage tabAssignTask;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.TabPage tabMentorInfo;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabPage tabWorkMates;
        private System.Windows.Forms.TabPage tabLibrary;
        private System.Windows.Forms.Button btnTeacherSaveChangeBio;
        private System.Windows.Forms.RichTextBox rbxTeacherBio;
        private System.Windows.Forms.Label lblTeacherBio;
        private System.Windows.Forms.Button btnTeacherChangePhoto;
        private System.Windows.Forms.Button btnEditPhone;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Label lblTeacherPassword;
        private System.Windows.Forms.Label lblTeacherPhone;
        private System.Windows.Forms.Label lblTeacherEmailValue;
        private System.Windows.Forms.Label lblTeacherEmail;
        private System.Windows.Forms.Label lblTeacherSurnameValue;
        private System.Windows.Forms.Label lblTeacherSurname;
        private System.Windows.Forms.Label lblTeacherNameValue;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherInfo;
        private System.Windows.Forms.PictureBox pbxTeacherPhoto;
        private System.Windows.Forms.TextBox tbxTeacherPhoneValue;
        private System.Windows.Forms.TextBox tbxTeacherPasswordValue;
        private System.Windows.Forms.Button btnSaveChangePhone;
        private System.Windows.Forms.Button btnSaveChangePassword;
        private System.Windows.Forms.DataGridView dgvTasksList;
        private System.Windows.Forms.Label lblTasks;
        private EducationProjectDataSet5 educationProjectDataSet5;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private EducationProjectDataSet5TableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.RichTextBox rbxAddTaskBody;
        private System.Windows.Forms.Label lblAddTaskBody;
        private System.Windows.Forms.TextBox tbxAddTaskSubject;
        private System.Windows.Forms.Label lblAddTaskSubject;
        private System.Windows.Forms.TextBox tbxAddTaskName;
        private System.Windows.Forms.Label lblAddTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbxUpdateTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.RichTextBox rbxUpdateTaskBody;
        private System.Windows.Forms.Label label1lblUpdateTaskBody;
        private System.Windows.Forms.TextBox tbxUpdateTaskSubject;
        private System.Windows.Forms.Label lblUpdateTaskSubject;
        private System.Windows.Forms.TextBox tbxUpdateTaskName;
        private System.Windows.Forms.Label lblUpdateTaskName;
        private EducationProjectDataSet3TableAdapters.GroupsTableAdapter groupsTableAdapter1;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.GroupBox gbxAssignTaskToGroup;
        private System.Windows.Forms.Button btnAssginTask;
        private System.Windows.Forms.ComboBox cbxSelectTask;
        private System.Windows.Forms.Label lblSelectTask;
        private System.Windows.Forms.ComboBox cbxSelectGroup;
        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.Label lblTaskEndDate;
        private System.Windows.Forms.Label lblTaskStartDate;
        private System.Windows.Forms.DateTimePicker dtpTaskEndDate;
        private System.Windows.Forms.DateTimePicker dtpTaskStartDate;
        private System.Windows.Forms.CheckedListBox chbxSelectStudent;
        private System.Windows.Forms.GroupBox gbxAssignTaskToStudents;
        private System.Windows.Forms.Label lblAssignTaskToStidentsSelectEndDate;
        private System.Windows.Forms.Label lblAssignTaskToStidentsSelectStartDate;
        private System.Windows.Forms.DateTimePicker dtpAssignTaskToStudentsEndDate;
        private System.Windows.Forms.DateTimePicker dtpAssignTaskToStudentsStartDate;
        private System.Windows.Forms.Button btnAssignTaskToStudents;
        private System.Windows.Forms.ComboBox cbxAssignTaskToStudentsSelectTask;
        private System.Windows.Forms.Label lblAssignTaskToStidentsSelectTask;
        private System.Windows.Forms.ComboBox cbxAssignTaskToStudentsSelectGroup;
        private System.Windows.Forms.Label lblAssignTaskToStidentsSelectGroup;
        private System.Windows.Forms.Button btnShowTeacherAllStudents;
        private System.Windows.Forms.GroupBox gbxAssignedTasksToStudents;
        private System.Windows.Forms.ComboBox cbxSelectSelectedAssignedTaskToStudents;
        private System.Windows.Forms.Label lblSelectAssignedTaskToStudents;
        private System.Windows.Forms.Label lblSelectedStudentsFromAssignedTasks;
        private System.Windows.Forms.ListBox lbxSelectedStudentFromAssignedTasks;
        private System.Windows.Forms.GroupBox gbxTaskPoint;
        private System.Windows.Forms.ComboBox cbxSelectStudentForPoint;
        private System.Windows.Forms.ComboBox cbxSelectTaskPoint;
        private System.Windows.Forms.Label lblSelectTaskPoint;
        private System.Windows.Forms.Label lblSelectedStudentsForPoints;
        private System.Windows.Forms.Button btnAssignPoint;
        private System.Windows.Forms.TextBox tbxSelectedStudentPoint;
        private System.Windows.Forms.DateTimePicker dtpSelectedStudentTaskEndDate;
        private System.Windows.Forms.DateTimePicker dtpSelectedStudentTaskStartDate;
        private System.Windows.Forms.Label lblSelectedStudentTaskPoint;
        private System.Windows.Forms.Label lblSelectedStudentTaskEndDate;
        private System.Windows.Forms.Label lblSelectedStudentTaskStartDate;
        private System.Windows.Forms.TextBox tbxGroupsSearchByName;
        private System.Windows.Forms.Label lblGroupsSearchByName;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.DataGridView dgvGroupsStudentsList;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private EducationProjectDataSet3 educationProjectDataSet3;
        private System.Windows.Forms.GroupBox gbxGroupsInfo;
        private System.Windows.Forms.TextBox tbxGroupsInfoGroupTime;
        private System.Windows.Forms.TextBox tbxGroupsInfoGroupMentor;
        private System.Windows.Forms.Label lblGroupsInfoGroupMentor;
        private System.Windows.Forms.Label lblGroupsInfoGroupTime;
        private System.Windows.Forms.TextBox tbxGroupsInfoName;
        private System.Windows.Forms.TextBox tbxGroupsInfoGroupType;
        private System.Windows.Forms.Label lblGroupsInfoGroupType;
        private System.Windows.Forms.Label lblGroupsInfoName;
        private System.Windows.Forms.ComboBox cbxGroupsSelectGroup;
        private System.Windows.Forms.Label lblGroupsSelectGroup;
        private EducationProjectDataSet1 educationProjectDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EducationProjectDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentRegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentBio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGoupsShowAllStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}