namespace EducationProject.View
{
    partial class MentorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MentorForm));
            this.tabControlMentor = new System.Windows.Forms.TabControl();
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
            this.rbxUpdateTaskBody = new System.Windows.Forms.RichTextBox();
            this.label1lblUpdateTaskBody = new System.Windows.Forms.Label();
            this.tbxUpdateTaskSubject = new System.Windows.Forms.TextBox();
            this.lblUpdateTaskSubject = new System.Windows.Forms.Label();
            this.tbxUpdateTaskName = new System.Windows.Forms.TextBox();
            this.lblUpdateTaskName = new System.Windows.Forms.Label();
            this.dgvTasksList = new System.Windows.Forms.DataGridView();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet5 = new EducationProject.EducationProjectDataSet5();
            this.lblTasks = new System.Windows.Forms.Label();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.btnGoupsShowAllStudents = new System.Windows.Forms.Button();
            this.tbxGroupsSearchByName = new System.Windows.Forms.TextBox();
            this.lblGroupsSearchByName = new System.Windows.Forms.Label();
            this.lblGroups = new System.Windows.Forms.Label();
            this.dgvGroupsStudentsList = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet1 = new EducationProject.EducationProjectDataSet1();
            this.gbxGroupsInfo = new System.Windows.Forms.GroupBox();
            this.tbxGroupsInfoGroupTime = new System.Windows.Forms.TextBox();
            this.tbxGroupsInfoGroupMentor = new System.Windows.Forms.TextBox();
            this.lblGroupsInfoGroupMentor = new System.Windows.Forms.Label();
            this.lblGroupsInfoGroupTime = new System.Windows.Forms.Label();
            this.tbxGroupsInfoName = new System.Windows.Forms.TextBox();
            this.tbxGroupsInfoGroupType = new System.Windows.Forms.TextBox();
            this.lblGroupsInfoGroupType = new System.Windows.Forms.Label();
            this.lblGroupsInfoName = new System.Windows.Forms.Label();
            this.cbxGroupsSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblGroupsSelectGroup = new System.Windows.Forms.Label();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tabControllMessages = new System.Windows.Forms.TabControl();
            this.tabMessagesSendTo = new System.Windows.Forms.TabPage();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tbxMessageSubject = new System.Windows.Forms.TextBox();
            this.tbxMessageReceiver = new System.Windows.Forms.TextBox();
            this.rbxMessagesBody = new System.Windows.Forms.RichTextBox();
            this.lblMessagesBody = new System.Windows.Forms.Label();
            this.lblMessagesSubject = new System.Windows.Forms.Label();
            this.lblMessageReceiver = new System.Windows.Forms.Label();
            this.btnSendToStudents = new System.Windows.Forms.Button();
            this.btnSendToMentor = new System.Windows.Forms.Button();
            this.btnSendToTeacher = new System.Windows.Forms.Button();
            this.tabMessagesInbox = new System.Windows.Forms.TabPage();
            this.rbxMessageInboxBody = new System.Windows.Forms.RichTextBox();
            this.lblMessageInboxBody = new System.Windows.Forms.Label();
            this.lblMessageInboxSubjectValue = new System.Windows.Forms.Label();
            this.lblMessageInboxSubject = new System.Windows.Forms.Label();
            this.lblMessageInboxSenderValue = new System.Windows.Forms.Label();
            this.lblMessageInboxSender = new System.Windows.Forms.Label();
            this.dgvInbox = new System.Windows.Forms.DataGridView();
            this.senderEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageSendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet = new EducationProject.EducationProjectDataSet();
            this.tabMessagesSent = new System.Windows.Forms.TabPage();
            this.dgvMessagesSent = new System.Windows.Forms.DataGridView();
            this.receiverEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageSendTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageSubjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBodyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbxMessagesSent = new System.Windows.Forms.RichTextBox();
            this.lblMessagesSentBody = new System.Windows.Forms.Label();
            this.lblMessagesSentSubjectValue = new System.Windows.Forms.Label();
            this.lblMessagesSentSubject = new System.Windows.Forms.Label();
            this.lblMessagesSentReceiverValue = new System.Windows.Forms.Label();
            this.lblMessagesSentReceiver = new System.Windows.Forms.Label();
            this.tabWorkMates = new System.Windows.Forms.TabPage();
            this.cbxWorkMatesSelectMentor = new System.Windows.Forms.ComboBox();
            this.lblWorkMatesSelectMentor = new System.Windows.Forms.Label();
            this.lblWorkmatesMentors = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorPhoneValue = new System.Windows.Forms.Label();
            this.rbxWorkMatesMentorBioValue = new System.Windows.Forms.RichTextBox();
            this.lblWorkMatesMentorBio = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorPhone = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorEmailValue = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorEmail = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorSurnameValue = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorSurname = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorNameValue = new System.Windows.Forms.Label();
            this.lblWorkMatesMentorName = new System.Windows.Forms.Label();
            this.lblWorkmatesMentorInfo = new System.Windows.Forms.Label();
            this.pbxWorkMatesMentorPhoto = new System.Windows.Forms.PictureBox();
            this.cbxWorkmatesSelectTeacher = new System.Windows.Forms.ComboBox();
            this.lblWorkmatesSelectTeacher = new System.Windows.Forms.Label();
            this.lblWorkmatesTeachers = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherPhoneValue = new System.Windows.Forms.Label();
            this.rbxWorkmatesTeacherBioValue = new System.Windows.Forms.RichTextBox();
            this.lblWorkmatesTeacherBio = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherPhone = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherEmailValue = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherEmail = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherSurnameValue = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherSurname = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherNameValue = new System.Windows.Forms.Label();
            this.lblWorkmatesTeacherName = new System.Windows.Forms.Label();
            this.lblWorkmatesInfo = new System.Windows.Forms.Label();
            this.pbxWorkmatesTeacherPhoto = new System.Windows.Forms.PictureBox();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.tasksTableAdapter = new EducationProject.EducationProjectDataSet5TableAdapters.TasksTableAdapter();
            this.studentsTableAdapter = new EducationProject.EducationProjectDataSet1TableAdapters.StudentsTableAdapter();
            this.messagesTableAdapter = new EducationProject.EducationProjectDataSetTableAdapters.MessagesTableAdapter();
            this.tabControlMentor.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).BeginInit();
            this.tabTask.SuspendLayout();
            this.gbxUpdateTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet5)).BeginInit();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).BeginInit();
            this.gbxGroupsInfo.SuspendLayout();
            this.tabMessages.SuspendLayout();
            this.tabControllMessages.SuspendLayout();
            this.tabMessagesSendTo.SuspendLayout();
            this.tabMessagesInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet)).BeginInit();
            this.tabMessagesSent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessagesSent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSetBindingSource)).BeginInit();
            this.tabWorkMates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorkMatesMentorPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorkmatesTeacherPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMentor
            // 
            this.tabControlMentor.Controls.Add(this.tabInfo);
            this.tabControlMentor.Controls.Add(this.tabTask);
            this.tabControlMentor.Controls.Add(this.tabGroups);
            this.tabControlMentor.Controls.Add(this.tabMessages);
            this.tabControlMentor.Controls.Add(this.tabWorkMates);
            this.tabControlMentor.Controls.Add(this.tabLibrary);
            this.tabControlMentor.Location = new System.Drawing.Point(-2, -2);
            this.tabControlMentor.Name = "tabControlMentor";
            this.tabControlMentor.SelectedIndex = 0;
            this.tabControlMentor.Size = new System.Drawing.Size(804, 455);
            this.tabControlMentor.TabIndex = 1;
            this.tabControlMentor.SelectedIndexChanged += new System.EventHandler(this.tabControlTeacher_SelectedIndexChanged);
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
            this.gbxUpdateTask.Controls.Add(this.rbxUpdateTaskBody);
            this.gbxUpdateTask.Controls.Add(this.label1lblUpdateTaskBody);
            this.gbxUpdateTask.Controls.Add(this.tbxUpdateTaskSubject);
            this.gbxUpdateTask.Controls.Add(this.lblUpdateTaskSubject);
            this.gbxUpdateTask.Controls.Add(this.tbxUpdateTaskName);
            this.gbxUpdateTask.Controls.Add(this.lblUpdateTaskName);
            this.gbxUpdateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdateTask.Location = new System.Drawing.Point(14, 204);
            this.gbxUpdateTask.Name = "gbxUpdateTask";
            this.gbxUpdateTask.Size = new System.Drawing.Size(378, 214);
            this.gbxUpdateTask.TabIndex = 8;
            this.gbxUpdateTask.TabStop = false;
            this.gbxUpdateTask.Text = "Selected task";
            // 
            // rbxUpdateTaskBody
            // 
            this.rbxUpdateTaskBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxUpdateTaskBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbxUpdateTaskBody.Location = new System.Drawing.Point(118, 98);
            this.rbxUpdateTaskBody.Name = "rbxUpdateTaskBody";
            this.rbxUpdateTaskBody.ReadOnly = true;
            this.rbxUpdateTaskBody.Size = new System.Drawing.Size(254, 96);
            this.rbxUpdateTaskBody.TabIndex = 6;
            this.rbxUpdateTaskBody.Text = "";
            // 
            // label1lblUpdateTaskBody
            // 
            this.label1lblUpdateTaskBody.AutoSize = true;
            this.label1lblUpdateTaskBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1lblUpdateTaskBody.Location = new System.Drawing.Point(6, 101);
            this.label1lblUpdateTaskBody.Name = "label1lblUpdateTaskBody";
            this.label1lblUpdateTaskBody.Size = new System.Drawing.Size(73, 16);
            this.label1lblUpdateTaskBody.TabIndex = 4;
            this.label1lblUpdateTaskBody.Text = "Task body";
            // 
            // tbxUpdateTaskSubject
            // 
            this.tbxUpdateTaskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTaskSubject.Location = new System.Drawing.Point(118, 70);
            this.tbxUpdateTaskSubject.Name = "tbxUpdateTaskSubject";
            this.tbxUpdateTaskSubject.ReadOnly = true;
            this.tbxUpdateTaskSubject.Size = new System.Drawing.Size(254, 22);
            this.tbxUpdateTaskSubject.TabIndex = 3;
            // 
            // lblUpdateTaskSubject
            // 
            this.lblUpdateTaskSubject.AutoSize = true;
            this.lblUpdateTaskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTaskSubject.Location = new System.Drawing.Point(6, 73);
            this.lblUpdateTaskSubject.Name = "lblUpdateTaskSubject";
            this.lblUpdateTaskSubject.Size = new System.Drawing.Size(85, 16);
            this.lblUpdateTaskSubject.TabIndex = 2;
            this.lblUpdateTaskSubject.Text = "Task subject";
            // 
            // tbxUpdateTaskName
            // 
            this.tbxUpdateTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTaskName.Location = new System.Drawing.Point(118, 42);
            this.tbxUpdateTaskName.Name = "tbxUpdateTaskName";
            this.tbxUpdateTaskName.ReadOnly = true;
            this.tbxUpdateTaskName.Size = new System.Drawing.Size(254, 22);
            this.tbxUpdateTaskName.TabIndex = 1;
            // 
            // lblUpdateTaskName
            // 
            this.lblUpdateTaskName.AutoSize = true;
            this.lblUpdateTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTaskName.Location = new System.Drawing.Point(6, 45);
            this.lblUpdateTaskName.Name = "lblUpdateTaskName";
            this.lblUpdateTaskName.Size = new System.Drawing.Size(76, 16);
            this.lblUpdateTaskName.TabIndex = 0;
            this.lblUpdateTaskName.Text = "Task name";
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
            // tbxGroupsSearchByName
            // 
            this.tbxGroupsSearchByName.Location = new System.Drawing.Point(129, 92);
            this.tbxGroupsSearchByName.Name = "tbxGroupsSearchByName";
            this.tbxGroupsSearchByName.Size = new System.Drawing.Size(196, 20);
            this.tbxGroupsSearchByName.TabIndex = 6;
            this.tbxGroupsSearchByName.TextChanged += new System.EventHandler(this.tbxGroupsSearchByName_TextChanged);
            // 
            // lblGroupsSearchByName
            // 
            this.lblGroupsSearchByName.AutoSize = true;
            this.lblGroupsSearchByName.Location = new System.Drawing.Point(9, 95);
            this.lblGroupsSearchByName.Name = "lblGroupsSearchByName";
            this.lblGroupsSearchByName.Size = new System.Drawing.Size(122, 13);
            this.lblGroupsSearchByName.TabIndex = 5;
            this.lblGroupsSearchByName.Text = "Search student by name";
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
            this.groupIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dgvGroupsStudentsList.DataSource = this.studentsBindingSource;
            this.dgvGroupsStudentsList.Location = new System.Drawing.Point(12, 193);
            this.dgvGroupsStudentsList.Name = "dgvGroupsStudentsList";
            this.dgvGroupsStudentsList.Size = new System.Drawing.Size(772, 223);
            this.dgvGroupsStudentsList.TabIndex = 3;
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
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.educationProjectDataSet1;
            // 
            // educationProjectDataSet1
            // 
            this.educationProjectDataSet1.DataSetName = "EducationProjectDataSet1";
            this.educationProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lblGroupsInfoGroupMentor.Size = new System.Drawing.Size(59, 16);
            this.lblGroupsInfoGroupMentor.TabIndex = 13;
            this.lblGroupsInfoGroupMentor.Text = "Teacher";
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
            // tbxGroupsInfoName
            // 
            this.tbxGroupsInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxGroupsInfoName.Location = new System.Drawing.Point(93, 24);
            this.tbxGroupsInfoName.Name = "tbxGroupsInfoName";
            this.tbxGroupsInfoName.ReadOnly = true;
            this.tbxGroupsInfoName.Size = new System.Drawing.Size(320, 22);
            this.tbxGroupsInfoName.TabIndex = 11;
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
            // cbxGroupsSelectGroup
            // 
            this.cbxGroupsSelectGroup.FormattingEnabled = true;
            this.cbxGroupsSelectGroup.Location = new System.Drawing.Point(129, 54);
            this.cbxGroupsSelectGroup.Name = "cbxGroupsSelectGroup";
            this.cbxGroupsSelectGroup.Size = new System.Drawing.Size(196, 21);
            this.cbxGroupsSelectGroup.TabIndex = 1;
            this.cbxGroupsSelectGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroupsSelectGroup_SelectedIndexChanged);
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
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.tabControllMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Size = new System.Drawing.Size(796, 429);
            this.tabMessages.TabIndex = 5;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // tabControllMessages
            // 
            this.tabControllMessages.Controls.Add(this.tabMessagesSendTo);
            this.tabControllMessages.Controls.Add(this.tabMessagesInbox);
            this.tabControllMessages.Controls.Add(this.tabMessagesSent);
            this.tabControllMessages.Location = new System.Drawing.Point(-2, 0);
            this.tabControllMessages.Name = "tabControllMessages";
            this.tabControllMessages.SelectedIndex = 0;
            this.tabControllMessages.Size = new System.Drawing.Size(801, 428);
            this.tabControllMessages.TabIndex = 1;
            // 
            // tabMessagesSendTo
            // 
            this.tabMessagesSendTo.Controls.Add(this.btnSendMessage);
            this.tabMessagesSendTo.Controls.Add(this.tbxMessageSubject);
            this.tabMessagesSendTo.Controls.Add(this.tbxMessageReceiver);
            this.tabMessagesSendTo.Controls.Add(this.rbxMessagesBody);
            this.tabMessagesSendTo.Controls.Add(this.lblMessagesBody);
            this.tabMessagesSendTo.Controls.Add(this.lblMessagesSubject);
            this.tabMessagesSendTo.Controls.Add(this.lblMessageReceiver);
            this.tabMessagesSendTo.Controls.Add(this.btnSendToStudents);
            this.tabMessagesSendTo.Controls.Add(this.btnSendToMentor);
            this.tabMessagesSendTo.Controls.Add(this.btnSendToTeacher);
            this.tabMessagesSendTo.Location = new System.Drawing.Point(4, 22);
            this.tabMessagesSendTo.Name = "tabMessagesSendTo";
            this.tabMessagesSendTo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessagesSendTo.Size = new System.Drawing.Size(793, 402);
            this.tabMessagesSendTo.TabIndex = 0;
            this.tabMessagesSendTo.Text = "Send to...";
            this.tabMessagesSendTo.UseVisualStyleBackColor = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.AutoSize = true;
            this.btnSendMessage.Location = new System.Drawing.Point(606, 335);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(87, 23);
            this.btnSendMessage.TabIndex = 11;
            this.btnSendMessage.Text = "Send message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tbxMessageSubject
            // 
            this.tbxMessageSubject.Location = new System.Drawing.Point(257, 54);
            this.tbxMessageSubject.Name = "tbxMessageSubject";
            this.tbxMessageSubject.Size = new System.Drawing.Size(436, 20);
            this.tbxMessageSubject.TabIndex = 9;
            // 
            // tbxMessageReceiver
            // 
            this.tbxMessageReceiver.Location = new System.Drawing.Point(257, 25);
            this.tbxMessageReceiver.Name = "tbxMessageReceiver";
            this.tbxMessageReceiver.Size = new System.Drawing.Size(436, 20);
            this.tbxMessageReceiver.TabIndex = 8;
            // 
            // rbxMessagesBody
            // 
            this.rbxMessagesBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxMessagesBody.Location = new System.Drawing.Point(175, 118);
            this.rbxMessagesBody.Name = "rbxMessagesBody";
            this.rbxMessagesBody.Size = new System.Drawing.Size(518, 211);
            this.rbxMessagesBody.TabIndex = 10;
            this.rbxMessagesBody.Text = "";
            // 
            // lblMessagesBody
            // 
            this.lblMessagesBody.AutoSize = true;
            this.lblMessagesBody.Location = new System.Drawing.Point(172, 91);
            this.lblMessagesBody.Name = "lblMessagesBody";
            this.lblMessagesBody.Size = new System.Drawing.Size(44, 13);
            this.lblMessagesBody.TabIndex = 5;
            this.lblMessagesBody.Text = "* Body :";
            // 
            // lblMessagesSubject
            // 
            this.lblMessagesSubject.AutoSize = true;
            this.lblMessagesSubject.Location = new System.Drawing.Point(172, 57);
            this.lblMessagesSubject.Name = "lblMessagesSubject";
            this.lblMessagesSubject.Size = new System.Drawing.Size(49, 13);
            this.lblMessagesSubject.TabIndex = 4;
            this.lblMessagesSubject.Text = "Subject :";
            // 
            // lblMessageReceiver
            // 
            this.lblMessageReceiver.AutoSize = true;
            this.lblMessageReceiver.Location = new System.Drawing.Point(172, 32);
            this.lblMessageReceiver.Name = "lblMessageReceiver";
            this.lblMessageReceiver.Size = new System.Drawing.Size(63, 13);
            this.lblMessageReceiver.TabIndex = 3;
            this.lblMessageReceiver.Text = "* Receiver :";
            // 
            // btnSendToStudents
            // 
            this.btnSendToStudents.AutoSize = true;
            this.btnSendToStudents.Location = new System.Drawing.Point(9, 86);
            this.btnSendToStudents.Name = "btnSendToStudents";
            this.btnSendToStudents.Size = new System.Drawing.Size(91, 23);
            this.btnSendToStudents.TabIndex = 2;
            this.btnSendToStudents.Text = "To students";
            this.btnSendToStudents.UseVisualStyleBackColor = true;
            this.btnSendToStudents.Click += new System.EventHandler(this.btnSendToStudents_Click);
            // 
            // btnSendToMentor
            // 
            this.btnSendToMentor.AutoSize = true;
            this.btnSendToMentor.Location = new System.Drawing.Point(9, 57);
            this.btnSendToMentor.Name = "btnSendToMentor";
            this.btnSendToMentor.Size = new System.Drawing.Size(75, 23);
            this.btnSendToMentor.TabIndex = 1;
            this.btnSendToMentor.Text = "To mentor";
            this.btnSendToMentor.UseVisualStyleBackColor = true;
            this.btnSendToMentor.Click += new System.EventHandler(this.btnSendToMentor_Click);
            // 
            // btnSendToTeacher
            // 
            this.btnSendToTeacher.AutoSize = true;
            this.btnSendToTeacher.Location = new System.Drawing.Point(9, 28);
            this.btnSendToTeacher.Name = "btnSendToTeacher";
            this.btnSendToTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnSendToTeacher.TabIndex = 0;
            this.btnSendToTeacher.Text = "To teacher";
            this.btnSendToTeacher.UseVisualStyleBackColor = true;
            this.btnSendToTeacher.Click += new System.EventHandler(this.btnSendToTeacher_Click);
            // 
            // tabMessagesInbox
            // 
            this.tabMessagesInbox.Controls.Add(this.rbxMessageInboxBody);
            this.tabMessagesInbox.Controls.Add(this.lblMessageInboxBody);
            this.tabMessagesInbox.Controls.Add(this.lblMessageInboxSubjectValue);
            this.tabMessagesInbox.Controls.Add(this.lblMessageInboxSubject);
            this.tabMessagesInbox.Controls.Add(this.lblMessageInboxSenderValue);
            this.tabMessagesInbox.Controls.Add(this.lblMessageInboxSender);
            this.tabMessagesInbox.Controls.Add(this.dgvInbox);
            this.tabMessagesInbox.Location = new System.Drawing.Point(4, 22);
            this.tabMessagesInbox.Name = "tabMessagesInbox";
            this.tabMessagesInbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessagesInbox.Size = new System.Drawing.Size(793, 402);
            this.tabMessagesInbox.TabIndex = 1;
            this.tabMessagesInbox.Text = "Inbox";
            this.tabMessagesInbox.UseVisualStyleBackColor = true;
            // 
            // rbxMessageInboxBody
            // 
            this.rbxMessageInboxBody.Location = new System.Drawing.Point(55, 258);
            this.rbxMessageInboxBody.Name = "rbxMessageInboxBody";
            this.rbxMessageInboxBody.ReadOnly = true;
            this.rbxMessageInboxBody.Size = new System.Drawing.Size(729, 133);
            this.rbxMessageInboxBody.TabIndex = 6;
            this.rbxMessageInboxBody.Text = "";
            // 
            // lblMessageInboxBody
            // 
            this.lblMessageInboxBody.AutoSize = true;
            this.lblMessageInboxBody.Location = new System.Drawing.Point(12, 261);
            this.lblMessageInboxBody.Name = "lblMessageInboxBody";
            this.lblMessageInboxBody.Size = new System.Drawing.Size(37, 13);
            this.lblMessageInboxBody.TabIndex = 5;
            this.lblMessageInboxBody.Text = "Body :";
            // 
            // lblMessageInboxSubjectValue
            // 
            this.lblMessageInboxSubjectValue.AutoSize = true;
            this.lblMessageInboxSubjectValue.Location = new System.Drawing.Point(62, 235);
            this.lblMessageInboxSubjectValue.Name = "lblMessageInboxSubjectValue";
            this.lblMessageInboxSubjectValue.Size = new System.Drawing.Size(54, 13);
            this.lblMessageInboxSubjectValue.TabIndex = 4;
            this.lblMessageInboxSubjectValue.Text = "Loading...";
            // 
            // lblMessageInboxSubject
            // 
            this.lblMessageInboxSubject.AutoSize = true;
            this.lblMessageInboxSubject.Location = new System.Drawing.Point(9, 235);
            this.lblMessageInboxSubject.Name = "lblMessageInboxSubject";
            this.lblMessageInboxSubject.Size = new System.Drawing.Size(49, 13);
            this.lblMessageInboxSubject.TabIndex = 3;
            this.lblMessageInboxSubject.Text = "Subject :";
            // 
            // lblMessageInboxSenderValue
            // 
            this.lblMessageInboxSenderValue.AutoSize = true;
            this.lblMessageInboxSenderValue.Location = new System.Drawing.Point(62, 211);
            this.lblMessageInboxSenderValue.Name = "lblMessageInboxSenderValue";
            this.lblMessageInboxSenderValue.Size = new System.Drawing.Size(54, 13);
            this.lblMessageInboxSenderValue.TabIndex = 2;
            this.lblMessageInboxSenderValue.Text = "Loading...";
            // 
            // lblMessageInboxSender
            // 
            this.lblMessageInboxSender.AutoSize = true;
            this.lblMessageInboxSender.Location = new System.Drawing.Point(9, 211);
            this.lblMessageInboxSender.Name = "lblMessageInboxSender";
            this.lblMessageInboxSender.Size = new System.Drawing.Size(47, 13);
            this.lblMessageInboxSender.TabIndex = 1;
            this.lblMessageInboxSender.Text = "Sender :";
            // 
            // dgvInbox
            // 
            this.dgvInbox.AllowUserToOrderColumns = true;
            this.dgvInbox.AutoGenerateColumns = false;
            this.dgvInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.senderEmailDataGridViewTextBoxColumn,
            this.messageSendTimeDataGridViewTextBoxColumn,
            this.messageSubjectDataGridViewTextBoxColumn,
            this.messageBodyDataGridViewTextBoxColumn,
            this.receiverEmailDataGridViewTextBoxColumn,
            this.messageIdDataGridViewTextBoxColumn});
            this.dgvInbox.DataSource = this.messagesBindingSource;
            this.dgvInbox.Location = new System.Drawing.Point(4, 7);
            this.dgvInbox.Name = "dgvInbox";
            this.dgvInbox.Size = new System.Drawing.Size(780, 187);
            this.dgvInbox.TabIndex = 0;
            this.dgvInbox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInbox_CellClick);
            // 
            // senderEmailDataGridViewTextBoxColumn
            // 
            this.senderEmailDataGridViewTextBoxColumn.DataPropertyName = "SenderEmail";
            this.senderEmailDataGridViewTextBoxColumn.HeaderText = "Sender email";
            this.senderEmailDataGridViewTextBoxColumn.Name = "senderEmailDataGridViewTextBoxColumn";
            // 
            // messageSendTimeDataGridViewTextBoxColumn
            // 
            this.messageSendTimeDataGridViewTextBoxColumn.DataPropertyName = "MessageSendTime";
            this.messageSendTimeDataGridViewTextBoxColumn.HeaderText = "Message send time";
            this.messageSendTimeDataGridViewTextBoxColumn.Name = "messageSendTimeDataGridViewTextBoxColumn";
            // 
            // messageSubjectDataGridViewTextBoxColumn
            // 
            this.messageSubjectDataGridViewTextBoxColumn.DataPropertyName = "MessageSubject";
            this.messageSubjectDataGridViewTextBoxColumn.HeaderText = "Message subject";
            this.messageSubjectDataGridViewTextBoxColumn.Name = "messageSubjectDataGridViewTextBoxColumn";
            // 
            // messageBodyDataGridViewTextBoxColumn
            // 
            this.messageBodyDataGridViewTextBoxColumn.DataPropertyName = "MessageBody";
            this.messageBodyDataGridViewTextBoxColumn.HeaderText = "Message body";
            this.messageBodyDataGridViewTextBoxColumn.Name = "messageBodyDataGridViewTextBoxColumn";
            // 
            // receiverEmailDataGridViewTextBoxColumn
            // 
            this.receiverEmailDataGridViewTextBoxColumn.DataPropertyName = "ReceiverEmail";
            this.receiverEmailDataGridViewTextBoxColumn.HeaderText = "ReceiverEmail";
            this.receiverEmailDataGridViewTextBoxColumn.Name = "receiverEmailDataGridViewTextBoxColumn";
            this.receiverEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // messageIdDataGridViewTextBoxColumn
            // 
            this.messageIdDataGridViewTextBoxColumn.DataPropertyName = "MessageId";
            this.messageIdDataGridViewTextBoxColumn.HeaderText = "MessageId";
            this.messageIdDataGridViewTextBoxColumn.Name = "messageIdDataGridViewTextBoxColumn";
            this.messageIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "Messages";
            this.messagesBindingSource.DataSource = this.educationProjectDataSet;
            // 
            // educationProjectDataSet
            // 
            this.educationProjectDataSet.DataSetName = "EducationProjectDataSet";
            this.educationProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabMessagesSent
            // 
            this.tabMessagesSent.Controls.Add(this.dgvMessagesSent);
            this.tabMessagesSent.Controls.Add(this.rbxMessagesSent);
            this.tabMessagesSent.Controls.Add(this.lblMessagesSentBody);
            this.tabMessagesSent.Controls.Add(this.lblMessagesSentSubjectValue);
            this.tabMessagesSent.Controls.Add(this.lblMessagesSentSubject);
            this.tabMessagesSent.Controls.Add(this.lblMessagesSentReceiverValue);
            this.tabMessagesSent.Controls.Add(this.lblMessagesSentReceiver);
            this.tabMessagesSent.Location = new System.Drawing.Point(4, 22);
            this.tabMessagesSent.Name = "tabMessagesSent";
            this.tabMessagesSent.Size = new System.Drawing.Size(793, 402);
            this.tabMessagesSent.TabIndex = 2;
            this.tabMessagesSent.Text = "Sent";
            this.tabMessagesSent.UseVisualStyleBackColor = true;
            // 
            // dgvMessagesSent
            // 
            this.dgvMessagesSent.AutoGenerateColumns = false;
            this.dgvMessagesSent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessagesSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessagesSent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiverEmailDataGridViewTextBoxColumn1,
            this.messageSendTimeDataGridViewTextBoxColumn1,
            this.messageSubjectDataGridViewTextBoxColumn1,
            this.messageBodyDataGridViewTextBoxColumn1,
            this.senderEmailDataGridViewTextBoxColumn1,
            this.messageIdDataGridViewTextBoxColumn1});
            this.dgvMessagesSent.DataSource = this.messagesBindingSource1;
            this.dgvMessagesSent.Location = new System.Drawing.Point(9, 4);
            this.dgvMessagesSent.Name = "dgvMessagesSent";
            this.dgvMessagesSent.Size = new System.Drawing.Size(775, 189);
            this.dgvMessagesSent.TabIndex = 14;
            this.dgvMessagesSent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessagesSent_CellClick);
            // 
            // receiverEmailDataGridViewTextBoxColumn1
            // 
            this.receiverEmailDataGridViewTextBoxColumn1.DataPropertyName = "ReceiverEmail";
            this.receiverEmailDataGridViewTextBoxColumn1.HeaderText = "Receiver email";
            this.receiverEmailDataGridViewTextBoxColumn1.Name = "receiverEmailDataGridViewTextBoxColumn1";
            // 
            // messageSendTimeDataGridViewTextBoxColumn1
            // 
            this.messageSendTimeDataGridViewTextBoxColumn1.DataPropertyName = "MessageSendTime";
            this.messageSendTimeDataGridViewTextBoxColumn1.HeaderText = "Message send time";
            this.messageSendTimeDataGridViewTextBoxColumn1.Name = "messageSendTimeDataGridViewTextBoxColumn1";
            // 
            // messageSubjectDataGridViewTextBoxColumn1
            // 
            this.messageSubjectDataGridViewTextBoxColumn1.DataPropertyName = "MessageSubject";
            this.messageSubjectDataGridViewTextBoxColumn1.HeaderText = "Message subject";
            this.messageSubjectDataGridViewTextBoxColumn1.Name = "messageSubjectDataGridViewTextBoxColumn1";
            // 
            // messageBodyDataGridViewTextBoxColumn1
            // 
            this.messageBodyDataGridViewTextBoxColumn1.DataPropertyName = "MessageBody";
            this.messageBodyDataGridViewTextBoxColumn1.HeaderText = "Message body";
            this.messageBodyDataGridViewTextBoxColumn1.Name = "messageBodyDataGridViewTextBoxColumn1";
            // 
            // senderEmailDataGridViewTextBoxColumn1
            // 
            this.senderEmailDataGridViewTextBoxColumn1.DataPropertyName = "SenderEmail";
            this.senderEmailDataGridViewTextBoxColumn1.HeaderText = "SenderEmail";
            this.senderEmailDataGridViewTextBoxColumn1.Name = "senderEmailDataGridViewTextBoxColumn1";
            this.senderEmailDataGridViewTextBoxColumn1.Visible = false;
            // 
            // messageIdDataGridViewTextBoxColumn1
            // 
            this.messageIdDataGridViewTextBoxColumn1.DataPropertyName = "MessageId";
            this.messageIdDataGridViewTextBoxColumn1.HeaderText = "MessageId";
            this.messageIdDataGridViewTextBoxColumn1.Name = "messageIdDataGridViewTextBoxColumn1";
            this.messageIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.messageIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // messagesBindingSource1
            // 
            this.messagesBindingSource1.DataMember = "Messages";
            this.messagesBindingSource1.DataSource = this.educationProjectDataSetBindingSource;
            // 
            // educationProjectDataSetBindingSource
            // 
            this.educationProjectDataSetBindingSource.DataSource = this.educationProjectDataSet;
            this.educationProjectDataSetBindingSource.Position = 0;
            // 
            // rbxMessagesSent
            // 
            this.rbxMessagesSent.Location = new System.Drawing.Point(57, 260);
            this.rbxMessagesSent.Name = "rbxMessagesSent";
            this.rbxMessagesSent.ReadOnly = true;
            this.rbxMessagesSent.Size = new System.Drawing.Size(729, 133);
            this.rbxMessagesSent.TabIndex = 13;
            this.rbxMessagesSent.Text = "";
            // 
            // lblMessagesSentBody
            // 
            this.lblMessagesSentBody.AutoSize = true;
            this.lblMessagesSentBody.Location = new System.Drawing.Point(14, 263);
            this.lblMessagesSentBody.Name = "lblMessagesSentBody";
            this.lblMessagesSentBody.Size = new System.Drawing.Size(37, 13);
            this.lblMessagesSentBody.TabIndex = 12;
            this.lblMessagesSentBody.Text = "Body :";
            // 
            // lblMessagesSentSubjectValue
            // 
            this.lblMessagesSentSubjectValue.AutoSize = true;
            this.lblMessagesSentSubjectValue.Location = new System.Drawing.Point(64, 237);
            this.lblMessagesSentSubjectValue.Name = "lblMessagesSentSubjectValue";
            this.lblMessagesSentSubjectValue.Size = new System.Drawing.Size(54, 13);
            this.lblMessagesSentSubjectValue.TabIndex = 11;
            this.lblMessagesSentSubjectValue.Text = "Loading...";
            // 
            // lblMessagesSentSubject
            // 
            this.lblMessagesSentSubject.AutoSize = true;
            this.lblMessagesSentSubject.Location = new System.Drawing.Point(11, 237);
            this.lblMessagesSentSubject.Name = "lblMessagesSentSubject";
            this.lblMessagesSentSubject.Size = new System.Drawing.Size(49, 13);
            this.lblMessagesSentSubject.TabIndex = 10;
            this.lblMessagesSentSubject.Text = "Subject :";
            // 
            // lblMessagesSentReceiverValue
            // 
            this.lblMessagesSentReceiverValue.AutoSize = true;
            this.lblMessagesSentReceiverValue.Location = new System.Drawing.Point(64, 213);
            this.lblMessagesSentReceiverValue.Name = "lblMessagesSentReceiverValue";
            this.lblMessagesSentReceiverValue.Size = new System.Drawing.Size(54, 13);
            this.lblMessagesSentReceiverValue.TabIndex = 9;
            this.lblMessagesSentReceiverValue.Text = "Loading...";
            // 
            // lblMessagesSentReceiver
            // 
            this.lblMessagesSentReceiver.AutoSize = true;
            this.lblMessagesSentReceiver.Location = new System.Drawing.Point(11, 213);
            this.lblMessagesSentReceiver.Name = "lblMessagesSentReceiver";
            this.lblMessagesSentReceiver.Size = new System.Drawing.Size(56, 13);
            this.lblMessagesSentReceiver.TabIndex = 8;
            this.lblMessagesSentReceiver.Text = "Receiver :";
            // 
            // tabWorkMates
            // 
            this.tabWorkMates.Controls.Add(this.cbxWorkMatesSelectMentor);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesSelectMentor);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesMentors);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorPhoneValue);
            this.tabWorkMates.Controls.Add(this.rbxWorkMatesMentorBioValue);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorBio);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorPhone);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorEmailValue);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorEmail);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorSurnameValue);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorSurname);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorNameValue);
            this.tabWorkMates.Controls.Add(this.lblWorkMatesMentorName);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesMentorInfo);
            this.tabWorkMates.Controls.Add(this.pbxWorkMatesMentorPhoto);
            this.tabWorkMates.Controls.Add(this.cbxWorkmatesSelectTeacher);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesSelectTeacher);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeachers);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherPhoneValue);
            this.tabWorkMates.Controls.Add(this.rbxWorkmatesTeacherBioValue);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherBio);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherPhone);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherEmailValue);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherEmail);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherSurnameValue);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherSurname);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherNameValue);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesTeacherName);
            this.tabWorkMates.Controls.Add(this.lblWorkmatesInfo);
            this.tabWorkMates.Controls.Add(this.pbxWorkmatesTeacherPhoto);
            this.tabWorkMates.Location = new System.Drawing.Point(4, 22);
            this.tabWorkMates.Name = "tabWorkMates";
            this.tabWorkMates.Size = new System.Drawing.Size(796, 429);
            this.tabWorkMates.TabIndex = 6;
            this.tabWorkMates.Text = "Work mates";
            this.tabWorkMates.UseVisualStyleBackColor = true;
            // 
            // cbxWorkMatesSelectMentor
            // 
            this.cbxWorkMatesSelectMentor.FormattingEnabled = true;
            this.cbxWorkMatesSelectMentor.Location = new System.Drawing.Point(505, 44);
            this.cbxWorkMatesSelectMentor.Name = "cbxWorkMatesSelectMentor";
            this.cbxWorkMatesSelectMentor.Size = new System.Drawing.Size(121, 21);
            this.cbxWorkMatesSelectMentor.TabIndex = 126;
            this.cbxWorkMatesSelectMentor.SelectedIndexChanged += new System.EventHandler(this.cbxWorkMatesSelectMentor_SelectedIndexChanged);
            // 
            // lblWorkMatesSelectMentor
            // 
            this.lblWorkMatesSelectMentor.AutoSize = true;
            this.lblWorkMatesSelectMentor.Location = new System.Drawing.Point(427, 47);
            this.lblWorkMatesSelectMentor.Name = "lblWorkMatesSelectMentor";
            this.lblWorkMatesSelectMentor.Size = new System.Drawing.Size(72, 13);
            this.lblWorkMatesSelectMentor.TabIndex = 125;
            this.lblWorkMatesSelectMentor.Text = "Select mentor";
            // 
            // lblWorkmatesMentors
            // 
            this.lblWorkmatesMentors.AutoSize = true;
            this.lblWorkmatesMentors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkmatesMentors.Location = new System.Drawing.Point(425, 9);
            this.lblWorkmatesMentors.Name = "lblWorkmatesMentors";
            this.lblWorkmatesMentors.Size = new System.Drawing.Size(97, 25);
            this.lblWorkmatesMentors.TabIndex = 124;
            this.lblWorkmatesMentors.Text = "Mentors";
            // 
            // lblWorkMatesMentorPhoneValue
            // 
            this.lblWorkMatesMentorPhoneValue.AutoSize = true;
            this.lblWorkMatesMentorPhoneValue.Location = new System.Drawing.Point(629, 245);
            this.lblWorkMatesMentorPhoneValue.Name = "lblWorkMatesMentorPhoneValue";
            this.lblWorkMatesMentorPhoneValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkMatesMentorPhoneValue.TabIndex = 123;
            this.lblWorkMatesMentorPhoneValue.Text = "Loading...";
            // 
            // rbxWorkMatesMentorBioValue
            // 
            this.rbxWorkMatesMentorBioValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxWorkMatesMentorBioValue.Location = new System.Drawing.Point(424, 302);
            this.rbxWorkMatesMentorBioValue.Name = "rbxWorkMatesMentorBioValue";
            this.rbxWorkMatesMentorBioValue.ReadOnly = true;
            this.rbxWorkMatesMentorBioValue.Size = new System.Drawing.Size(257, 96);
            this.rbxWorkMatesMentorBioValue.TabIndex = 122;
            this.rbxWorkMatesMentorBioValue.Text = "";
            // 
            // lblWorkMatesMentorBio
            // 
            this.lblWorkMatesMentorBio.AutoSize = true;
            this.lblWorkMatesMentorBio.Location = new System.Drawing.Point(541, 276);
            this.lblWorkMatesMentorBio.Name = "lblWorkMatesMentorBio";
            this.lblWorkMatesMentorBio.Size = new System.Drawing.Size(28, 13);
            this.lblWorkMatesMentorBio.TabIndex = 121;
            this.lblWorkMatesMentorBio.Text = "Bio :";
            // 
            // lblWorkMatesMentorPhone
            // 
            this.lblWorkMatesMentorPhone.AutoSize = true;
            this.lblWorkMatesMentorPhone.Location = new System.Drawing.Point(541, 245);
            this.lblWorkMatesMentorPhone.Name = "lblWorkMatesMentorPhone";
            this.lblWorkMatesMentorPhone.Size = new System.Drawing.Size(44, 13);
            this.lblWorkMatesMentorPhone.TabIndex = 120;
            this.lblWorkMatesMentorPhone.Text = "Phone :";
            // 
            // lblWorkMatesMentorEmailValue
            // 
            this.lblWorkMatesMentorEmailValue.AutoSize = true;
            this.lblWorkMatesMentorEmailValue.Location = new System.Drawing.Point(629, 216);
            this.lblWorkMatesMentorEmailValue.Name = "lblWorkMatesMentorEmailValue";
            this.lblWorkMatesMentorEmailValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkMatesMentorEmailValue.TabIndex = 119;
            this.lblWorkMatesMentorEmailValue.Text = "Loading...";
            // 
            // lblWorkMatesMentorEmail
            // 
            this.lblWorkMatesMentorEmail.AutoSize = true;
            this.lblWorkMatesMentorEmail.Location = new System.Drawing.Point(541, 216);
            this.lblWorkMatesMentorEmail.Name = "lblWorkMatesMentorEmail";
            this.lblWorkMatesMentorEmail.Size = new System.Drawing.Size(38, 13);
            this.lblWorkMatesMentorEmail.TabIndex = 118;
            this.lblWorkMatesMentorEmail.Text = "Email :";
            // 
            // lblWorkMatesMentorSurnameValue
            // 
            this.lblWorkMatesMentorSurnameValue.AutoSize = true;
            this.lblWorkMatesMentorSurnameValue.Location = new System.Drawing.Point(629, 185);
            this.lblWorkMatesMentorSurnameValue.Name = "lblWorkMatesMentorSurnameValue";
            this.lblWorkMatesMentorSurnameValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkMatesMentorSurnameValue.TabIndex = 117;
            this.lblWorkMatesMentorSurnameValue.Text = "Loading...";
            // 
            // lblWorkMatesMentorSurname
            // 
            this.lblWorkMatesMentorSurname.AutoSize = true;
            this.lblWorkMatesMentorSurname.Location = new System.Drawing.Point(541, 185);
            this.lblWorkMatesMentorSurname.Name = "lblWorkMatesMentorSurname";
            this.lblWorkMatesMentorSurname.Size = new System.Drawing.Size(55, 13);
            this.lblWorkMatesMentorSurname.TabIndex = 116;
            this.lblWorkMatesMentorSurname.Text = "Surname :";
            // 
            // lblWorkMatesMentorNameValue
            // 
            this.lblWorkMatesMentorNameValue.AutoSize = true;
            this.lblWorkMatesMentorNameValue.Location = new System.Drawing.Point(629, 156);
            this.lblWorkMatesMentorNameValue.Name = "lblWorkMatesMentorNameValue";
            this.lblWorkMatesMentorNameValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkMatesMentorNameValue.TabIndex = 115;
            this.lblWorkMatesMentorNameValue.Text = "Loading...";
            // 
            // lblWorkMatesMentorName
            // 
            this.lblWorkMatesMentorName.AutoSize = true;
            this.lblWorkMatesMentorName.Location = new System.Drawing.Point(541, 156);
            this.lblWorkMatesMentorName.Name = "lblWorkMatesMentorName";
            this.lblWorkMatesMentorName.Size = new System.Drawing.Size(41, 13);
            this.lblWorkMatesMentorName.TabIndex = 114;
            this.lblWorkMatesMentorName.Text = "Name :";
            // 
            // lblWorkmatesMentorInfo
            // 
            this.lblWorkmatesMentorInfo.AutoSize = true;
            this.lblWorkmatesMentorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkmatesMentorInfo.Location = new System.Drawing.Point(545, 101);
            this.lblWorkmatesMentorInfo.Name = "lblWorkmatesMentorInfo";
            this.lblWorkmatesMentorInfo.Size = new System.Drawing.Size(51, 25);
            this.lblWorkmatesMentorInfo.TabIndex = 113;
            this.lblWorkmatesMentorInfo.Text = "Info";
            // 
            // pbxWorkMatesMentorPhoto
            // 
            this.pbxWorkMatesMentorPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxWorkMatesMentorPhoto.ErrorImage")));
            this.pbxWorkMatesMentorPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxWorkMatesMentorPhoto.Image")));
            this.pbxWorkMatesMentorPhoto.Location = new System.Drawing.Point(424, 101);
            this.pbxWorkMatesMentorPhoto.Name = "pbxWorkMatesMentorPhoto";
            this.pbxWorkMatesMentorPhoto.Size = new System.Drawing.Size(105, 112);
            this.pbxWorkMatesMentorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWorkMatesMentorPhoto.TabIndex = 112;
            this.pbxWorkMatesMentorPhoto.TabStop = false;
            // 
            // cbxWorkmatesSelectTeacher
            // 
            this.cbxWorkmatesSelectTeacher.FormattingEnabled = true;
            this.cbxWorkmatesSelectTeacher.Location = new System.Drawing.Point(88, 44);
            this.cbxWorkmatesSelectTeacher.Name = "cbxWorkmatesSelectTeacher";
            this.cbxWorkmatesSelectTeacher.Size = new System.Drawing.Size(121, 21);
            this.cbxWorkmatesSelectTeacher.TabIndex = 111;
            this.cbxWorkmatesSelectTeacher.SelectedIndexChanged += new System.EventHandler(this.cbxWorkmatesSelectTeacher_SelectedIndexChanged);
            // 
            // lblWorkmatesSelectTeacher
            // 
            this.lblWorkmatesSelectTeacher.AutoSize = true;
            this.lblWorkmatesSelectTeacher.Location = new System.Drawing.Point(10, 47);
            this.lblWorkmatesSelectTeacher.Name = "lblWorkmatesSelectTeacher";
            this.lblWorkmatesSelectTeacher.Size = new System.Drawing.Size(76, 13);
            this.lblWorkmatesSelectTeacher.TabIndex = 110;
            this.lblWorkmatesSelectTeacher.Text = "Select teacher";
            // 
            // lblWorkmatesTeachers
            // 
            this.lblWorkmatesTeachers.AutoSize = true;
            this.lblWorkmatesTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkmatesTeachers.Location = new System.Drawing.Point(8, 9);
            this.lblWorkmatesTeachers.Name = "lblWorkmatesTeachers";
            this.lblWorkmatesTeachers.Size = new System.Drawing.Size(110, 25);
            this.lblWorkmatesTeachers.TabIndex = 109;
            this.lblWorkmatesTeachers.Text = "Teachers";
            // 
            // lblWorkmatesTeacherPhoneValue
            // 
            this.lblWorkmatesTeacherPhoneValue.AutoSize = true;
            this.lblWorkmatesTeacherPhoneValue.Location = new System.Drawing.Point(212, 245);
            this.lblWorkmatesTeacherPhoneValue.Name = "lblWorkmatesTeacherPhoneValue";
            this.lblWorkmatesTeacherPhoneValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkmatesTeacherPhoneValue.TabIndex = 108;
            this.lblWorkmatesTeacherPhoneValue.Text = "Loading...";
            // 
            // rbxWorkmatesTeacherBioValue
            // 
            this.rbxWorkmatesTeacherBioValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxWorkmatesTeacherBioValue.Location = new System.Drawing.Point(9, 302);
            this.rbxWorkmatesTeacherBioValue.Name = "rbxWorkmatesTeacherBioValue";
            this.rbxWorkmatesTeacherBioValue.ReadOnly = true;
            this.rbxWorkmatesTeacherBioValue.Size = new System.Drawing.Size(257, 96);
            this.rbxWorkmatesTeacherBioValue.TabIndex = 107;
            this.rbxWorkmatesTeacherBioValue.Text = "";
            // 
            // lblWorkmatesTeacherBio
            // 
            this.lblWorkmatesTeacherBio.AutoSize = true;
            this.lblWorkmatesTeacherBio.Location = new System.Drawing.Point(124, 276);
            this.lblWorkmatesTeacherBio.Name = "lblWorkmatesTeacherBio";
            this.lblWorkmatesTeacherBio.Size = new System.Drawing.Size(28, 13);
            this.lblWorkmatesTeacherBio.TabIndex = 106;
            this.lblWorkmatesTeacherBio.Text = "Bio :";
            // 
            // lblWorkmatesTeacherPhone
            // 
            this.lblWorkmatesTeacherPhone.AutoSize = true;
            this.lblWorkmatesTeacherPhone.Location = new System.Drawing.Point(124, 245);
            this.lblWorkmatesTeacherPhone.Name = "lblWorkmatesTeacherPhone";
            this.lblWorkmatesTeacherPhone.Size = new System.Drawing.Size(44, 13);
            this.lblWorkmatesTeacherPhone.TabIndex = 105;
            this.lblWorkmatesTeacherPhone.Text = "Phone :";
            // 
            // lblWorkmatesTeacherEmailValue
            // 
            this.lblWorkmatesTeacherEmailValue.AutoSize = true;
            this.lblWorkmatesTeacherEmailValue.Location = new System.Drawing.Point(212, 216);
            this.lblWorkmatesTeacherEmailValue.Name = "lblWorkmatesTeacherEmailValue";
            this.lblWorkmatesTeacherEmailValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkmatesTeacherEmailValue.TabIndex = 104;
            this.lblWorkmatesTeacherEmailValue.Text = "Loading...";
            // 
            // lblWorkmatesTeacherEmail
            // 
            this.lblWorkmatesTeacherEmail.AutoSize = true;
            this.lblWorkmatesTeacherEmail.Location = new System.Drawing.Point(124, 216);
            this.lblWorkmatesTeacherEmail.Name = "lblWorkmatesTeacherEmail";
            this.lblWorkmatesTeacherEmail.Size = new System.Drawing.Size(38, 13);
            this.lblWorkmatesTeacherEmail.TabIndex = 103;
            this.lblWorkmatesTeacherEmail.Text = "Email :";
            // 
            // lblWorkmatesTeacherSurnameValue
            // 
            this.lblWorkmatesTeacherSurnameValue.AutoSize = true;
            this.lblWorkmatesTeacherSurnameValue.Location = new System.Drawing.Point(212, 185);
            this.lblWorkmatesTeacherSurnameValue.Name = "lblWorkmatesTeacherSurnameValue";
            this.lblWorkmatesTeacherSurnameValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkmatesTeacherSurnameValue.TabIndex = 102;
            this.lblWorkmatesTeacherSurnameValue.Text = "Loading...";
            // 
            // lblWorkmatesTeacherSurname
            // 
            this.lblWorkmatesTeacherSurname.AutoSize = true;
            this.lblWorkmatesTeacherSurname.Location = new System.Drawing.Point(124, 185);
            this.lblWorkmatesTeacherSurname.Name = "lblWorkmatesTeacherSurname";
            this.lblWorkmatesTeacherSurname.Size = new System.Drawing.Size(55, 13);
            this.lblWorkmatesTeacherSurname.TabIndex = 101;
            this.lblWorkmatesTeacherSurname.Text = "Surname :";
            // 
            // lblWorkmatesTeacherNameValue
            // 
            this.lblWorkmatesTeacherNameValue.AutoSize = true;
            this.lblWorkmatesTeacherNameValue.Location = new System.Drawing.Point(212, 156);
            this.lblWorkmatesTeacherNameValue.Name = "lblWorkmatesTeacherNameValue";
            this.lblWorkmatesTeacherNameValue.Size = new System.Drawing.Size(54, 13);
            this.lblWorkmatesTeacherNameValue.TabIndex = 100;
            this.lblWorkmatesTeacherNameValue.Text = "Loading...";
            // 
            // lblWorkmatesTeacherName
            // 
            this.lblWorkmatesTeacherName.AutoSize = true;
            this.lblWorkmatesTeacherName.Location = new System.Drawing.Point(124, 156);
            this.lblWorkmatesTeacherName.Name = "lblWorkmatesTeacherName";
            this.lblWorkmatesTeacherName.Size = new System.Drawing.Size(41, 13);
            this.lblWorkmatesTeacherName.TabIndex = 99;
            this.lblWorkmatesTeacherName.Text = "Name :";
            // 
            // lblWorkmatesInfo
            // 
            this.lblWorkmatesInfo.AutoSize = true;
            this.lblWorkmatesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkmatesInfo.Location = new System.Drawing.Point(128, 101);
            this.lblWorkmatesInfo.Name = "lblWorkmatesInfo";
            this.lblWorkmatesInfo.Size = new System.Drawing.Size(51, 25);
            this.lblWorkmatesInfo.TabIndex = 98;
            this.lblWorkmatesInfo.Text = "Info";
            // 
            // pbxWorkmatesTeacherPhoto
            // 
            this.pbxWorkmatesTeacherPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxWorkmatesTeacherPhoto.ErrorImage")));
            this.pbxWorkmatesTeacherPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxWorkmatesTeacherPhoto.Image")));
            this.pbxWorkmatesTeacherPhoto.Location = new System.Drawing.Point(7, 101);
            this.pbxWorkmatesTeacherPhoto.Name = "pbxWorkmatesTeacherPhoto";
            this.pbxWorkmatesTeacherPhoto.Size = new System.Drawing.Size(105, 112);
            this.pbxWorkmatesTeacherPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWorkmatesTeacherPhoto.TabIndex = 97;
            this.pbxWorkmatesTeacherPhoto.TabStop = false;
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
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // MentorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMentor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MentorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MentorForm";
            this.Load += new System.EventHandler(this.Mentor_Load);
            this.tabControlMentor.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).EndInit();
            this.tabTask.ResumeLayout(false);
            this.tabTask.PerformLayout();
            this.gbxUpdateTask.ResumeLayout(false);
            this.gbxUpdateTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet5)).EndInit();
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).EndInit();
            this.gbxGroupsInfo.ResumeLayout(false);
            this.gbxGroupsInfo.PerformLayout();
            this.tabMessages.ResumeLayout(false);
            this.tabControllMessages.ResumeLayout(false);
            this.tabMessagesSendTo.ResumeLayout(false);
            this.tabMessagesSendTo.PerformLayout();
            this.tabMessagesInbox.ResumeLayout(false);
            this.tabMessagesInbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet)).EndInit();
            this.tabMessagesSent.ResumeLayout(false);
            this.tabMessagesSent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessagesSent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSetBindingSource)).EndInit();
            this.tabWorkMates.ResumeLayout(false);
            this.tabWorkMates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorkMatesMentorPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorkmatesTeacherPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMentor;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Button btnSaveChangePhone;
        private System.Windows.Forms.Button btnSaveChangePassword;
        private System.Windows.Forms.TextBox tbxTeacherPhoneValue;
        private System.Windows.Forms.TextBox tbxTeacherPasswordValue;
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
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.GroupBox gbxUpdateTask;
        private System.Windows.Forms.RichTextBox rbxUpdateTaskBody;
        private System.Windows.Forms.Label label1lblUpdateTaskBody;
        private System.Windows.Forms.TextBox tbxUpdateTaskSubject;
        private System.Windows.Forms.Label lblUpdateTaskSubject;
        private System.Windows.Forms.TextBox tbxUpdateTaskName;
        private System.Windows.Forms.Label lblUpdateTaskName;
        private System.Windows.Forms.DataGridView dgvTasksList;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.Button btnGoupsShowAllStudents;
        private System.Windows.Forms.TextBox tbxGroupsSearchByName;
        private System.Windows.Forms.Label lblGroupsSearchByName;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.DataGridView dgvGroupsStudentsList;
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
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabControl tabControllMessages;
        private System.Windows.Forms.TabPage tabMessagesSendTo;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbxMessageSubject;
        private System.Windows.Forms.TextBox tbxMessageReceiver;
        private System.Windows.Forms.RichTextBox rbxMessagesBody;
        private System.Windows.Forms.Label lblMessagesBody;
        private System.Windows.Forms.Label lblMessagesSubject;
        private System.Windows.Forms.Label lblMessageReceiver;
        private System.Windows.Forms.Button btnSendToStudents;
        private System.Windows.Forms.Button btnSendToMentor;
        private System.Windows.Forms.Button btnSendToTeacher;
        private System.Windows.Forms.TabPage tabMessagesInbox;
        private System.Windows.Forms.RichTextBox rbxMessageInboxBody;
        private System.Windows.Forms.Label lblMessageInboxBody;
        private System.Windows.Forms.Label lblMessageInboxSubjectValue;
        private System.Windows.Forms.Label lblMessageInboxSubject;
        private System.Windows.Forms.Label lblMessageInboxSenderValue;
        private System.Windows.Forms.Label lblMessageInboxSender;
        private System.Windows.Forms.DataGridView dgvInbox;
        private System.Windows.Forms.TabPage tabMessagesSent;
        private System.Windows.Forms.DataGridView dgvMessagesSent;
        private System.Windows.Forms.RichTextBox rbxMessagesSent;
        private System.Windows.Forms.Label lblMessagesSentBody;
        private System.Windows.Forms.Label lblMessagesSentSubjectValue;
        private System.Windows.Forms.Label lblMessagesSentSubject;
        private System.Windows.Forms.Label lblMessagesSentReceiverValue;
        private System.Windows.Forms.Label lblMessagesSentReceiver;
        private System.Windows.Forms.TabPage tabWorkMates;
        private System.Windows.Forms.ComboBox cbxWorkmatesSelectTeacher;
        private System.Windows.Forms.Label lblWorkmatesSelectTeacher;
        private System.Windows.Forms.Label lblWorkmatesTeachers;
        private System.Windows.Forms.Label lblWorkmatesTeacherPhoneValue;
        private System.Windows.Forms.RichTextBox rbxWorkmatesTeacherBioValue;
        private System.Windows.Forms.Label lblWorkmatesTeacherBio;
        private System.Windows.Forms.Label lblWorkmatesTeacherPhone;
        private System.Windows.Forms.Label lblWorkmatesTeacherEmailValue;
        private System.Windows.Forms.Label lblWorkmatesTeacherEmail;
        private System.Windows.Forms.Label lblWorkmatesTeacherSurnameValue;
        private System.Windows.Forms.Label lblWorkmatesTeacherSurname;
        private System.Windows.Forms.Label lblWorkmatesTeacherNameValue;
        private System.Windows.Forms.Label lblWorkmatesTeacherName;
        private System.Windows.Forms.Label lblWorkmatesInfo;
        private System.Windows.Forms.PictureBox pbxWorkmatesTeacherPhoto;
        private System.Windows.Forms.TabPage tabLibrary;
        private System.Windows.Forms.ComboBox cbxWorkMatesSelectMentor;
        private System.Windows.Forms.Label lblWorkMatesSelectMentor;
        private System.Windows.Forms.Label lblWorkmatesMentors;
        private System.Windows.Forms.Label lblWorkMatesMentorPhoneValue;
        private System.Windows.Forms.RichTextBox rbxWorkMatesMentorBioValue;
        private System.Windows.Forms.Label lblWorkMatesMentorBio;
        private System.Windows.Forms.Label lblWorkMatesMentorPhone;
        private System.Windows.Forms.Label lblWorkMatesMentorEmailValue;
        private System.Windows.Forms.Label lblWorkMatesMentorEmail;
        private System.Windows.Forms.Label lblWorkMatesMentorSurnameValue;
        private System.Windows.Forms.Label lblWorkMatesMentorSurname;
        private System.Windows.Forms.Label lblWorkMatesMentorNameValue;
        private System.Windows.Forms.Label lblWorkMatesMentorName;
        private System.Windows.Forms.Label lblWorkmatesMentorInfo;
        private System.Windows.Forms.PictureBox pbxWorkMatesMentorPhoto;
        private EducationProjectDataSet5 educationProjectDataSet5;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private EducationProjectDataSet5TableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private EducationProjectDataSet educationProjectDataSet;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private EducationProjectDataSetTableAdapters.MessagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageSendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageSendTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageSubjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageBodyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource messagesBindingSource1;
        private System.Windows.Forms.BindingSource educationProjectDataSetBindingSource;
    }
}