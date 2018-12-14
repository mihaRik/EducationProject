namespace EducationProject.View
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectEducationPackage = new System.Windows.Forms.Label();
            this.cbxSelectGroupType = new System.Windows.Forms.ComboBox();
            this.cbxSelectGroupTime = new System.Windows.Forms.ComboBox();
            this.lblSearchByStudentName = new System.Windows.Forms.Label();
            this.cbxSelectEducationPackage = new System.Windows.Forms.ComboBox();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.cbxSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.lblSelectGroupType = new System.Windows.Forms.Label();
            this.lblSelectGroupTime = new System.Windows.Forms.Label();
            this.gbxStudentAdd = new System.Windows.Forms.GroupBox();
            this.btnNewStudentAdd = new System.Windows.Forms.Button();
            this.tbxNewStudentPhone = new System.Windows.Forms.TextBox();
            this.tbxNewStudentEmail = new System.Windows.Forms.TextBox();
            this.tbxNewStudentSurname = new System.Windows.Forms.TextBox();
            this.tbxNewStudentName = new System.Windows.Forms.TextBox();
            this.lblNewStudentEmail = new System.Windows.Forms.Label();
            this.lblNewStudentPhone = new System.Windows.Forms.Label();
            this.lblNewStudentSurname = new System.Windows.Forms.Label();
            this.lblNewStudentName = new System.Windows.Forms.Label();
            this.gbxUpdateStudent = new System.Windows.Forms.GroupBox();
            this.btnStudentUpdatePhoto = new System.Windows.Forms.Button();
            this.btnStudentRemove = new System.Windows.Forms.Button();
            this.tbxStudentUpdatePhone = new System.Windows.Forms.TextBox();
            this.tbxStudentUpdateEmail = new System.Windows.Forms.TextBox();
            this.tbxStudentUpdateSurname = new System.Windows.Forms.TextBox();
            this.tbxStudentUpdateName = new System.Windows.Forms.TextBox();
            this.rbxStudentUpdateBio = new System.Windows.Forms.RichTextBox();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.pbxStudentUpdatePhoto = new System.Windows.Forms.PictureBox();
            this.lblStudetnUpdateBio = new System.Windows.Forms.Label();
            this.lblStudetnUpdateEmail = new System.Windows.Forms.Label();
            this.lblStudetnUpdatePhone = new System.Windows.Forms.Label();
            this.lblStudetnUpdateSurname = new System.Windows.Forms.Label();
            this.lblStudentUpdateName = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgvStudentsList = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet1 = new EducationProject.EducationProjectDataSet1();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.tabTeacher = new System.Windows.Forms.TabPage();
            this.tabMentor = new System.Windows.Forms.TabPage();
            this.studentsTableAdapter = new EducationProject.EducationProjectDataSet1TableAdapters.StudentsTableAdapter();
            this.lblAddGroupName = new System.Windows.Forms.Label();
            this.lblAddGroupEducationPackage = new System.Windows.Forms.Label();
            this.lblAddGroupType = new System.Windows.Forms.Label();
            this.lblAddGroupLessonTime = new System.Windows.Forms.Label();
            this.lblAddGroupStartDate = new System.Windows.Forms.Label();
            this.tbxAddGroupName = new System.Windows.Forms.TextBox();
            this.cbxEducationPackage = new System.Windows.Forms.ComboBox();
            this.cbxGroupType = new System.Windows.Forms.ComboBox();
            this.cbxGroupLessonTime = new System.Windows.Forms.ComboBox();
            this.dtpGroupStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbxGroupTeacher = new System.Windows.Forms.ComboBox();
            this.lblGroupTeacher = new System.Windows.Forms.Label();
            this.cbxGroupMentor = new System.Windows.Forms.ComboBox();
            this.lblGroupMentor = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.gbxAddGroup = new System.Windows.Forms.GroupBox();
            this.btnShowAllTeachers = new System.Windows.Forms.Button();
            this.gbxSearchTeacher = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSearchByTeacherName = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxNewTeacher = new System.Windows.Forms.GroupBox();
            this.btnAddNewTeacher = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pbxTeacherPhoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.dgvTeachersList = new System.Windows.Forms.DataGridView();
            this.educationProjectDataSet2 = new EducationProject.EducationProjectDataSet2();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new EducationProject.EducationProjectDataSet2TableAdapters.TeachersTableAdapter();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAdmin.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxStudentAdd.SuspendLayout();
            this.gbxUpdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentUpdatePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).BeginInit();
            this.tabGroup.SuspendLayout();
            this.tabTeacher.SuspendLayout();
            this.gbxAddGroup.SuspendLayout();
            this.gbxSearchTeacher.SuspendLayout();
            this.gbxNewTeacher.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabStudent);
            this.tabControlAdmin.Controls.Add(this.tabGroup);
            this.tabControlAdmin.Controls.Add(this.tabTeacher);
            this.tabControlAdmin.Controls.Add(this.tabMentor);
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1224, 546);
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlAdmin_SelectedIndexChanged);
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.btnShowAllStudents);
            this.tabStudent.Controls.Add(this.groupBox1);
            this.tabStudent.Controls.Add(this.gbxStudentAdd);
            this.tabStudent.Controls.Add(this.gbxUpdateStudent);
            this.tabStudent.Controls.Add(this.lblStudents);
            this.tabStudent.Controls.Add(this.dgvStudentsList);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(1216, 520);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Students";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.AutoSize = true;
            this.btnShowAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAllStudents.Location = new System.Drawing.Point(1082, 8);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(121, 26);
            this.btnShowAllStudents.TabIndex = 26;
            this.btnShowAllStudents.Text = "Show all students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectEducationPackage);
            this.groupBox1.Controls.Add(this.cbxSelectGroupType);
            this.groupBox1.Controls.Add(this.cbxSelectGroupTime);
            this.groupBox1.Controls.Add(this.lblSearchByStudentName);
            this.groupBox1.Controls.Add(this.cbxSelectEducationPackage);
            this.groupBox1.Controls.Add(this.tbxSearchByName);
            this.groupBox1.Controls.Add(this.cbxSelectGroup);
            this.groupBox1.Controls.Add(this.lblSelectGroup);
            this.groupBox1.Controls.Add(this.lblSelectGroupType);
            this.groupBox1.Controls.Add(this.lblSelectGroupTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(866, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 269);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // lblSelectEducationPackage
            // 
            this.lblSelectEducationPackage.AutoSize = true;
            this.lblSelectEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectEducationPackage.Location = new System.Drawing.Point(6, 37);
            this.lblSelectEducationPackage.Name = "lblSelectEducationPackage";
            this.lblSelectEducationPackage.Size = new System.Drawing.Size(165, 16);
            this.lblSelectEducationPackage.TabIndex = 6;
            this.lblSelectEducationPackage.Text = "Select education package";
            // 
            // cbxSelectGroupType
            // 
            this.cbxSelectGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectGroupType.FormattingEnabled = true;
            this.cbxSelectGroupType.Location = new System.Drawing.Point(173, 61);
            this.cbxSelectGroupType.Name = "cbxSelectGroupType";
            this.cbxSelectGroupType.Size = new System.Drawing.Size(158, 24);
            this.cbxSelectGroupType.TabIndex = 2;
            this.cbxSelectGroupType.SelectedIndexChanged += new System.EventHandler(this.cbxSelectGroupType_SelectedIndexChanged);
            // 
            // cbxSelectGroupTime
            // 
            this.cbxSelectGroupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectGroupTime.FormattingEnabled = true;
            this.cbxSelectGroupTime.Location = new System.Drawing.Point(173, 88);
            this.cbxSelectGroupTime.Name = "cbxSelectGroupTime";
            this.cbxSelectGroupTime.Size = new System.Drawing.Size(158, 24);
            this.cbxSelectGroupTime.TabIndex = 3;
            // 
            // lblSearchByStudentName
            // 
            this.lblSearchByStudentName.AutoSize = true;
            this.lblSearchByStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchByStudentName.Location = new System.Drawing.Point(6, 157);
            this.lblSearchByStudentName.Name = "lblSearchByStudentName";
            this.lblSearchByStudentName.Size = new System.Drawing.Size(152, 16);
            this.lblSearchByStudentName.TabIndex = 11;
            this.lblSearchByStudentName.Text = "Search by student name";
            // 
            // cbxSelectEducationPackage
            // 
            this.cbxSelectEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectEducationPackage.FormattingEnabled = true;
            this.cbxSelectEducationPackage.Location = new System.Drawing.Point(173, 34);
            this.cbxSelectEducationPackage.Name = "cbxSelectEducationPackage";
            this.cbxSelectEducationPackage.Size = new System.Drawing.Size(158, 24);
            this.cbxSelectEducationPackage.TabIndex = 4;
            this.cbxSelectEducationPackage.SelectedIndexChanged += new System.EventHandler(this.cbxSelectEducationPackage_SelectedIndexChanged);
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearchByName.Location = new System.Drawing.Point(173, 154);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(158, 22);
            this.tbxSearchByName.TabIndex = 10;
            // 
            // cbxSelectGroup
            // 
            this.cbxSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectGroup.FormattingEnabled = true;
            this.cbxSelectGroup.Location = new System.Drawing.Point(173, 115);
            this.cbxSelectGroup.Name = "cbxSelectGroup";
            this.cbxSelectGroup.Size = new System.Drawing.Size(158, 24);
            this.cbxSelectGroup.TabIndex = 5;
            this.cbxSelectGroup.SelectedIndexChanged += new System.EventHandler(this.cbxSelectGroup_SelectedIndexChanged);
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectGroup.Location = new System.Drawing.Point(6, 118);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(84, 16);
            this.lblSelectGroup.TabIndex = 9;
            this.lblSelectGroup.Text = "Select group";
            // 
            // lblSelectGroupType
            // 
            this.lblSelectGroupType.AutoSize = true;
            this.lblSelectGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectGroupType.Location = new System.Drawing.Point(6, 64);
            this.lblSelectGroupType.Name = "lblSelectGroupType";
            this.lblSelectGroupType.Size = new System.Drawing.Size(113, 16);
            this.lblSelectGroupType.TabIndex = 7;
            this.lblSelectGroupType.Text = "Select group type";
            // 
            // lblSelectGroupTime
            // 
            this.lblSelectGroupTime.AutoSize = true;
            this.lblSelectGroupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectGroupTime.Location = new System.Drawing.Point(6, 91);
            this.lblSelectGroupTime.Name = "lblSelectGroupTime";
            this.lblSelectGroupTime.Size = new System.Drawing.Size(112, 16);
            this.lblSelectGroupTime.TabIndex = 8;
            this.lblSelectGroupTime.Text = "Select group time";
            // 
            // gbxStudentAdd
            // 
            this.gbxStudentAdd.Controls.Add(this.btnNewStudentAdd);
            this.gbxStudentAdd.Controls.Add(this.tbxNewStudentPhone);
            this.gbxStudentAdd.Controls.Add(this.tbxNewStudentEmail);
            this.gbxStudentAdd.Controls.Add(this.tbxNewStudentSurname);
            this.gbxStudentAdd.Controls.Add(this.tbxNewStudentName);
            this.gbxStudentAdd.Controls.Add(this.lblNewStudentEmail);
            this.gbxStudentAdd.Controls.Add(this.lblNewStudentPhone);
            this.gbxStudentAdd.Controls.Add(this.lblNewStudentSurname);
            this.gbxStudentAdd.Controls.Add(this.lblNewStudentName);
            this.gbxStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxStudentAdd.Location = new System.Drawing.Point(510, 238);
            this.gbxStudentAdd.Name = "gbxStudentAdd";
            this.gbxStudentAdd.Size = new System.Drawing.Size(350, 269);
            this.gbxStudentAdd.TabIndex = 26;
            this.gbxStudentAdd.TabStop = false;
            this.gbxStudentAdd.Text = "New student";
            // 
            // btnNewStudentAdd
            // 
            this.btnNewStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewStudentAdd.Location = new System.Drawing.Point(257, 172);
            this.btnNewStudentAdd.Name = "btnNewStudentAdd";
            this.btnNewStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewStudentAdd.TabIndex = 25;
            this.btnNewStudentAdd.Text = "Add";
            this.btnNewStudentAdd.UseVisualStyleBackColor = true;
            this.btnNewStudentAdd.Click += new System.EventHandler(this.btnNewStudentAdd_Click);
            // 
            // tbxNewStudentPhone
            // 
            this.tbxNewStudentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewStudentPhone.Location = new System.Drawing.Point(86, 124);
            this.tbxNewStudentPhone.Name = "tbxNewStudentPhone";
            this.tbxNewStudentPhone.Size = new System.Drawing.Size(246, 22);
            this.tbxNewStudentPhone.TabIndex = 24;
            // 
            // tbxNewStudentEmail
            // 
            this.tbxNewStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewStudentEmail.Location = new System.Drawing.Point(86, 96);
            this.tbxNewStudentEmail.Name = "tbxNewStudentEmail";
            this.tbxNewStudentEmail.Size = new System.Drawing.Size(246, 22);
            this.tbxNewStudentEmail.TabIndex = 23;
            // 
            // tbxNewStudentSurname
            // 
            this.tbxNewStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewStudentSurname.Location = new System.Drawing.Point(86, 65);
            this.tbxNewStudentSurname.Name = "tbxNewStudentSurname";
            this.tbxNewStudentSurname.Size = new System.Drawing.Size(246, 22);
            this.tbxNewStudentSurname.TabIndex = 22;
            // 
            // tbxNewStudentName
            // 
            this.tbxNewStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewStudentName.Location = new System.Drawing.Point(86, 37);
            this.tbxNewStudentName.Name = "tbxNewStudentName";
            this.tbxNewStudentName.Size = new System.Drawing.Size(246, 22);
            this.tbxNewStudentName.TabIndex = 21;
            // 
            // lblNewStudentEmail
            // 
            this.lblNewStudentEmail.AutoSize = true;
            this.lblNewStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewStudentEmail.Location = new System.Drawing.Point(6, 99);
            this.lblNewStudentEmail.Name = "lblNewStudentEmail";
            this.lblNewStudentEmail.Size = new System.Drawing.Size(48, 16);
            this.lblNewStudentEmail.TabIndex = 16;
            this.lblNewStudentEmail.Text = "Email :";
            // 
            // lblNewStudentPhone
            // 
            this.lblNewStudentPhone.AutoSize = true;
            this.lblNewStudentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewStudentPhone.Location = new System.Drawing.Point(6, 127);
            this.lblNewStudentPhone.Name = "lblNewStudentPhone";
            this.lblNewStudentPhone.Size = new System.Drawing.Size(53, 16);
            this.lblNewStudentPhone.TabIndex = 15;
            this.lblNewStudentPhone.Text = "Phone :";
            // 
            // lblNewStudentSurname
            // 
            this.lblNewStudentSurname.AutoSize = true;
            this.lblNewStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewStudentSurname.Location = new System.Drawing.Point(6, 68);
            this.lblNewStudentSurname.Name = "lblNewStudentSurname";
            this.lblNewStudentSurname.Size = new System.Drawing.Size(68, 16);
            this.lblNewStudentSurname.TabIndex = 14;
            this.lblNewStudentSurname.Text = "Surname :";
            // 
            // lblNewStudentName
            // 
            this.lblNewStudentName.AutoSize = true;
            this.lblNewStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewStudentName.Location = new System.Drawing.Point(6, 40);
            this.lblNewStudentName.Name = "lblNewStudentName";
            this.lblNewStudentName.Size = new System.Drawing.Size(51, 16);
            this.lblNewStudentName.TabIndex = 13;
            this.lblNewStudentName.Text = "Name :";
            // 
            // gbxUpdateStudent
            // 
            this.gbxUpdateStudent.Controls.Add(this.btnStudentUpdatePhoto);
            this.gbxUpdateStudent.Controls.Add(this.btnStudentRemove);
            this.gbxUpdateStudent.Controls.Add(this.tbxStudentUpdatePhone);
            this.gbxUpdateStudent.Controls.Add(this.tbxStudentUpdateEmail);
            this.gbxUpdateStudent.Controls.Add(this.tbxStudentUpdateSurname);
            this.gbxUpdateStudent.Controls.Add(this.tbxStudentUpdateName);
            this.gbxUpdateStudent.Controls.Add(this.rbxStudentUpdateBio);
            this.gbxUpdateStudent.Controls.Add(this.btnStudentUpdate);
            this.gbxUpdateStudent.Controls.Add(this.pbxStudentUpdatePhoto);
            this.gbxUpdateStudent.Controls.Add(this.lblStudetnUpdateBio);
            this.gbxUpdateStudent.Controls.Add(this.lblStudetnUpdateEmail);
            this.gbxUpdateStudent.Controls.Add(this.lblStudetnUpdatePhone);
            this.gbxUpdateStudent.Controls.Add(this.lblStudetnUpdateSurname);
            this.gbxUpdateStudent.Controls.Add(this.lblStudentUpdateName);
            this.gbxUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdateStudent.Location = new System.Drawing.Point(6, 238);
            this.gbxUpdateStudent.Name = "gbxUpdateStudent";
            this.gbxUpdateStudent.Size = new System.Drawing.Size(478, 269);
            this.gbxUpdateStudent.TabIndex = 12;
            this.gbxUpdateStudent.TabStop = false;
            this.gbxUpdateStudent.Text = "Update";
            // 
            // btnStudentUpdatePhoto
            // 
            this.btnStudentUpdatePhoto.AutoSize = true;
            this.btnStudentUpdatePhoto.Enabled = false;
            this.btnStudentUpdatePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentUpdatePhoto.Location = new System.Drawing.Point(346, 149);
            this.btnStudentUpdatePhoto.Name = "btnStudentUpdatePhoto";
            this.btnStudentUpdatePhoto.Size = new System.Drawing.Size(100, 26);
            this.btnStudentUpdatePhoto.TabIndex = 27;
            this.btnStudentUpdatePhoto.Text = "Update photo";
            this.btnStudentUpdatePhoto.UseVisualStyleBackColor = true;
            // 
            // btnStudentRemove
            // 
            this.btnStudentRemove.BackColor = System.Drawing.Color.Red;
            this.btnStudentRemove.Enabled = false;
            this.btnStudentRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentRemove.Location = new System.Drawing.Point(397, 240);
            this.btnStudentRemove.Name = "btnStudentRemove";
            this.btnStudentRemove.Size = new System.Drawing.Size(75, 23);
            this.btnStudentRemove.TabIndex = 25;
            this.btnStudentRemove.Text = "Remove";
            this.btnStudentRemove.UseVisualStyleBackColor = false;
            // 
            // tbxStudentUpdatePhone
            // 
            this.tbxStudentUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentUpdatePhone.Location = new System.Drawing.Point(86, 124);
            this.tbxStudentUpdatePhone.Name = "tbxStudentUpdatePhone";
            this.tbxStudentUpdatePhone.Size = new System.Drawing.Size(182, 22);
            this.tbxStudentUpdatePhone.TabIndex = 24;
            // 
            // tbxStudentUpdateEmail
            // 
            this.tbxStudentUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentUpdateEmail.Location = new System.Drawing.Point(86, 96);
            this.tbxStudentUpdateEmail.Name = "tbxStudentUpdateEmail";
            this.tbxStudentUpdateEmail.Size = new System.Drawing.Size(182, 22);
            this.tbxStudentUpdateEmail.TabIndex = 23;
            // 
            // tbxStudentUpdateSurname
            // 
            this.tbxStudentUpdateSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentUpdateSurname.Location = new System.Drawing.Point(86, 65);
            this.tbxStudentUpdateSurname.Name = "tbxStudentUpdateSurname";
            this.tbxStudentUpdateSurname.Size = new System.Drawing.Size(182, 22);
            this.tbxStudentUpdateSurname.TabIndex = 22;
            // 
            // tbxStudentUpdateName
            // 
            this.tbxStudentUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStudentUpdateName.Location = new System.Drawing.Point(86, 37);
            this.tbxStudentUpdateName.Name = "tbxStudentUpdateName";
            this.tbxStudentUpdateName.Size = new System.Drawing.Size(182, 22);
            this.tbxStudentUpdateName.TabIndex = 21;
            // 
            // rbxStudentUpdateBio
            // 
            this.rbxStudentUpdateBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxStudentUpdateBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbxStudentUpdateBio.Location = new System.Drawing.Point(6, 168);
            this.rbxStudentUpdateBio.Name = "rbxStudentUpdateBio";
            this.rbxStudentUpdateBio.Size = new System.Drawing.Size(262, 90);
            this.rbxStudentUpdateBio.TabIndex = 20;
            this.rbxStudentUpdateBio.Text = "";
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Enabled = false;
            this.btnStudentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentUpdate.Location = new System.Drawing.Point(316, 240);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentUpdate.TabIndex = 19;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // pbxStudentUpdatePhoto
            // 
            this.pbxStudentUpdatePhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxStudentUpdatePhoto.ErrorImage")));
            this.pbxStudentUpdatePhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudentUpdatePhoto.Image")));
            this.pbxStudentUpdatePhoto.Location = new System.Drawing.Point(346, 31);
            this.pbxStudentUpdatePhoto.Name = "pbxStudentUpdatePhoto";
            this.pbxStudentUpdatePhoto.Size = new System.Drawing.Size(100, 112);
            this.pbxStudentUpdatePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudentUpdatePhoto.TabIndex = 18;
            this.pbxStudentUpdatePhoto.TabStop = false;
            // 
            // lblStudetnUpdateBio
            // 
            this.lblStudetnUpdateBio.AutoSize = true;
            this.lblStudetnUpdateBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudetnUpdateBio.Location = new System.Drawing.Point(6, 149);
            this.lblStudetnUpdateBio.Name = "lblStudetnUpdateBio";
            this.lblStudetnUpdateBio.Size = new System.Drawing.Size(34, 16);
            this.lblStudetnUpdateBio.TabIndex = 17;
            this.lblStudetnUpdateBio.Text = "Bio :";
            // 
            // lblStudetnUpdateEmail
            // 
            this.lblStudetnUpdateEmail.AutoSize = true;
            this.lblStudetnUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudetnUpdateEmail.Location = new System.Drawing.Point(6, 99);
            this.lblStudetnUpdateEmail.Name = "lblStudetnUpdateEmail";
            this.lblStudetnUpdateEmail.Size = new System.Drawing.Size(48, 16);
            this.lblStudetnUpdateEmail.TabIndex = 16;
            this.lblStudetnUpdateEmail.Text = "Email :";
            // 
            // lblStudetnUpdatePhone
            // 
            this.lblStudetnUpdatePhone.AutoSize = true;
            this.lblStudetnUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudetnUpdatePhone.Location = new System.Drawing.Point(6, 127);
            this.lblStudetnUpdatePhone.Name = "lblStudetnUpdatePhone";
            this.lblStudetnUpdatePhone.Size = new System.Drawing.Size(53, 16);
            this.lblStudetnUpdatePhone.TabIndex = 15;
            this.lblStudetnUpdatePhone.Text = "Phone :";
            // 
            // lblStudetnUpdateSurname
            // 
            this.lblStudetnUpdateSurname.AutoSize = true;
            this.lblStudetnUpdateSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudetnUpdateSurname.Location = new System.Drawing.Point(6, 68);
            this.lblStudetnUpdateSurname.Name = "lblStudetnUpdateSurname";
            this.lblStudetnUpdateSurname.Size = new System.Drawing.Size(68, 16);
            this.lblStudetnUpdateSurname.TabIndex = 14;
            this.lblStudetnUpdateSurname.Text = "Surname :";
            // 
            // lblStudentUpdateName
            // 
            this.lblStudentUpdateName.AutoSize = true;
            this.lblStudentUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentUpdateName.Location = new System.Drawing.Point(6, 40);
            this.lblStudentUpdateName.Name = "lblStudentUpdateName";
            this.lblStudentUpdateName.Size = new System.Drawing.Size(51, 16);
            this.lblStudentUpdateName.TabIndex = 13;
            this.lblStudentUpdateName.Text = "Name :";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudents.Location = new System.Drawing.Point(8, 12);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(105, 25);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students";
            // 
            // dgvStudentsList
            // 
            this.dgvStudentsList.AutoGenerateColumns = false;
            this.dgvStudentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentEmailDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentBirthDateDataGridViewTextBoxColumn,
            this.studentRegistrationDateDataGridViewTextBoxColumn,
            this.studentBioDataGridViewTextBoxColumn,
            this.StudentPhoto,
            this.StudentId});
            this.dgvStudentsList.DataSource = this.studentsBindingSource;
            this.dgvStudentsList.Location = new System.Drawing.Point(6, 40);
            this.dgvStudentsList.Name = "dgvStudentsList";
            this.dgvStudentsList.Size = new System.Drawing.Size(1197, 191);
            this.dgvStudentsList.TabIndex = 0;
            this.dgvStudentsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsList_CellClick);
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            // 
            // studentBirthDateDataGridViewTextBoxColumn
            // 
            this.studentBirthDateDataGridViewTextBoxColumn.DataPropertyName = "StudentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.studentBirthDateDataGridViewTextBoxColumn.Name = "studentBirthDateDataGridViewTextBoxColumn";
            // 
            // studentRegistrationDateDataGridViewTextBoxColumn
            // 
            this.studentRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "StudentRegistrationDate";
            this.studentRegistrationDateDataGridViewTextBoxColumn.HeaderText = "Registration date";
            this.studentRegistrationDateDataGridViewTextBoxColumn.Name = "studentRegistrationDateDataGridViewTextBoxColumn";
            // 
            // studentBioDataGridViewTextBoxColumn
            // 
            this.studentBioDataGridViewTextBoxColumn.DataPropertyName = "StudentBio";
            this.studentBioDataGridViewTextBoxColumn.HeaderText = "Bio";
            this.studentBioDataGridViewTextBoxColumn.Name = "studentBioDataGridViewTextBoxColumn";
            // 
            // StudentPhoto
            // 
            this.StudentPhoto.DataPropertyName = "StudentPhoto";
            this.StudentPhoto.HeaderText = "StudentPhoto";
            this.StudentPhoto.Name = "StudentPhoto";
            this.StudentPhoto.Visible = false;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
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
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.gbxAddGroup);
            this.tabGroup.Location = new System.Drawing.Point(4, 22);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroup.Size = new System.Drawing.Size(1216, 520);
            this.tabGroup.TabIndex = 1;
            this.tabGroup.Text = "Groups";
            this.tabGroup.UseVisualStyleBackColor = true;
            // 
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.btnShowAllTeachers);
            this.tabTeacher.Controls.Add(this.gbxSearchTeacher);
            this.tabTeacher.Controls.Add(this.gbxNewTeacher);
            this.tabTeacher.Controls.Add(this.groupBox4);
            this.tabTeacher.Controls.Add(this.lblTeachers);
            this.tabTeacher.Controls.Add(this.dgvTeachersList);
            this.tabTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Size = new System.Drawing.Size(1216, 520);
            this.tabTeacher.TabIndex = 2;
            this.tabTeacher.Text = "Teachers";
            this.tabTeacher.UseVisualStyleBackColor = true;
            // 
            // tabMentor
            // 
            this.tabMentor.Location = new System.Drawing.Point(4, 22);
            this.tabMentor.Name = "tabMentor";
            this.tabMentor.Size = new System.Drawing.Size(1216, 520);
            this.tabMentor.TabIndex = 3;
            this.tabMentor.Text = "Mentors";
            this.tabMentor.UseVisualStyleBackColor = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // lblAddGroupName
            // 
            this.lblAddGroupName.AutoSize = true;
            this.lblAddGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddGroupName.Location = new System.Drawing.Point(6, 27);
            this.lblAddGroupName.Name = "lblAddGroupName";
            this.lblAddGroupName.Size = new System.Drawing.Size(45, 16);
            this.lblAddGroupName.TabIndex = 1;
            this.lblAddGroupName.Text = "Name";
            // 
            // lblAddGroupEducationPackage
            // 
            this.lblAddGroupEducationPackage.AutoSize = true;
            this.lblAddGroupEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddGroupEducationPackage.Location = new System.Drawing.Point(7, 53);
            this.lblAddGroupEducationPackage.Name = "lblAddGroupEducationPackage";
            this.lblAddGroupEducationPackage.Size = new System.Drawing.Size(125, 16);
            this.lblAddGroupEducationPackage.TabIndex = 2;
            this.lblAddGroupEducationPackage.Text = "Education package";
            // 
            // lblAddGroupType
            // 
            this.lblAddGroupType.AutoSize = true;
            this.lblAddGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddGroupType.Location = new System.Drawing.Point(7, 80);
            this.lblAddGroupType.Name = "lblAddGroupType";
            this.lblAddGroupType.Size = new System.Drawing.Size(74, 16);
            this.lblAddGroupType.TabIndex = 3;
            this.lblAddGroupType.Text = "Group type";
            // 
            // lblAddGroupLessonTime
            // 
            this.lblAddGroupLessonTime.AutoSize = true;
            this.lblAddGroupLessonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddGroupLessonTime.Location = new System.Drawing.Point(6, 107);
            this.lblAddGroupLessonTime.Name = "lblAddGroupLessonTime";
            this.lblAddGroupLessonTime.Size = new System.Drawing.Size(116, 16);
            this.lblAddGroupLessonTime.TabIndex = 4;
            this.lblAddGroupLessonTime.Text = "Group lesson time";
            // 
            // lblAddGroupStartDate
            // 
            this.lblAddGroupStartDate.AutoSize = true;
            this.lblAddGroupStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddGroupStartDate.Location = new System.Drawing.Point(6, 137);
            this.lblAddGroupStartDate.Name = "lblAddGroupStartDate";
            this.lblAddGroupStartDate.Size = new System.Drawing.Size(65, 16);
            this.lblAddGroupStartDate.TabIndex = 5;
            this.lblAddGroupStartDate.Text = "Start date";
            // 
            // tbxAddGroupName
            // 
            this.tbxAddGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddGroupName.Location = new System.Drawing.Point(138, 24);
            this.tbxAddGroupName.Name = "tbxAddGroupName";
            this.tbxAddGroupName.Size = new System.Drawing.Size(250, 22);
            this.tbxAddGroupName.TabIndex = 6;
            // 
            // cbxEducationPackage
            // 
            this.cbxEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxEducationPackage.FormattingEnabled = true;
            this.cbxEducationPackage.Location = new System.Drawing.Point(138, 50);
            this.cbxEducationPackage.Name = "cbxEducationPackage";
            this.cbxEducationPackage.Size = new System.Drawing.Size(250, 24);
            this.cbxEducationPackage.TabIndex = 7;
            // 
            // cbxGroupType
            // 
            this.cbxGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupType.FormattingEnabled = true;
            this.cbxGroupType.Location = new System.Drawing.Point(138, 77);
            this.cbxGroupType.Name = "cbxGroupType";
            this.cbxGroupType.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupType.TabIndex = 8;
            // 
            // cbxGroupLessonTime
            // 
            this.cbxGroupLessonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupLessonTime.FormattingEnabled = true;
            this.cbxGroupLessonTime.Location = new System.Drawing.Point(138, 104);
            this.cbxGroupLessonTime.Name = "cbxGroupLessonTime";
            this.cbxGroupLessonTime.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupLessonTime.TabIndex = 9;
            // 
            // dtpGroupStartDate
            // 
            this.dtpGroupStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpGroupStartDate.Location = new System.Drawing.Point(138, 131);
            this.dtpGroupStartDate.Name = "dtpGroupStartDate";
            this.dtpGroupStartDate.Size = new System.Drawing.Size(250, 22);
            this.dtpGroupStartDate.TabIndex = 10;
            // 
            // cbxGroupTeacher
            // 
            this.cbxGroupTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupTeacher.FormattingEnabled = true;
            this.cbxGroupTeacher.Location = new System.Drawing.Point(138, 157);
            this.cbxGroupTeacher.Name = "cbxGroupTeacher";
            this.cbxGroupTeacher.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupTeacher.TabIndex = 12;
            // 
            // lblGroupTeacher
            // 
            this.lblGroupTeacher.AutoSize = true;
            this.lblGroupTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupTeacher.Location = new System.Drawing.Point(6, 160);
            this.lblGroupTeacher.Name = "lblGroupTeacher";
            this.lblGroupTeacher.Size = new System.Drawing.Size(93, 16);
            this.lblGroupTeacher.TabIndex = 11;
            this.lblGroupTeacher.Text = "Group teacher";
            // 
            // cbxGroupMentor
            // 
            this.cbxGroupMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupMentor.FormattingEnabled = true;
            this.cbxGroupMentor.Location = new System.Drawing.Point(138, 184);
            this.cbxGroupMentor.Name = "cbxGroupMentor";
            this.cbxGroupMentor.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupMentor.TabIndex = 14;
            // 
            // lblGroupMentor
            // 
            this.lblGroupMentor.AutoSize = true;
            this.lblGroupMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupMentor.Location = new System.Drawing.Point(6, 187);
            this.lblGroupMentor.Name = "lblGroupMentor";
            this.lblGroupMentor.Size = new System.Drawing.Size(89, 16);
            this.lblGroupMentor.TabIndex = 13;
            this.lblGroupMentor.Text = "Group mentor";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AutoSize = true;
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddGroup.Location = new System.Drawing.Point(292, 214);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(96, 26);
            this.btnAddGroup.TabIndex = 15;
            this.btnAddGroup.Text = "Create group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // gbxAddGroup
            // 
            this.gbxAddGroup.Controls.Add(this.lblAddGroupEducationPackage);
            this.gbxAddGroup.Controls.Add(this.btnAddGroup);
            this.gbxAddGroup.Controls.Add(this.lblAddGroupName);
            this.gbxAddGroup.Controls.Add(this.cbxGroupMentor);
            this.gbxAddGroup.Controls.Add(this.lblAddGroupType);
            this.gbxAddGroup.Controls.Add(this.lblGroupMentor);
            this.gbxAddGroup.Controls.Add(this.lblAddGroupLessonTime);
            this.gbxAddGroup.Controls.Add(this.cbxGroupTeacher);
            this.gbxAddGroup.Controls.Add(this.lblAddGroupStartDate);
            this.gbxAddGroup.Controls.Add(this.lblGroupTeacher);
            this.gbxAddGroup.Controls.Add(this.tbxAddGroupName);
            this.gbxAddGroup.Controls.Add(this.dtpGroupStartDate);
            this.gbxAddGroup.Controls.Add(this.cbxEducationPackage);
            this.gbxAddGroup.Controls.Add(this.cbxGroupLessonTime);
            this.gbxAddGroup.Controls.Add(this.cbxGroupType);
            this.gbxAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAddGroup.Location = new System.Drawing.Point(8, 6);
            this.gbxAddGroup.Name = "gbxAddGroup";
            this.gbxAddGroup.Size = new System.Drawing.Size(394, 246);
            this.gbxAddGroup.TabIndex = 16;
            this.gbxAddGroup.TabStop = false;
            this.gbxAddGroup.Text = "Add group";
            // 
            // btnShowAllTeachers
            // 
            this.btnShowAllTeachers.AutoSize = true;
            this.btnShowAllTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAllTeachers.Location = new System.Drawing.Point(1082, 6);
            this.btnShowAllTeachers.Name = "btnShowAllTeachers";
            this.btnShowAllTeachers.Size = new System.Drawing.Size(123, 26);
            this.btnShowAllTeachers.TabIndex = 31;
            this.btnShowAllTeachers.Text = "Show all teachers";
            this.btnShowAllTeachers.UseVisualStyleBackColor = true;
            // 
            // gbxSearchTeacher
            // 
            this.gbxSearchTeacher.Controls.Add(this.label1);
            this.gbxSearchTeacher.Controls.Add(this.comboBox1);
            this.gbxSearchTeacher.Controls.Add(this.comboBox2);
            this.gbxSearchTeacher.Controls.Add(this.lblSearchByTeacherName);
            this.gbxSearchTeacher.Controls.Add(this.comboBox3);
            this.gbxSearchTeacher.Controls.Add(this.textBox1);
            this.gbxSearchTeacher.Controls.Add(this.comboBox4);
            this.gbxSearchTeacher.Controls.Add(this.label3);
            this.gbxSearchTeacher.Controls.Add(this.label4);
            this.gbxSearchTeacher.Controls.Add(this.label5);
            this.gbxSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearchTeacher.Location = new System.Drawing.Point(866, 236);
            this.gbxSearchTeacher.Name = "gbxSearchTeacher";
            this.gbxSearchTeacher.Size = new System.Drawing.Size(337, 269);
            this.gbxSearchTeacher.TabIndex = 33;
            this.gbxSearchTeacher.TabStop = false;
            this.gbxSearchTeacher.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select education package";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // lblSearchByTeacherName
            // 
            this.lblSearchByTeacherName.AutoSize = true;
            this.lblSearchByTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchByTeacherName.Location = new System.Drawing.Point(6, 157);
            this.lblSearchByTeacherName.Name = "lblSearchByTeacherName";
            this.lblSearchByTeacherName.Size = new System.Drawing.Size(154, 16);
            this.lblSearchByTeacherName.TabIndex = 11;
            this.lblSearchByTeacherName.Text = "Search by teacher name";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(173, 34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(173, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(173, 115);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(158, 24);
            this.comboBox4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select group type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select group time";
            // 
            // gbxNewTeacher
            // 
            this.gbxNewTeacher.Controls.Add(this.btnAddNewTeacher);
            this.gbxNewTeacher.Controls.Add(this.textBox2);
            this.gbxNewTeacher.Controls.Add(this.textBox3);
            this.gbxNewTeacher.Controls.Add(this.textBox4);
            this.gbxNewTeacher.Controls.Add(this.textBox5);
            this.gbxNewTeacher.Controls.Add(this.label6);
            this.gbxNewTeacher.Controls.Add(this.label7);
            this.gbxNewTeacher.Controls.Add(this.label8);
            this.gbxNewTeacher.Controls.Add(this.label9);
            this.gbxNewTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxNewTeacher.Location = new System.Drawing.Point(510, 236);
            this.gbxNewTeacher.Name = "gbxNewTeacher";
            this.gbxNewTeacher.Size = new System.Drawing.Size(350, 269);
            this.gbxNewTeacher.TabIndex = 32;
            this.gbxNewTeacher.TabStop = false;
            this.gbxNewTeacher.Text = "New teacher";
            // 
            // btnAddNewTeacher
            // 
            this.btnAddNewTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTeacher.Location = new System.Drawing.Point(257, 172);
            this.btnAddNewTeacher.Name = "btnAddNewTeacher";
            this.btnAddNewTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTeacher.TabIndex = 25;
            this.btnAddNewTeacher.Text = "Add";
            this.btnAddNewTeacher.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(86, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(86, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 22);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(86, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 22);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(86, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 22);
            this.textBox5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Surname :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.pbxTeacherPhoto);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(6, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 269);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(346, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 27;
            this.button3.Text = "Update photo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(397, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(86, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 22);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(86, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(182, 22);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(86, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(182, 22);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(86, 37);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(182, 22);
            this.textBox9.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 90);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(316, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pbxTeacherPhoto
            // 
            this.pbxTeacherPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxTeacherPhoto.ErrorImage")));
            this.pbxTeacherPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxTeacherPhoto.Image")));
            this.pbxTeacherPhoto.Location = new System.Drawing.Point(346, 31);
            this.pbxTeacherPhoto.Name = "pbxTeacherPhoto";
            this.pbxTeacherPhoto.Size = new System.Drawing.Size(100, 112);
            this.pbxTeacherPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTeacherPhoto.TabIndex = 18;
            this.pbxTeacherPhoto.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Bio :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Email :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Phone :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Surname :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Name :";
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeachers.Location = new System.Drawing.Point(8, 10);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(110, 25);
            this.lblTeachers.TabIndex = 29;
            this.lblTeachers.Text = "Teachers";
            // 
            // dgvTeachersList
            // 
            this.dgvTeachersList.AutoGenerateColumns = false;
            this.dgvTeachersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIdDataGridViewTextBoxColumn,
            this.programIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.teacherSurnameDataGridViewTextBoxColumn,
            this.teacherEmailDataGridViewTextBoxColumn,
            this.teacherPhoneDataGridViewTextBoxColumn,
            this.teacherPhotoDataGridViewTextBoxColumn,
            this.teacherBioDataGridViewTextBoxColumn});
            this.dgvTeachersList.DataSource = this.teachersBindingSource;
            this.dgvTeachersList.Location = new System.Drawing.Point(6, 38);
            this.dgvTeachersList.Name = "dgvTeachersList";
            this.dgvTeachersList.Size = new System.Drawing.Size(1197, 191);
            this.dgvTeachersList.TabIndex = 28;
            // 
            // educationProjectDataSet2
            // 
            this.educationProjectDataSet2.DataSetName = "EducationProjectDataSet2";
            this.educationProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.educationProjectDataSet2;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // programIdDataGridViewTextBoxColumn
            // 
            this.programIdDataGridViewTextBoxColumn.DataPropertyName = "ProgramId";
            this.programIdDataGridViewTextBoxColumn.HeaderText = "ProgramId";
            this.programIdDataGridViewTextBoxColumn.Name = "programIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            // 
            // teacherSurnameDataGridViewTextBoxColumn
            // 
            this.teacherSurnameDataGridViewTextBoxColumn.DataPropertyName = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.HeaderText = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.Name = "teacherSurnameDataGridViewTextBoxColumn";
            // 
            // teacherEmailDataGridViewTextBoxColumn
            // 
            this.teacherEmailDataGridViewTextBoxColumn.DataPropertyName = "TeacherEmail";
            this.teacherEmailDataGridViewTextBoxColumn.HeaderText = "TeacherEmail";
            this.teacherEmailDataGridViewTextBoxColumn.Name = "teacherEmailDataGridViewTextBoxColumn";
            // 
            // teacherPhoneDataGridViewTextBoxColumn
            // 
            this.teacherPhoneDataGridViewTextBoxColumn.DataPropertyName = "TeacherPhone";
            this.teacherPhoneDataGridViewTextBoxColumn.HeaderText = "TeacherPhone";
            this.teacherPhoneDataGridViewTextBoxColumn.Name = "teacherPhoneDataGridViewTextBoxColumn";
            // 
            // teacherPhotoDataGridViewTextBoxColumn
            // 
            this.teacherPhotoDataGridViewTextBoxColumn.DataPropertyName = "TeacherPhoto";
            this.teacherPhotoDataGridViewTextBoxColumn.HeaderText = "TeacherPhoto";
            this.teacherPhotoDataGridViewTextBoxColumn.Name = "teacherPhotoDataGridViewTextBoxColumn";
            // 
            // teacherBioDataGridViewTextBoxColumn
            // 
            this.teacherBioDataGridViewTextBoxColumn.DataPropertyName = "TeacherBio";
            this.teacherBioDataGridViewTextBoxColumn.HeaderText = "TeacherBio";
            this.teacherBioDataGridViewTextBoxColumn.Name = "teacherBioDataGridViewTextBoxColumn";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 541);
            this.Controls.Add(this.tabControlAdmin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1235, 580);
            this.MinimumSize = new System.Drawing.Size(1235, 580);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxStudentAdd.ResumeLayout(false);
            this.gbxStudentAdd.PerformLayout();
            this.gbxUpdateStudent.ResumeLayout(false);
            this.gbxUpdateStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentUpdatePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).EndInit();
            this.tabGroup.ResumeLayout(false);
            this.tabTeacher.ResumeLayout(false);
            this.tabTeacher.PerformLayout();
            this.gbxAddGroup.ResumeLayout(false);
            this.gbxAddGroup.PerformLayout();
            this.gbxSearchTeacher.ResumeLayout(false);
            this.gbxSearchTeacher.PerformLayout();
            this.gbxNewTeacher.ResumeLayout(false);
            this.gbxNewTeacher.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeacherPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabGroup;
        private System.Windows.Forms.TabPage tabTeacher;
        private System.Windows.Forms.TabPage tabMentor;
        private System.Windows.Forms.DataGridView dgvStudentsList;
        private EducationProjectDataSet1 educationProjectDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EducationProjectDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.GroupBox gbxUpdateStudent;
        private System.Windows.Forms.TextBox tbxStudentUpdatePhone;
        private System.Windows.Forms.TextBox tbxStudentUpdateEmail;
        private System.Windows.Forms.TextBox tbxStudentUpdateSurname;
        private System.Windows.Forms.TextBox tbxStudentUpdateName;
        private System.Windows.Forms.RichTextBox rbxStudentUpdateBio;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.PictureBox pbxStudentUpdatePhoto;
        private System.Windows.Forms.Label lblStudetnUpdateBio;
        private System.Windows.Forms.Label lblStudetnUpdateEmail;
        private System.Windows.Forms.Label lblStudetnUpdatePhone;
        private System.Windows.Forms.Label lblStudetnUpdateSurname;
        private System.Windows.Forms.Label lblStudentUpdateName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectEducationPackage;
        private System.Windows.Forms.ComboBox cbxSelectGroupType;
        private System.Windows.Forms.ComboBox cbxSelectGroupTime;
        private System.Windows.Forms.Label lblSearchByStudentName;
        private System.Windows.Forms.ComboBox cbxSelectEducationPackage;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.ComboBox cbxSelectGroup;
        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.Label lblSelectGroupType;
        private System.Windows.Forms.Label lblSelectGroupTime;
        private System.Windows.Forms.GroupBox gbxStudentAdd;
        private System.Windows.Forms.Button btnNewStudentAdd;
        private System.Windows.Forms.TextBox tbxNewStudentPhone;
        private System.Windows.Forms.TextBox tbxNewStudentEmail;
        private System.Windows.Forms.TextBox tbxNewStudentSurname;
        private System.Windows.Forms.TextBox tbxNewStudentName;
        private System.Windows.Forms.Label lblNewStudentEmail;
        private System.Windows.Forms.Label lblNewStudentPhone;
        private System.Windows.Forms.Label lblNewStudentSurname;
        private System.Windows.Forms.Label lblNewStudentName;
        private System.Windows.Forms.Button btnStudentRemove;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.Button btnStudentUpdatePhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.GroupBox gbxAddGroup;
        private System.Windows.Forms.Label lblAddGroupEducationPackage;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label lblAddGroupName;
        private System.Windows.Forms.ComboBox cbxGroupMentor;
        private System.Windows.Forms.Label lblAddGroupType;
        private System.Windows.Forms.Label lblGroupMentor;
        private System.Windows.Forms.Label lblAddGroupLessonTime;
        private System.Windows.Forms.ComboBox cbxGroupTeacher;
        private System.Windows.Forms.Label lblAddGroupStartDate;
        private System.Windows.Forms.Label lblGroupTeacher;
        private System.Windows.Forms.TextBox tbxAddGroupName;
        private System.Windows.Forms.DateTimePicker dtpGroupStartDate;
        private System.Windows.Forms.ComboBox cbxEducationPackage;
        private System.Windows.Forms.ComboBox cbxGroupLessonTime;
        private System.Windows.Forms.ComboBox cbxGroupType;
        private System.Windows.Forms.Button btnShowAllTeachers;
        private System.Windows.Forms.GroupBox gbxSearchTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSearchByTeacherName;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxNewTeacher;
        private System.Windows.Forms.Button btnAddNewTeacher;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pbxTeacherPhoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.DataGridView dgvTeachersList;
        private EducationProjectDataSet2 educationProjectDataSet2;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private EducationProjectDataSet2TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherBioDataGridViewTextBoxColumn;
    }
}