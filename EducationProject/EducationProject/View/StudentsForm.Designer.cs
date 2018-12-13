namespace EducationProject.View
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.btnStudentChangePhoto = new System.Windows.Forms.Button();
            this.btnEditBirthDate = new System.Windows.Forms.Button();
            this.btnEditPhone = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.lblStudentPasswordValue = new System.Windows.Forms.Label();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.lblStudentEndDateValue = new System.Windows.Forms.Label();
            this.lblStudentEndDate = new System.Windows.Forms.Label();
            this.lblStudentStartDateValue = new System.Windows.Forms.Label();
            this.lblStudentStartDate = new System.Windows.Forms.Label();
            this.lblStudentGroupValue = new System.Windows.Forms.Label();
            this.lblStudentGroup = new System.Windows.Forms.Label();
            this.lblStudentRegisterDateValue = new System.Windows.Forms.Label();
            this.lblStudentRegisterDate = new System.Windows.Forms.Label();
            this.lblStudentBirthDateValue = new System.Windows.Forms.Label();
            this.lblStudentBirthDate = new System.Windows.Forms.Label();
            this.lblStudentPhoneValue = new System.Windows.Forms.Label();
            this.lblStudentPhone = new System.Windows.Forms.Label();
            this.lblStudentEmailValue = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentSurnameValue = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentNameValue = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.pbxStudentPhoto = new System.Windows.Forms.PictureBox();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.cbxSelectTask = new System.Windows.Forms.ComboBox();
            this.lblStudentAvgPointValue = new System.Windows.Forms.Label();
            this.lblStudentTaskEndDateValue = new System.Windows.Forms.Label();
            this.lblStudentTaskStartDateValue = new System.Windows.Forms.Label();
            this.lblStudentTaskSubjectValue = new System.Windows.Forms.Label();
            this.lblStudentAvgPoint = new System.Windows.Forms.Label();
            this.lblStudentTaskEndDate = new System.Windows.Forms.Label();
            this.lblStudentTaskStartDate = new System.Windows.Forms.Label();
            this.rbxStudentTaskBody = new System.Windows.Forms.RichTextBox();
            this.lblStudentTaskBody = new System.Windows.Forms.Label();
            this.lblStudentTaskSubject = new System.Windows.Forms.Label();
            this.lblStudentSelectTask = new System.Windows.Forms.Label();
            this.lblStudentTask = new System.Windows.Forms.Label();
            this.tabTeacherInfo = new System.Windows.Forms.TabPage();
            this.taMentorInfo = new System.Windows.Forms.TabPage();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tabGroupmates = new System.Windows.Forms.TabPage();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentPhoto)).BeginInit();
            this.tabTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Controls.Add(this.tabTask);
            this.tabControl.Controls.Add(this.tabTeacherInfo);
            this.tabControl.Controls.Add(this.taMentorInfo);
            this.tabControl.Controls.Add(this.tabMessages);
            this.tabControl.Controls.Add(this.tabGroupmates);
            this.tabControl.Controls.Add(this.tabLibrary);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 450);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.btnStudentChangePhoto);
            this.tabInfo.Controls.Add(this.btnEditBirthDate);
            this.tabInfo.Controls.Add(this.btnEditPhone);
            this.tabInfo.Controls.Add(this.btnEditPassword);
            this.tabInfo.Controls.Add(this.lblStudentPasswordValue);
            this.tabInfo.Controls.Add(this.lblStudentPassword);
            this.tabInfo.Controls.Add(this.lblStudentEndDateValue);
            this.tabInfo.Controls.Add(this.lblStudentEndDate);
            this.tabInfo.Controls.Add(this.lblStudentStartDateValue);
            this.tabInfo.Controls.Add(this.lblStudentStartDate);
            this.tabInfo.Controls.Add(this.lblStudentGroupValue);
            this.tabInfo.Controls.Add(this.lblStudentGroup);
            this.tabInfo.Controls.Add(this.lblStudentRegisterDateValue);
            this.tabInfo.Controls.Add(this.lblStudentRegisterDate);
            this.tabInfo.Controls.Add(this.lblStudentBirthDateValue);
            this.tabInfo.Controls.Add(this.lblStudentBirthDate);
            this.tabInfo.Controls.Add(this.lblStudentPhoneValue);
            this.tabInfo.Controls.Add(this.lblStudentPhone);
            this.tabInfo.Controls.Add(this.lblStudentEmailValue);
            this.tabInfo.Controls.Add(this.lblStudentEmail);
            this.tabInfo.Controls.Add(this.lblStudentSurnameValue);
            this.tabInfo.Controls.Add(this.lblStudentSurname);
            this.tabInfo.Controls.Add(this.lblStudentNameValue);
            this.tabInfo.Controls.Add(this.lblStudentName);
            this.tabInfo.Controls.Add(this.lblStudentInfo);
            this.tabInfo.Controls.Add(this.pbxStudentPhoto);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(793, 424);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // btnStudentChangePhoto
            // 
            this.btnStudentChangePhoto.AutoSize = true;
            this.btnStudentChangePhoto.Location = new System.Drawing.Point(9, 125);
            this.btnStudentChangePhoto.Name = "btnStudentChangePhoto";
            this.btnStudentChangePhoto.Size = new System.Drawing.Size(84, 23);
            this.btnStudentChangePhoto.TabIndex = 26;
            this.btnStudentChangePhoto.Text = "Change photo";
            this.btnStudentChangePhoto.UseVisualStyleBackColor = true;
            this.btnStudentChangePhoto.Click += new System.EventHandler(this.btnStudentChangePhoto_Click);
            // 
            // btnEditBirthDate
            // 
            this.btnEditBirthDate.AutoSize = true;
            this.btnEditBirthDate.Location = new System.Drawing.Point(312, 209);
            this.btnEditBirthDate.Name = "btnEditBirthDate";
            this.btnEditBirthDate.Size = new System.Drawing.Size(82, 23);
            this.btnEditBirthDate.TabIndex = 25;
            this.btnEditBirthDate.Text = "Edit birth date";
            this.btnEditBirthDate.UseVisualStyleBackColor = true;
            // 
            // btnEditPhone
            // 
            this.btnEditPhone.AutoSize = true;
            this.btnEditPhone.Location = new System.Drawing.Point(312, 179);
            this.btnEditPhone.Name = "btnEditPhone";
            this.btnEditPhone.Size = new System.Drawing.Size(75, 23);
            this.btnEditPhone.TabIndex = 24;
            this.btnEditPhone.Text = "Edit phone";
            this.btnEditPhone.UseVisualStyleBackColor = true;
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.AutoSize = true;
            this.btnEditPassword.Location = new System.Drawing.Point(312, 147);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(83, 23);
            this.btnEditPassword.TabIndex = 23;
            this.btnEditPassword.Text = "Edit password";
            this.btnEditPassword.UseVisualStyleBackColor = true;
            // 
            // lblStudentPasswordValue
            // 
            this.lblStudentPasswordValue.AutoSize = true;
            this.lblStudentPasswordValue.Location = new System.Drawing.Point(214, 152);
            this.lblStudentPasswordValue.Name = "lblStudentPasswordValue";
            this.lblStudentPasswordValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentPasswordValue.TabIndex = 22;
            this.lblStudentPasswordValue.Text = "Loading...";
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Location = new System.Drawing.Point(126, 152);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(59, 13);
            this.lblStudentPassword.TabIndex = 21;
            this.lblStudentPassword.Text = "Password :";
            // 
            // lblStudentEndDateValue
            // 
            this.lblStudentEndDateValue.AutoSize = true;
            this.lblStudentEndDateValue.Location = new System.Drawing.Point(214, 335);
            this.lblStudentEndDateValue.Name = "lblStudentEndDateValue";
            this.lblStudentEndDateValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentEndDateValue.TabIndex = 20;
            this.lblStudentEndDateValue.Text = "Loading...";
            // 
            // lblStudentEndDate
            // 
            this.lblStudentEndDate.AutoSize = true;
            this.lblStudentEndDate.Location = new System.Drawing.Point(126, 335);
            this.lblStudentEndDate.Name = "lblStudentEndDate";
            this.lblStudentEndDate.Size = new System.Drawing.Size(56, 13);
            this.lblStudentEndDate.TabIndex = 19;
            this.lblStudentEndDate.Text = "End date :";
            // 
            // lblStudentStartDateValue
            // 
            this.lblStudentStartDateValue.AutoSize = true;
            this.lblStudentStartDateValue.Location = new System.Drawing.Point(214, 306);
            this.lblStudentStartDateValue.Name = "lblStudentStartDateValue";
            this.lblStudentStartDateValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentStartDateValue.TabIndex = 18;
            this.lblStudentStartDateValue.Text = "Loading...";
            // 
            // lblStudentStartDate
            // 
            this.lblStudentStartDate.AutoSize = true;
            this.lblStudentStartDate.Location = new System.Drawing.Point(126, 306);
            this.lblStudentStartDate.Name = "lblStudentStartDate";
            this.lblStudentStartDate.Size = new System.Drawing.Size(59, 13);
            this.lblStudentStartDate.TabIndex = 17;
            this.lblStudentStartDate.Text = "Start date :";
            // 
            // lblStudentGroupValue
            // 
            this.lblStudentGroupValue.AutoSize = true;
            this.lblStudentGroupValue.Location = new System.Drawing.Point(214, 274);
            this.lblStudentGroupValue.Name = "lblStudentGroupValue";
            this.lblStudentGroupValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentGroupValue.TabIndex = 16;
            this.lblStudentGroupValue.Text = "Loading...";
            // 
            // lblStudentGroup
            // 
            this.lblStudentGroup.AutoSize = true;
            this.lblStudentGroup.Location = new System.Drawing.Point(126, 274);
            this.lblStudentGroup.Name = "lblStudentGroup";
            this.lblStudentGroup.Size = new System.Drawing.Size(42, 13);
            this.lblStudentGroup.TabIndex = 15;
            this.lblStudentGroup.Text = "Group :";
            // 
            // lblStudentRegisterDateValue
            // 
            this.lblStudentRegisterDateValue.AutoSize = true;
            this.lblStudentRegisterDateValue.Location = new System.Drawing.Point(214, 243);
            this.lblStudentRegisterDateValue.Name = "lblStudentRegisterDateValue";
            this.lblStudentRegisterDateValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentRegisterDateValue.TabIndex = 14;
            this.lblStudentRegisterDateValue.Text = "Loading...";
            // 
            // lblStudentRegisterDate
            // 
            this.lblStudentRegisterDate.AutoSize = true;
            this.lblStudentRegisterDate.Location = new System.Drawing.Point(126, 243);
            this.lblStudentRegisterDate.Name = "lblStudentRegisterDate";
            this.lblStudentRegisterDate.Size = new System.Drawing.Size(76, 13);
            this.lblStudentRegisterDate.TabIndex = 13;
            this.lblStudentRegisterDate.Text = "Register date :";
            // 
            // lblStudentBirthDateValue
            // 
            this.lblStudentBirthDateValue.AutoSize = true;
            this.lblStudentBirthDateValue.Location = new System.Drawing.Point(214, 214);
            this.lblStudentBirthDateValue.Name = "lblStudentBirthDateValue";
            this.lblStudentBirthDateValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentBirthDateValue.TabIndex = 12;
            this.lblStudentBirthDateValue.Text = "Loading...";
            // 
            // lblStudentBirthDate
            // 
            this.lblStudentBirthDate.AutoSize = true;
            this.lblStudentBirthDate.Location = new System.Drawing.Point(126, 214);
            this.lblStudentBirthDate.Name = "lblStudentBirthDate";
            this.lblStudentBirthDate.Size = new System.Drawing.Size(55, 13);
            this.lblStudentBirthDate.TabIndex = 11;
            this.lblStudentBirthDate.Text = "Birthdate :";
            // 
            // lblStudentPhoneValue
            // 
            this.lblStudentPhoneValue.AutoSize = true;
            this.lblStudentPhoneValue.Location = new System.Drawing.Point(214, 184);
            this.lblStudentPhoneValue.Name = "lblStudentPhoneValue";
            this.lblStudentPhoneValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentPhoneValue.TabIndex = 10;
            this.lblStudentPhoneValue.Text = "Loading...";
            // 
            // lblStudentPhone
            // 
            this.lblStudentPhone.AutoSize = true;
            this.lblStudentPhone.Location = new System.Drawing.Point(126, 184);
            this.lblStudentPhone.Name = "lblStudentPhone";
            this.lblStudentPhone.Size = new System.Drawing.Size(44, 13);
            this.lblStudentPhone.TabIndex = 9;
            this.lblStudentPhone.Text = "Phone :";
            // 
            // lblStudentEmailValue
            // 
            this.lblStudentEmailValue.AutoSize = true;
            this.lblStudentEmailValue.Location = new System.Drawing.Point(214, 122);
            this.lblStudentEmailValue.Name = "lblStudentEmailValue";
            this.lblStudentEmailValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentEmailValue.TabIndex = 8;
            this.lblStudentEmailValue.Text = "Loading...";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(126, 122);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(38, 13);
            this.lblStudentEmail.TabIndex = 7;
            this.lblStudentEmail.Text = "Email :";
            // 
            // lblStudentSurnameValue
            // 
            this.lblStudentSurnameValue.AutoSize = true;
            this.lblStudentSurnameValue.Location = new System.Drawing.Point(214, 91);
            this.lblStudentSurnameValue.Name = "lblStudentSurnameValue";
            this.lblStudentSurnameValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentSurnameValue.TabIndex = 6;
            this.lblStudentSurnameValue.Text = "Loading...";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(126, 91);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(55, 13);
            this.lblStudentSurname.TabIndex = 5;
            this.lblStudentSurname.Text = "Surname :";
            // 
            // lblStudentNameValue
            // 
            this.lblStudentNameValue.AutoSize = true;
            this.lblStudentNameValue.Location = new System.Drawing.Point(214, 62);
            this.lblStudentNameValue.Name = "lblStudentNameValue";
            this.lblStudentNameValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentNameValue.TabIndex = 4;
            this.lblStudentNameValue.Text = "Loading...";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(126, 62);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(41, 13);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Name :";
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentInfo.Location = new System.Drawing.Point(121, 7);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(51, 25);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Info";
            // 
            // pbxStudentPhoto
            // 
            this.pbxStudentPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxStudentPhoto.ErrorImage")));
            this.pbxStudentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudentPhoto.Image")));
            this.pbxStudentPhoto.Location = new System.Drawing.Point(9, 7);
            this.pbxStudentPhoto.Name = "pbxStudentPhoto";
            this.pbxStudentPhoto.Size = new System.Drawing.Size(105, 112);
            this.pbxStudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudentPhoto.TabIndex = 0;
            this.pbxStudentPhoto.TabStop = false;
            // 
            // tabTask
            // 
            this.tabTask.Controls.Add(this.cbxSelectTask);
            this.tabTask.Controls.Add(this.lblStudentAvgPointValue);
            this.tabTask.Controls.Add(this.lblStudentTaskEndDateValue);
            this.tabTask.Controls.Add(this.lblStudentTaskStartDateValue);
            this.tabTask.Controls.Add(this.lblStudentTaskSubjectValue);
            this.tabTask.Controls.Add(this.lblStudentAvgPoint);
            this.tabTask.Controls.Add(this.lblStudentTaskEndDate);
            this.tabTask.Controls.Add(this.lblStudentTaskStartDate);
            this.tabTask.Controls.Add(this.rbxStudentTaskBody);
            this.tabTask.Controls.Add(this.lblStudentTaskBody);
            this.tabTask.Controls.Add(this.lblStudentTaskSubject);
            this.tabTask.Controls.Add(this.lblStudentSelectTask);
            this.tabTask.Controls.Add(this.lblStudentTask);
            this.tabTask.Location = new System.Drawing.Point(4, 22);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(793, 424);
            this.tabTask.TabIndex = 1;
            this.tabTask.Text = "Task";
            this.tabTask.UseVisualStyleBackColor = true;
            // 
            // cbxSelectTask
            // 
            this.cbxSelectTask.FormattingEnabled = true;
            this.cbxSelectTask.Location = new System.Drawing.Point(96, 45);
            this.cbxSelectTask.Name = "cbxSelectTask";
            this.cbxSelectTask.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectTask.TabIndex = 12;
            this.cbxSelectTask.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTask_SelectedIndexChanged);
            // 
            // lblStudentAvgPointValue
            // 
            this.lblStudentAvgPointValue.AutoSize = true;
            this.lblStudentAvgPointValue.Location = new System.Drawing.Point(663, 15);
            this.lblStudentAvgPointValue.Name = "lblStudentAvgPointValue";
            this.lblStudentAvgPointValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentAvgPointValue.TabIndex = 11;
            this.lblStudentAvgPointValue.Text = "Loading...";
            // 
            // lblStudentTaskEndDateValue
            // 
            this.lblStudentTaskEndDateValue.AutoSize = true;
            this.lblStudentTaskEndDateValue.Location = new System.Drawing.Point(527, 174);
            this.lblStudentTaskEndDateValue.Name = "lblStudentTaskEndDateValue";
            this.lblStudentTaskEndDateValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentTaskEndDateValue.TabIndex = 10;
            this.lblStudentTaskEndDateValue.Text = "Loading...";
            // 
            // lblStudentTaskStartDateValue
            // 
            this.lblStudentTaskStartDateValue.AutoSize = true;
            this.lblStudentTaskStartDateValue.Location = new System.Drawing.Point(527, 136);
            this.lblStudentTaskStartDateValue.Name = "lblStudentTaskStartDateValue";
            this.lblStudentTaskStartDateValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentTaskStartDateValue.TabIndex = 9;
            this.lblStudentTaskStartDateValue.Text = "Loading...";
            // 
            // lblStudentTaskSubjectValue
            // 
            this.lblStudentTaskSubjectValue.AutoSize = true;
            this.lblStudentTaskSubjectValue.Location = new System.Drawing.Point(93, 80);
            this.lblStudentTaskSubjectValue.Name = "lblStudentTaskSubjectValue";
            this.lblStudentTaskSubjectValue.Size = new System.Drawing.Size(54, 13);
            this.lblStudentTaskSubjectValue.TabIndex = 8;
            this.lblStudentTaskSubjectValue.Text = "Loading...";
            // 
            // lblStudentAvgPoint
            // 
            this.lblStudentAvgPoint.AutoSize = true;
            this.lblStudentAvgPoint.Location = new System.Drawing.Point(578, 15);
            this.lblStudentAvgPoint.Name = "lblStudentAvgPoint";
            this.lblStudentAvgPoint.Size = new System.Drawing.Size(79, 13);
            this.lblStudentAvgPoint.TabIndex = 7;
            this.lblStudentAvgPoint.Text = "Average point :";
            // 
            // lblStudentTaskEndDate
            // 
            this.lblStudentTaskEndDate.AutoSize = true;
            this.lblStudentTaskEndDate.Location = new System.Drawing.Point(462, 174);
            this.lblStudentTaskEndDate.Name = "lblStudentTaskEndDate";
            this.lblStudentTaskEndDate.Size = new System.Drawing.Size(56, 13);
            this.lblStudentTaskEndDate.TabIndex = 6;
            this.lblStudentTaskEndDate.Text = "End date :";
            // 
            // lblStudentTaskStartDate
            // 
            this.lblStudentTaskStartDate.AutoSize = true;
            this.lblStudentTaskStartDate.Location = new System.Drawing.Point(462, 136);
            this.lblStudentTaskStartDate.Name = "lblStudentTaskStartDate";
            this.lblStudentTaskStartDate.Size = new System.Drawing.Size(59, 13);
            this.lblStudentTaskStartDate.TabIndex = 5;
            this.lblStudentTaskStartDate.Text = "Start date :";
            // 
            // rbxStudentTaskBody
            // 
            this.rbxStudentTaskBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxStudentTaskBody.Location = new System.Drawing.Point(13, 134);
            this.rbxStudentTaskBody.Name = "rbxStudentTaskBody";
            this.rbxStudentTaskBody.ReadOnly = true;
            this.rbxStudentTaskBody.Size = new System.Drawing.Size(410, 133);
            this.rbxStudentTaskBody.TabIndex = 4;
            this.rbxStudentTaskBody.Text = "";
            // 
            // lblStudentTaskBody
            // 
            this.lblStudentTaskBody.AutoSize = true;
            this.lblStudentTaskBody.Location = new System.Drawing.Point(13, 118);
            this.lblStudentTaskBody.Name = "lblStudentTaskBody";
            this.lblStudentTaskBody.Size = new System.Drawing.Size(63, 13);
            this.lblStudentTaskBody.TabIndex = 3;
            this.lblStudentTaskBody.Text = "Task body :";
            // 
            // lblStudentTaskSubject
            // 
            this.lblStudentTaskSubject.AutoSize = true;
            this.lblStudentTaskSubject.Location = new System.Drawing.Point(13, 80);
            this.lblStudentTaskSubject.Name = "lblStudentTaskSubject";
            this.lblStudentTaskSubject.Size = new System.Drawing.Size(74, 13);
            this.lblStudentTaskSubject.TabIndex = 2;
            this.lblStudentTaskSubject.Text = "Task subject :";
            // 
            // lblStudentSelectTask
            // 
            this.lblStudentSelectTask.AutoSize = true;
            this.lblStudentSelectTask.Location = new System.Drawing.Point(13, 48);
            this.lblStudentSelectTask.Name = "lblStudentSelectTask";
            this.lblStudentSelectTask.Size = new System.Drawing.Size(60, 13);
            this.lblStudentSelectTask.TabIndex = 1;
            this.lblStudentSelectTask.Text = "Select task";
            // 
            // lblStudentTask
            // 
            this.lblStudentTask.AutoSize = true;
            this.lblStudentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentTask.Location = new System.Drawing.Point(8, 3);
            this.lblStudentTask.Name = "lblStudentTask";
            this.lblStudentTask.Size = new System.Drawing.Size(75, 25);
            this.lblStudentTask.TabIndex = 0;
            this.lblStudentTask.Text = "Tasks";
            // 
            // tabTeacherInfo
            // 
            this.tabTeacherInfo.Location = new System.Drawing.Point(4, 22);
            this.tabTeacherInfo.Name = "tabTeacherInfo";
            this.tabTeacherInfo.Size = new System.Drawing.Size(793, 424);
            this.tabTeacherInfo.TabIndex = 2;
            this.tabTeacherInfo.Text = "Teacher info";
            this.tabTeacherInfo.UseVisualStyleBackColor = true;
            // 
            // taMentorInfo
            // 
            this.taMentorInfo.Location = new System.Drawing.Point(4, 22);
            this.taMentorInfo.Name = "taMentorInfo";
            this.taMentorInfo.Size = new System.Drawing.Size(793, 424);
            this.taMentorInfo.TabIndex = 3;
            this.taMentorInfo.Text = "Mentor info";
            this.taMentorInfo.UseVisualStyleBackColor = true;
            // 
            // tabMessages
            // 
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Size = new System.Drawing.Size(793, 424);
            this.tabMessages.TabIndex = 4;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // tabGroupmates
            // 
            this.tabGroupmates.Location = new System.Drawing.Point(4, 22);
            this.tabGroupmates.Name = "tabGroupmates";
            this.tabGroupmates.Size = new System.Drawing.Size(793, 424);
            this.tabGroupmates.TabIndex = 5;
            this.tabGroupmates.Text = "Groupmates";
            this.tabGroupmates.UseVisualStyleBackColor = true;
            // 
            // tabLibrary
            // 
            this.tabLibrary.Location = new System.Drawing.Point(4, 22);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Size = new System.Drawing.Size(793, 424);
            this.tabLibrary.TabIndex = 6;
            this.tabLibrary.Text = "Library";
            this.tabLibrary.UseVisualStyleBackColor = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentPhoto)).EndInit();
            this.tabTask.ResumeLayout(false);
            this.tabTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.TabPage tabTeacherInfo;
        private System.Windows.Forms.TabPage taMentorInfo;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabPage tabGroupmates;
        private System.Windows.Forms.TabPage tabLibrary;
        private System.Windows.Forms.PictureBox pbxStudentPhoto;
        private System.Windows.Forms.Label lblStudentSurnameValue;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentNameValue;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblStudentStartDateValue;
        private System.Windows.Forms.Label lblStudentStartDate;
        private System.Windows.Forms.Label lblStudentGroupValue;
        private System.Windows.Forms.Label lblStudentGroup;
        private System.Windows.Forms.Label lblStudentRegisterDateValue;
        private System.Windows.Forms.Label lblStudentRegisterDate;
        private System.Windows.Forms.Label lblStudentBirthDateValue;
        private System.Windows.Forms.Label lblStudentBirthDate;
        private System.Windows.Forms.Label lblStudentPhoneValue;
        private System.Windows.Forms.Label lblStudentPhone;
        private System.Windows.Forms.Label lblStudentEmailValue;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentPasswordValue;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.Label lblStudentEndDateValue;
        private System.Windows.Forms.Label lblStudentEndDate;
        private System.Windows.Forms.Button btnEditBirthDate;
        private System.Windows.Forms.Button btnEditPhone;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Button btnStudentChangePhoto;
        private System.Windows.Forms.ComboBox cbxSelectTask;
        private System.Windows.Forms.Label lblStudentAvgPointValue;
        private System.Windows.Forms.Label lblStudentTaskEndDateValue;
        private System.Windows.Forms.Label lblStudentTaskStartDateValue;
        private System.Windows.Forms.Label lblStudentTaskSubjectValue;
        private System.Windows.Forms.Label lblStudentAvgPoint;
        private System.Windows.Forms.Label lblStudentTaskEndDate;
        private System.Windows.Forms.Label lblStudentTaskStartDate;
        private System.Windows.Forms.RichTextBox rbxStudentTaskBody;
        private System.Windows.Forms.Label lblStudentTaskBody;
        private System.Windows.Forms.Label lblStudentTaskSubject;
        private System.Windows.Forms.Label lblStudentSelectTask;
        private System.Windows.Forms.Label lblStudentTask;
    }
}