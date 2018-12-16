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
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.tabMentorInfo = new System.Windows.Forms.TabPage();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tabWorkMates = new System.Windows.Forms.TabPage();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.tasksTableAdapter = new EducationProject.EducationProjectDataSet5TableAdapters.TasksTableAdapter();
            this.groupsTableAdapter1 = new EducationProject.EducationProjectDataSet3TableAdapters.GroupsTableAdapter();
            this.gbxUpdateTask = new System.Windows.Forms.GroupBox();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.rbxUpdateTaskBody = new System.Windows.Forms.RichTextBox();
            this.label1lblUpdateTaskBody = new System.Windows.Forms.Label();
            this.tbxUpdateTaskSubject = new System.Windows.Forms.TextBox();
            this.lblUpdateTaskSubject = new System.Windows.Forms.Label();
            this.tbxUpdateTaskName = new System.Windows.Forms.TextBox();
            this.lblUpdateTaskName = new System.Windows.Forms.Label();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.tabControlTeacher.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).BeginInit();
            this.tabTask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet5)).BeginInit();
            this.gbxUpdateTask.SuspendLayout();
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
            this.tabAssignTask.Location = new System.Drawing.Point(4, 22);
            this.tabAssignTask.Name = "tabAssignTask";
            this.tabAssignTask.Size = new System.Drawing.Size(796, 429);
            this.tabAssignTask.TabIndex = 2;
            this.tabAssignTask.Text = "Assign task";
            this.tabAssignTask.UseVisualStyleBackColor = true;
            // 
            // tabGroups
            // 
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(796, 429);
            this.tabGroups.TabIndex = 3;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // tabMentorInfo
            // 
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet5)).EndInit();
            this.gbxUpdateTask.ResumeLayout(false);
            this.gbxUpdateTask.PerformLayout();
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
    }
}