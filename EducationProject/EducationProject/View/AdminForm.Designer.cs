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
            this.lblSearchByStudentName = new System.Windows.Forms.Label();
            this.cbxSelectEducationPackage = new System.Windows.Forms.ComboBox();
            this.tbxSearchStudentByName = new System.Windows.Forms.TextBox();
            this.cbxSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectGroup = new System.Windows.Forms.Label();
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
            this.dgvGroupsList = new System.Windows.Forms.DataGridView();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet3 = new EducationProject.EducationProjectDataSet3();
            this.gbxUpdateGroup = new System.Windows.Forms.GroupBox();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.lblUpdateGroupStartDate = new System.Windows.Forms.Label();
            this.tbxUpdateGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupUpdateName = new System.Windows.Forms.Label();
            this.lblGroupUpdateGroupType = new System.Windows.Forms.Label();
            this.lblGroupUpdateMentor = new System.Windows.Forms.Label();
            this.lblGroupUpdateTeacher = new System.Windows.Forms.Label();
            this.cbxUpdateGroupGroupType = new System.Windows.Forms.ComboBox();
            this.cbxUpdateGroupMentor = new System.Windows.Forms.ComboBox();
            this.cbxUpdateGroupTeacher = new System.Windows.Forms.ComboBox();
            this.lblGroupUpdateProgramId = new System.Windows.Forms.Label();
            this.cbxUpdateGroupProgramId = new System.Windows.Forms.ComboBox();
            this.cbxSelectWhicGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectWhichGroup = new System.Windows.Forms.Label();
            this.btnAddStudentToGroup = new System.Windows.Forms.Button();
            this.dgvStudentsToGroup = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAddGroup = new System.Windows.Forms.GroupBox();
            this.lblAddGroupEducationPackage = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.lblAddGroupName = new System.Windows.Forms.Label();
            this.cbxGroupMentor = new System.Windows.Forms.ComboBox();
            this.lblAddGroupType = new System.Windows.Forms.Label();
            this.lblGroupMentor = new System.Windows.Forms.Label();
            this.lblAddGroupLessonTime = new System.Windows.Forms.Label();
            this.cbxGroupTeacher = new System.Windows.Forms.ComboBox();
            this.lblAddGroupStartDate = new System.Windows.Forms.Label();
            this.lblGroupTeacher = new System.Windows.Forms.Label();
            this.tbxAddGroupName = new System.Windows.Forms.TextBox();
            this.dtpGroupStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbxEducationPackage = new System.Windows.Forms.ComboBox();
            this.cbxGroupLessonTime = new System.Windows.Forms.ComboBox();
            this.cbxGroupType = new System.Windows.Forms.ComboBox();
            this.tabTeacher = new System.Windows.Forms.TabPage();
            this.btnShowAllTeachers = new System.Windows.Forms.Button();
            this.gbxSearchTeacher = new System.Windows.Forms.GroupBox();
            this.lblSearchEducationPackage = new System.Windows.Forms.Label();
            this.lblSearchByTeacherName = new System.Windows.Forms.Label();
            this.cbxSearchTeacherEducationPackage = new System.Windows.Forms.ComboBox();
            this.tbxSearchTeacherByName = new System.Windows.Forms.TextBox();
            this.cbxSearchTeacherGroup = new System.Windows.Forms.ComboBox();
            this.lblSearchGroup = new System.Windows.Forms.Label();
            this.gbxNewTeacher = new System.Windows.Forms.GroupBox();
            this.lblNewTeacherEducationPackage = new System.Windows.Forms.Label();
            this.cbxNewTeacherEducationPackage = new System.Windows.Forms.ComboBox();
            this.btnAddNewTeacher = new System.Windows.Forms.Button();
            this.tbxNewTeacherPhone = new System.Windows.Forms.TextBox();
            this.tbxNewTeacherEmail = new System.Windows.Forms.TextBox();
            this.tbxNewTeacherSurname = new System.Windows.Forms.TextBox();
            this.tbxNewTeacherName = new System.Windows.Forms.TextBox();
            this.lblNewTeacherEmail = new System.Windows.Forms.Label();
            this.lblNewTeacherPhone = new System.Windows.Forms.Label();
            this.lblNewTeacherSurname = new System.Windows.Forms.Label();
            this.lblNewTeacherName = new System.Windows.Forms.Label();
            this.gbxTeacherUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateTeacherPhoto = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.tbxUpdateTeacherPhone = new System.Windows.Forms.TextBox();
            this.tbxUpdateTeacherEmail = new System.Windows.Forms.TextBox();
            this.tbxUpdateTeacherSurname = new System.Windows.Forms.TextBox();
            this.tbxUpdateTeacherName = new System.Windows.Forms.TextBox();
            this.rbxUpdateTeacherBio = new System.Windows.Forms.RichTextBox();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.pbxUpdateTeacherPhoto = new System.Windows.Forms.PictureBox();
            this.lblUpdateTeacherBio = new System.Windows.Forms.Label();
            this.lblUpdateTeacherEmail = new System.Windows.Forms.Label();
            this.lblUpdateTeacherPhone = new System.Windows.Forms.Label();
            this.lblUpdateTeacherSurname = new System.Windows.Forms.Label();
            this.lblUpdateTeacherName = new System.Windows.Forms.Label();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.dgvTeachersList = new System.Windows.Forms.DataGridView();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet2 = new EducationProject.EducationProjectDataSet2();
            this.tabMentor = new System.Windows.Forms.TabPage();
            this.btnShowAllMentors = new System.Windows.Forms.Button();
            this.gbxSearchMentor = new System.Windows.Forms.GroupBox();
            this.lblSearchMentorEducationPackage = new System.Windows.Forms.Label();
            this.lblSearchMentorByName = new System.Windows.Forms.Label();
            this.cbxSearchMentorEducationPackage = new System.Windows.Forms.ComboBox();
            this.tbxSearchMentorByName = new System.Windows.Forms.TextBox();
            this.cbxSearchMentorGroup = new System.Windows.Forms.ComboBox();
            this.lblSearchMentorGroup = new System.Windows.Forms.Label();
            this.gbxNewMentor = new System.Windows.Forms.GroupBox();
            this.lblNewMentorEducationPackage = new System.Windows.Forms.Label();
            this.cbxNewMentorEducationPackage = new System.Windows.Forms.ComboBox();
            this.btnAddNewMentor = new System.Windows.Forms.Button();
            this.tbxNewMentorPhone = new System.Windows.Forms.TextBox();
            this.tbxNewMentorEmail = new System.Windows.Forms.TextBox();
            this.tbxNewMentorSurname = new System.Windows.Forms.TextBox();
            this.tbxNewMentorName = new System.Windows.Forms.TextBox();
            this.lblNewMentorEmail = new System.Windows.Forms.Label();
            this.lblNewMentorPhone = new System.Windows.Forms.Label();
            this.lblNewMentorSurname = new System.Windows.Forms.Label();
            this.lblNewMentorName = new System.Windows.Forms.Label();
            this.gbxUpdateMentor = new System.Windows.Forms.GroupBox();
            this.btnUpdateMentorPhoto = new System.Windows.Forms.Button();
            this.btnRemoveMentor = new System.Windows.Forms.Button();
            this.tbxUpdateMentorPhone = new System.Windows.Forms.TextBox();
            this.tbxUpdateMentorEmail = new System.Windows.Forms.TextBox();
            this.tbxUpdateMentorSurname = new System.Windows.Forms.TextBox();
            this.tbxUpdateMentorName = new System.Windows.Forms.TextBox();
            this.rbxUpdateMentorBio = new System.Windows.Forms.RichTextBox();
            this.btnUpdateMentor = new System.Windows.Forms.Button();
            this.pbxUpdateMentorPhoto = new System.Windows.Forms.PictureBox();
            this.lblUpdateMentorBio = new System.Windows.Forms.Label();
            this.lblUpdateMentorEmail = new System.Windows.Forms.Label();
            this.lblUpdateMentorPhone = new System.Windows.Forms.Label();
            this.lblUpdateMentorSurname = new System.Windows.Forms.Label();
            this.lblUpdateMentorName = new System.Windows.Forms.Label();
            this.lblMentors = new System.Windows.Forms.Label();
            this.dgvMentorsList = new System.Windows.Forms.DataGridView();
            this.mentorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet4 = new EducationProject.EducationProjectDataSet4();
            this.studentsTableAdapter = new EducationProject.EducationProjectDataSet1TableAdapters.StudentsTableAdapter();
            this.teachersTableAdapter = new EducationProject.EducationProjectDataSet2TableAdapters.TeachersTableAdapter();
            this.groupsTableAdapter = new EducationProject.EducationProjectDataSet3TableAdapters.GroupsTableAdapter();
            this.mentorsTableAdapter = new EducationProject.EducationProjectDataSet4TableAdapters.MentorsTableAdapter();
            this.dtpUpdateGroupStartDate = new System.Windows.Forms.DateTimePicker();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorBio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet3)).BeginInit();
            this.gbxUpdateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsToGroup)).BeginInit();
            this.gbxAddGroup.SuspendLayout();
            this.tabTeacher.SuspendLayout();
            this.gbxSearchTeacher.SuspendLayout();
            this.gbxNewTeacher.SuspendLayout();
            this.gbxTeacherUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdateTeacherPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).BeginInit();
            this.tabMentor.SuspendLayout();
            this.gbxSearchMentor.SuspendLayout();
            this.gbxNewMentor.SuspendLayout();
            this.gbxUpdateMentor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdateMentorPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentorsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet4)).BeginInit();
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
            this.groupBox1.Controls.Add(this.lblSearchByStudentName);
            this.groupBox1.Controls.Add(this.cbxSelectEducationPackage);
            this.groupBox1.Controls.Add(this.tbxSearchStudentByName);
            this.groupBox1.Controls.Add(this.cbxSelectGroup);
            this.groupBox1.Controls.Add(this.lblSelectGroup);
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
            // lblSearchByStudentName
            // 
            this.lblSearchByStudentName.AutoSize = true;
            this.lblSearchByStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchByStudentName.Location = new System.Drawing.Point(6, 110);
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
            // tbxSearchStudentByName
            // 
            this.tbxSearchStudentByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearchStudentByName.Location = new System.Drawing.Point(173, 107);
            this.tbxSearchStudentByName.Name = "tbxSearchStudentByName";
            this.tbxSearchStudentByName.Size = new System.Drawing.Size(158, 22);
            this.tbxSearchStudentByName.TabIndex = 10;
            this.tbxSearchStudentByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // cbxSelectGroup
            // 
            this.cbxSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSelectGroup.FormattingEnabled = true;
            this.cbxSelectGroup.Location = new System.Drawing.Point(173, 68);
            this.cbxSelectGroup.Name = "cbxSelectGroup";
            this.cbxSelectGroup.Size = new System.Drawing.Size(158, 24);
            this.cbxSelectGroup.TabIndex = 5;
            this.cbxSelectGroup.SelectedIndexChanged += new System.EventHandler(this.cbxSelectGroup_SelectedIndexChanged);
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectGroup.Location = new System.Drawing.Point(6, 71);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(84, 16);
            this.lblSelectGroup.TabIndex = 9;
            this.lblSelectGroup.Text = "Select group";
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
            this.tabGroup.Controls.Add(this.dgvGroupsList);
            this.tabGroup.Controls.Add(this.gbxUpdateGroup);
            this.tabGroup.Controls.Add(this.cbxSelectWhicGroup);
            this.tabGroup.Controls.Add(this.lblSelectWhichGroup);
            this.tabGroup.Controls.Add(this.btnAddStudentToGroup);
            this.tabGroup.Controls.Add(this.dgvStudentsToGroup);
            this.tabGroup.Controls.Add(this.gbxAddGroup);
            this.tabGroup.Location = new System.Drawing.Point(4, 22);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroup.Size = new System.Drawing.Size(1216, 520);
            this.tabGroup.TabIndex = 1;
            this.tabGroup.Text = "Groups";
            this.tabGroup.UseVisualStyleBackColor = true;
            // 
            // dgvGroupsList
            // 
            this.dgvGroupsList.AutoGenerateColumns = false;
            this.dgvGroupsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.programIdDataGridViewTextBoxColumn1,
            this.TeacherId,
            this.MentorId,
            this.GroupTypeId,
            this.GroupStartDate,
            this.GroupEndDate,
            this.GroupId});
            this.dgvGroupsList.DataSource = this.groupsBindingSource;
            this.dgvGroupsList.Location = new System.Drawing.Point(8, 258);
            this.dgvGroupsList.Name = "dgvGroupsList";
            this.dgvGroupsList.Size = new System.Drawing.Size(772, 249);
            this.dgvGroupsList.TabIndex = 22;
            this.dgvGroupsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupsList_CellClick);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.educationProjectDataSet3;
            // 
            // educationProjectDataSet3
            // 
            this.educationProjectDataSet3.DataSetName = "EducationProjectDataSet3";
            this.educationProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxUpdateGroup
            // 
            this.gbxUpdateGroup.Controls.Add(this.dtpUpdateGroupStartDate);
            this.gbxUpdateGroup.Controls.Add(this.btnUpdateGroup);
            this.gbxUpdateGroup.Controls.Add(this.lblUpdateGroupStartDate);
            this.gbxUpdateGroup.Controls.Add(this.tbxUpdateGroupName);
            this.gbxUpdateGroup.Controls.Add(this.lblGroupUpdateName);
            this.gbxUpdateGroup.Controls.Add(this.lblGroupUpdateGroupType);
            this.gbxUpdateGroup.Controls.Add(this.lblGroupUpdateMentor);
            this.gbxUpdateGroup.Controls.Add(this.lblGroupUpdateTeacher);
            this.gbxUpdateGroup.Controls.Add(this.cbxUpdateGroupGroupType);
            this.gbxUpdateGroup.Controls.Add(this.cbxUpdateGroupMentor);
            this.gbxUpdateGroup.Controls.Add(this.cbxUpdateGroupTeacher);
            this.gbxUpdateGroup.Controls.Add(this.lblGroupUpdateProgramId);
            this.gbxUpdateGroup.Controls.Add(this.cbxUpdateGroupProgramId);
            this.gbxUpdateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdateGroup.Location = new System.Drawing.Point(786, 258);
            this.gbxUpdateGroup.Name = "gbxUpdateGroup";
            this.gbxUpdateGroup.Size = new System.Drawing.Size(424, 249);
            this.gbxUpdateGroup.TabIndex = 21;
            this.gbxUpdateGroup.TabStop = false;
            this.gbxUpdateGroup.Text = "Update group data";
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.AutoSize = true;
            this.btnUpdateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateGroup.Location = new System.Drawing.Point(322, 212);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(101, 26);
            this.btnUpdateGroup.TabIndex = 23;
            this.btnUpdateGroup.Text = "Update group";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // lblUpdateGroupStartDate
            // 
            this.lblUpdateGroupStartDate.AutoSize = true;
            this.lblUpdateGroupStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateGroupStartDate.Location = new System.Drawing.Point(6, 185);
            this.lblUpdateGroupStartDate.Name = "lblUpdateGroupStartDate";
            this.lblUpdateGroupStartDate.Size = new System.Drawing.Size(103, 16);
            this.lblUpdateGroupStartDate.TabIndex = 16;
            this.lblUpdateGroupStartDate.Text = "Group start date";
            // 
            // tbxUpdateGroupName
            // 
            this.tbxUpdateGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateGroupName.Location = new System.Drawing.Point(137, 34);
            this.tbxUpdateGroupName.Name = "tbxUpdateGroupName";
            this.tbxUpdateGroupName.Size = new System.Drawing.Size(280, 22);
            this.tbxUpdateGroupName.TabIndex = 16;
            // 
            // lblGroupUpdateName
            // 
            this.lblGroupUpdateName.AutoSize = true;
            this.lblGroupUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupUpdateName.Location = new System.Drawing.Point(6, 37);
            this.lblGroupUpdateName.Name = "lblGroupUpdateName";
            this.lblGroupUpdateName.Size = new System.Drawing.Size(45, 16);
            this.lblGroupUpdateName.TabIndex = 23;
            this.lblGroupUpdateName.Text = "Name";
            // 
            // lblGroupUpdateGroupType
            // 
            this.lblGroupUpdateGroupType.AutoSize = true;
            this.lblGroupUpdateGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupUpdateGroupType.Location = new System.Drawing.Point(6, 155);
            this.lblGroupUpdateGroupType.Name = "lblGroupUpdateGroupType";
            this.lblGroupUpdateGroupType.Size = new System.Drawing.Size(74, 16);
            this.lblGroupUpdateGroupType.TabIndex = 22;
            this.lblGroupUpdateGroupType.Text = "Group type";
            // 
            // lblGroupUpdateMentor
            // 
            this.lblGroupUpdateMentor.AutoSize = true;
            this.lblGroupUpdateMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupUpdateMentor.Location = new System.Drawing.Point(6, 125);
            this.lblGroupUpdateMentor.Name = "lblGroupUpdateMentor";
            this.lblGroupUpdateMentor.Size = new System.Drawing.Size(49, 16);
            this.lblGroupUpdateMentor.TabIndex = 21;
            this.lblGroupUpdateMentor.Text = "Mentor";
            // 
            // lblGroupUpdateTeacher
            // 
            this.lblGroupUpdateTeacher.AutoSize = true;
            this.lblGroupUpdateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupUpdateTeacher.Location = new System.Drawing.Point(6, 95);
            this.lblGroupUpdateTeacher.Name = "lblGroupUpdateTeacher";
            this.lblGroupUpdateTeacher.Size = new System.Drawing.Size(59, 16);
            this.lblGroupUpdateTeacher.TabIndex = 20;
            this.lblGroupUpdateTeacher.Text = "Teacher";
            // 
            // cbxUpdateGroupGroupType
            // 
            this.cbxUpdateGroupGroupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUpdateGroupGroupType.FormattingEnabled = true;
            this.cbxUpdateGroupGroupType.Location = new System.Drawing.Point(137, 152);
            this.cbxUpdateGroupGroupType.Name = "cbxUpdateGroupGroupType";
            this.cbxUpdateGroupGroupType.Size = new System.Drawing.Size(280, 24);
            this.cbxUpdateGroupGroupType.TabIndex = 19;
            // 
            // cbxUpdateGroupMentor
            // 
            this.cbxUpdateGroupMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUpdateGroupMentor.FormattingEnabled = true;
            this.cbxUpdateGroupMentor.Location = new System.Drawing.Point(137, 122);
            this.cbxUpdateGroupMentor.Name = "cbxUpdateGroupMentor";
            this.cbxUpdateGroupMentor.Size = new System.Drawing.Size(280, 24);
            this.cbxUpdateGroupMentor.TabIndex = 18;
            // 
            // cbxUpdateGroupTeacher
            // 
            this.cbxUpdateGroupTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUpdateGroupTeacher.FormattingEnabled = true;
            this.cbxUpdateGroupTeacher.Location = new System.Drawing.Point(137, 92);
            this.cbxUpdateGroupTeacher.Name = "cbxUpdateGroupTeacher";
            this.cbxUpdateGroupTeacher.Size = new System.Drawing.Size(280, 24);
            this.cbxUpdateGroupTeacher.TabIndex = 17;
            // 
            // lblGroupUpdateProgramId
            // 
            this.lblGroupUpdateProgramId.AutoSize = true;
            this.lblGroupUpdateProgramId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroupUpdateProgramId.Location = new System.Drawing.Point(6, 65);
            this.lblGroupUpdateProgramId.Name = "lblGroupUpdateProgramId";
            this.lblGroupUpdateProgramId.Size = new System.Drawing.Size(125, 16);
            this.lblGroupUpdateProgramId.TabIndex = 16;
            this.lblGroupUpdateProgramId.Text = "Education package";
            // 
            // cbxUpdateGroupProgramId
            // 
            this.cbxUpdateGroupProgramId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUpdateGroupProgramId.FormattingEnabled = true;
            this.cbxUpdateGroupProgramId.Location = new System.Drawing.Point(137, 62);
            this.cbxUpdateGroupProgramId.Name = "cbxUpdateGroupProgramId";
            this.cbxUpdateGroupProgramId.Size = new System.Drawing.Size(280, 24);
            this.cbxUpdateGroupProgramId.TabIndex = 0;
            // 
            // cbxSelectWhicGroup
            // 
            this.cbxSelectWhicGroup.FormattingEnabled = true;
            this.cbxSelectWhicGroup.Location = new System.Drawing.Point(980, 224);
            this.cbxSelectWhicGroup.Name = "cbxSelectWhicGroup";
            this.cbxSelectWhicGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectWhicGroup.TabIndex = 20;
            // 
            // lblSelectWhichGroup
            // 
            this.lblSelectWhichGroup.AutoSize = true;
            this.lblSelectWhichGroup.Location = new System.Drawing.Point(874, 228);
            this.lblSelectWhichGroup.Name = "lblSelectWhichGroup";
            this.lblSelectWhichGroup.Size = new System.Drawing.Size(100, 13);
            this.lblSelectWhichGroup.TabIndex = 19;
            this.lblSelectWhichGroup.Text = "Select group to add";
            // 
            // btnAddStudentToGroup
            // 
            this.btnAddStudentToGroup.AutoSize = true;
            this.btnAddStudentToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudentToGroup.Location = new System.Drawing.Point(1107, 220);
            this.btnAddStudentToGroup.Name = "btnAddStudentToGroup";
            this.btnAddStudentToGroup.Size = new System.Drawing.Size(96, 26);
            this.btnAddStudentToGroup.TabIndex = 16;
            this.btnAddStudentToGroup.Text = "Add to group";
            this.btnAddStudentToGroup.UseVisualStyleBackColor = true;
            this.btnAddStudentToGroup.Click += new System.EventHandler(this.btnAddStudentToGroup_Click);
            // 
            // dgvStudentsToGroup
            // 
            this.dgvStudentsToGroup.AutoGenerateColumns = false;
            this.dgvStudentsToGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentsToGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsToGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn1,
            this.studentSurnameDataGridViewTextBoxColumn1,
            this.studentEmailDataGridViewTextBoxColumn1,
            this.studentPhoneDataGridViewTextBoxColumn1,
            this.studentIdDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn});
            this.dgvStudentsToGroup.DataSource = this.studentsBindingSource;
            this.dgvStudentsToGroup.Location = new System.Drawing.Point(408, 18);
            this.dgvStudentsToGroup.Name = "dgvStudentsToGroup";
            this.dgvStudentsToGroup.Size = new System.Drawing.Size(795, 196);
            this.dgvStudentsToGroup.TabIndex = 18;
            // 
            // studentNameDataGridViewTextBoxColumn1
            // 
            this.studentNameDataGridViewTextBoxColumn1.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn1.HeaderText = "Student name";
            this.studentNameDataGridViewTextBoxColumn1.Name = "studentNameDataGridViewTextBoxColumn1";
            // 
            // studentSurnameDataGridViewTextBoxColumn1
            // 
            this.studentSurnameDataGridViewTextBoxColumn1.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn1.HeaderText = "Student surname";
            this.studentSurnameDataGridViewTextBoxColumn1.Name = "studentSurnameDataGridViewTextBoxColumn1";
            // 
            // studentEmailDataGridViewTextBoxColumn1
            // 
            this.studentEmailDataGridViewTextBoxColumn1.DataPropertyName = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn1.HeaderText = "Student email";
            this.studentEmailDataGridViewTextBoxColumn1.Name = "studentEmailDataGridViewTextBoxColumn1";
            // 
            // studentPhoneDataGridViewTextBoxColumn1
            // 
            this.studentPhoneDataGridViewTextBoxColumn1.DataPropertyName = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn1.HeaderText = "Student phone";
            this.studentPhoneDataGridViewTextBoxColumn1.Name = "studentPhoneDataGridViewTextBoxColumn1";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.Visible = false;
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
            // cbxGroupMentor
            // 
            this.cbxGroupMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupMentor.FormattingEnabled = true;
            this.cbxGroupMentor.Location = new System.Drawing.Point(138, 184);
            this.cbxGroupMentor.Name = "cbxGroupMentor";
            this.cbxGroupMentor.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupMentor.TabIndex = 14;
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
            // cbxGroupTeacher
            // 
            this.cbxGroupTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupTeacher.FormattingEnabled = true;
            this.cbxGroupTeacher.Location = new System.Drawing.Point(138, 157);
            this.cbxGroupTeacher.Name = "cbxGroupTeacher";
            this.cbxGroupTeacher.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupTeacher.TabIndex = 12;
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
            // tbxAddGroupName
            // 
            this.tbxAddGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddGroupName.Location = new System.Drawing.Point(138, 24);
            this.tbxAddGroupName.Name = "tbxAddGroupName";
            this.tbxAddGroupName.Size = new System.Drawing.Size(250, 22);
            this.tbxAddGroupName.TabIndex = 6;
            // 
            // dtpGroupStartDate
            // 
            this.dtpGroupStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpGroupStartDate.Location = new System.Drawing.Point(138, 131);
            this.dtpGroupStartDate.Name = "dtpGroupStartDate";
            this.dtpGroupStartDate.Size = new System.Drawing.Size(250, 22);
            this.dtpGroupStartDate.TabIndex = 10;
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
            // cbxGroupLessonTime
            // 
            this.cbxGroupLessonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGroupLessonTime.FormattingEnabled = true;
            this.cbxGroupLessonTime.Location = new System.Drawing.Point(138, 104);
            this.cbxGroupLessonTime.Name = "cbxGroupLessonTime";
            this.cbxGroupLessonTime.Size = new System.Drawing.Size(250, 24);
            this.cbxGroupLessonTime.TabIndex = 9;
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
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.btnShowAllTeachers);
            this.tabTeacher.Controls.Add(this.gbxSearchTeacher);
            this.tabTeacher.Controls.Add(this.gbxNewTeacher);
            this.tabTeacher.Controls.Add(this.gbxTeacherUpdate);
            this.tabTeacher.Controls.Add(this.lblTeachers);
            this.tabTeacher.Controls.Add(this.dgvTeachersList);
            this.tabTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Size = new System.Drawing.Size(1216, 520);
            this.tabTeacher.TabIndex = 2;
            this.tabTeacher.Text = "Teachers";
            this.tabTeacher.UseVisualStyleBackColor = true;
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
            this.btnShowAllTeachers.Click += new System.EventHandler(this.btnShowAllTeachers_Click);
            // 
            // gbxSearchTeacher
            // 
            this.gbxSearchTeacher.Controls.Add(this.lblSearchEducationPackage);
            this.gbxSearchTeacher.Controls.Add(this.lblSearchByTeacherName);
            this.gbxSearchTeacher.Controls.Add(this.cbxSearchTeacherEducationPackage);
            this.gbxSearchTeacher.Controls.Add(this.tbxSearchTeacherByName);
            this.gbxSearchTeacher.Controls.Add(this.cbxSearchTeacherGroup);
            this.gbxSearchTeacher.Controls.Add(this.lblSearchGroup);
            this.gbxSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearchTeacher.Location = new System.Drawing.Point(866, 236);
            this.gbxSearchTeacher.Name = "gbxSearchTeacher";
            this.gbxSearchTeacher.Size = new System.Drawing.Size(337, 269);
            this.gbxSearchTeacher.TabIndex = 33;
            this.gbxSearchTeacher.TabStop = false;
            this.gbxSearchTeacher.Text = "Search";
            // 
            // lblSearchEducationPackage
            // 
            this.lblSearchEducationPackage.AutoSize = true;
            this.lblSearchEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchEducationPackage.Location = new System.Drawing.Point(6, 37);
            this.lblSearchEducationPackage.Name = "lblSearchEducationPackage";
            this.lblSearchEducationPackage.Size = new System.Drawing.Size(165, 16);
            this.lblSearchEducationPackage.TabIndex = 6;
            this.lblSearchEducationPackage.Text = "Select education package";
            // 
            // lblSearchByTeacherName
            // 
            this.lblSearchByTeacherName.AutoSize = true;
            this.lblSearchByTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchByTeacherName.Location = new System.Drawing.Point(6, 110);
            this.lblSearchByTeacherName.Name = "lblSearchByTeacherName";
            this.lblSearchByTeacherName.Size = new System.Drawing.Size(154, 16);
            this.lblSearchByTeacherName.TabIndex = 11;
            this.lblSearchByTeacherName.Text = "Search by teacher name";
            // 
            // cbxSearchTeacherEducationPackage
            // 
            this.cbxSearchTeacherEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSearchTeacherEducationPackage.FormattingEnabled = true;
            this.cbxSearchTeacherEducationPackage.Location = new System.Drawing.Point(173, 34);
            this.cbxSearchTeacherEducationPackage.Name = "cbxSearchTeacherEducationPackage";
            this.cbxSearchTeacherEducationPackage.Size = new System.Drawing.Size(158, 24);
            this.cbxSearchTeacherEducationPackage.TabIndex = 4;
            this.cbxSearchTeacherEducationPackage.SelectedIndexChanged += new System.EventHandler(this.cbxSearchEducationPackage_SelectedIndexChanged);
            // 
            // tbxSearchTeacherByName
            // 
            this.tbxSearchTeacherByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearchTeacherByName.Location = new System.Drawing.Point(173, 107);
            this.tbxSearchTeacherByName.Name = "tbxSearchTeacherByName";
            this.tbxSearchTeacherByName.Size = new System.Drawing.Size(158, 22);
            this.tbxSearchTeacherByName.TabIndex = 10;
            this.tbxSearchTeacherByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // cbxSearchTeacherGroup
            // 
            this.cbxSearchTeacherGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSearchTeacherGroup.FormattingEnabled = true;
            this.cbxSearchTeacherGroup.Location = new System.Drawing.Point(173, 68);
            this.cbxSearchTeacherGroup.Name = "cbxSearchTeacherGroup";
            this.cbxSearchTeacherGroup.Size = new System.Drawing.Size(158, 24);
            this.cbxSearchTeacherGroup.TabIndex = 5;
            this.cbxSearchTeacherGroup.SelectedIndexChanged += new System.EventHandler(this.cbxSearchTeacherGroup_SelectedIndexChanged);
            // 
            // lblSearchGroup
            // 
            this.lblSearchGroup.AutoSize = true;
            this.lblSearchGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchGroup.Location = new System.Drawing.Point(6, 71);
            this.lblSearchGroup.Name = "lblSearchGroup";
            this.lblSearchGroup.Size = new System.Drawing.Size(84, 16);
            this.lblSearchGroup.TabIndex = 9;
            this.lblSearchGroup.Text = "Select group";
            // 
            // gbxNewTeacher
            // 
            this.gbxNewTeacher.Controls.Add(this.lblNewTeacherEducationPackage);
            this.gbxNewTeacher.Controls.Add(this.cbxNewTeacherEducationPackage);
            this.gbxNewTeacher.Controls.Add(this.btnAddNewTeacher);
            this.gbxNewTeacher.Controls.Add(this.tbxNewTeacherPhone);
            this.gbxNewTeacher.Controls.Add(this.tbxNewTeacherEmail);
            this.gbxNewTeacher.Controls.Add(this.tbxNewTeacherSurname);
            this.gbxNewTeacher.Controls.Add(this.tbxNewTeacherName);
            this.gbxNewTeacher.Controls.Add(this.lblNewTeacherEmail);
            this.gbxNewTeacher.Controls.Add(this.lblNewTeacherPhone);
            this.gbxNewTeacher.Controls.Add(this.lblNewTeacherSurname);
            this.gbxNewTeacher.Controls.Add(this.lblNewTeacherName);
            this.gbxNewTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxNewTeacher.Location = new System.Drawing.Point(510, 236);
            this.gbxNewTeacher.Name = "gbxNewTeacher";
            this.gbxNewTeacher.Size = new System.Drawing.Size(350, 269);
            this.gbxNewTeacher.TabIndex = 32;
            this.gbxNewTeacher.TabStop = false;
            this.gbxNewTeacher.Text = "New teacher";
            // 
            // lblNewTeacherEducationPackage
            // 
            this.lblNewTeacherEducationPackage.AutoSize = true;
            this.lblNewTeacherEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewTeacherEducationPackage.Location = new System.Drawing.Point(6, 157);
            this.lblNewTeacherEducationPackage.Name = "lblNewTeacherEducationPackage";
            this.lblNewTeacherEducationPackage.Size = new System.Drawing.Size(131, 16);
            this.lblNewTeacherEducationPackage.TabIndex = 27;
            this.lblNewTeacherEducationPackage.Text = "Education package :";
            // 
            // cbxNewTeacherEducationPackage
            // 
            this.cbxNewTeacherEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxNewTeacherEducationPackage.FormattingEnabled = true;
            this.cbxNewTeacherEducationPackage.Location = new System.Drawing.Point(143, 152);
            this.cbxNewTeacherEducationPackage.Name = "cbxNewTeacherEducationPackage";
            this.cbxNewTeacherEducationPackage.Size = new System.Drawing.Size(189, 24);
            this.cbxNewTeacherEducationPackage.TabIndex = 26;
            // 
            // btnAddNewTeacher
            // 
            this.btnAddNewTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTeacher.Location = new System.Drawing.Point(257, 182);
            this.btnAddNewTeacher.Name = "btnAddNewTeacher";
            this.btnAddNewTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTeacher.TabIndex = 25;
            this.btnAddNewTeacher.Text = "Add";
            this.btnAddNewTeacher.UseVisualStyleBackColor = true;
            this.btnAddNewTeacher.Click += new System.EventHandler(this.btnAddNewTeacher_Click);
            // 
            // tbxNewTeacherPhone
            // 
            this.tbxNewTeacherPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewTeacherPhone.Location = new System.Drawing.Point(86, 124);
            this.tbxNewTeacherPhone.Name = "tbxNewTeacherPhone";
            this.tbxNewTeacherPhone.Size = new System.Drawing.Size(246, 22);
            this.tbxNewTeacherPhone.TabIndex = 24;
            // 
            // tbxNewTeacherEmail
            // 
            this.tbxNewTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewTeacherEmail.Location = new System.Drawing.Point(86, 96);
            this.tbxNewTeacherEmail.Name = "tbxNewTeacherEmail";
            this.tbxNewTeacherEmail.Size = new System.Drawing.Size(246, 22);
            this.tbxNewTeacherEmail.TabIndex = 23;
            // 
            // tbxNewTeacherSurname
            // 
            this.tbxNewTeacherSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewTeacherSurname.Location = new System.Drawing.Point(86, 65);
            this.tbxNewTeacherSurname.Name = "tbxNewTeacherSurname";
            this.tbxNewTeacherSurname.Size = new System.Drawing.Size(246, 22);
            this.tbxNewTeacherSurname.TabIndex = 22;
            // 
            // tbxNewTeacherName
            // 
            this.tbxNewTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewTeacherName.Location = new System.Drawing.Point(86, 37);
            this.tbxNewTeacherName.Name = "tbxNewTeacherName";
            this.tbxNewTeacherName.Size = new System.Drawing.Size(246, 22);
            this.tbxNewTeacherName.TabIndex = 21;
            // 
            // lblNewTeacherEmail
            // 
            this.lblNewTeacherEmail.AutoSize = true;
            this.lblNewTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewTeacherEmail.Location = new System.Drawing.Point(6, 99);
            this.lblNewTeacherEmail.Name = "lblNewTeacherEmail";
            this.lblNewTeacherEmail.Size = new System.Drawing.Size(48, 16);
            this.lblNewTeacherEmail.TabIndex = 16;
            this.lblNewTeacherEmail.Text = "Email :";
            // 
            // lblNewTeacherPhone
            // 
            this.lblNewTeacherPhone.AutoSize = true;
            this.lblNewTeacherPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewTeacherPhone.Location = new System.Drawing.Point(6, 127);
            this.lblNewTeacherPhone.Name = "lblNewTeacherPhone";
            this.lblNewTeacherPhone.Size = new System.Drawing.Size(53, 16);
            this.lblNewTeacherPhone.TabIndex = 15;
            this.lblNewTeacherPhone.Text = "Phone :";
            // 
            // lblNewTeacherSurname
            // 
            this.lblNewTeacherSurname.AutoSize = true;
            this.lblNewTeacherSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewTeacherSurname.Location = new System.Drawing.Point(6, 68);
            this.lblNewTeacherSurname.Name = "lblNewTeacherSurname";
            this.lblNewTeacherSurname.Size = new System.Drawing.Size(68, 16);
            this.lblNewTeacherSurname.TabIndex = 14;
            this.lblNewTeacherSurname.Text = "Surname :";
            // 
            // lblNewTeacherName
            // 
            this.lblNewTeacherName.AutoSize = true;
            this.lblNewTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewTeacherName.Location = new System.Drawing.Point(6, 40);
            this.lblNewTeacherName.Name = "lblNewTeacherName";
            this.lblNewTeacherName.Size = new System.Drawing.Size(51, 16);
            this.lblNewTeacherName.TabIndex = 13;
            this.lblNewTeacherName.Text = "Name :";
            // 
            // gbxTeacherUpdate
            // 
            this.gbxTeacherUpdate.Controls.Add(this.btnUpdateTeacherPhoto);
            this.gbxTeacherUpdate.Controls.Add(this.btnRemoveTeacher);
            this.gbxTeacherUpdate.Controls.Add(this.tbxUpdateTeacherPhone);
            this.gbxTeacherUpdate.Controls.Add(this.tbxUpdateTeacherEmail);
            this.gbxTeacherUpdate.Controls.Add(this.tbxUpdateTeacherSurname);
            this.gbxTeacherUpdate.Controls.Add(this.tbxUpdateTeacherName);
            this.gbxTeacherUpdate.Controls.Add(this.rbxUpdateTeacherBio);
            this.gbxTeacherUpdate.Controls.Add(this.btnUpdateTeacher);
            this.gbxTeacherUpdate.Controls.Add(this.pbxUpdateTeacherPhoto);
            this.gbxTeacherUpdate.Controls.Add(this.lblUpdateTeacherBio);
            this.gbxTeacherUpdate.Controls.Add(this.lblUpdateTeacherEmail);
            this.gbxTeacherUpdate.Controls.Add(this.lblUpdateTeacherPhone);
            this.gbxTeacherUpdate.Controls.Add(this.lblUpdateTeacherSurname);
            this.gbxTeacherUpdate.Controls.Add(this.lblUpdateTeacherName);
            this.gbxTeacherUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxTeacherUpdate.Location = new System.Drawing.Point(6, 236);
            this.gbxTeacherUpdate.Name = "gbxTeacherUpdate";
            this.gbxTeacherUpdate.Size = new System.Drawing.Size(478, 269);
            this.gbxTeacherUpdate.TabIndex = 30;
            this.gbxTeacherUpdate.TabStop = false;
            this.gbxTeacherUpdate.Text = "Update";
            // 
            // btnUpdateTeacherPhoto
            // 
            this.btnUpdateTeacherPhoto.AutoSize = true;
            this.btnUpdateTeacherPhoto.Enabled = false;
            this.btnUpdateTeacherPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateTeacherPhoto.Location = new System.Drawing.Point(346, 149);
            this.btnUpdateTeacherPhoto.Name = "btnUpdateTeacherPhoto";
            this.btnUpdateTeacherPhoto.Size = new System.Drawing.Size(100, 26);
            this.btnUpdateTeacherPhoto.TabIndex = 27;
            this.btnUpdateTeacherPhoto.Text = "Update photo";
            this.btnUpdateTeacherPhoto.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.BackColor = System.Drawing.Color.Red;
            this.btnRemoveTeacher.Enabled = false;
            this.btnRemoveTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveTeacher.Location = new System.Drawing.Point(397, 240);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTeacher.TabIndex = 25;
            this.btnRemoveTeacher.Text = "Remove";
            this.btnRemoveTeacher.UseVisualStyleBackColor = false;
            // 
            // tbxUpdateTeacherPhone
            // 
            this.tbxUpdateTeacherPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTeacherPhone.Location = new System.Drawing.Point(86, 124);
            this.tbxUpdateTeacherPhone.Name = "tbxUpdateTeacherPhone";
            this.tbxUpdateTeacherPhone.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateTeacherPhone.TabIndex = 24;
            // 
            // tbxUpdateTeacherEmail
            // 
            this.tbxUpdateTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTeacherEmail.Location = new System.Drawing.Point(86, 96);
            this.tbxUpdateTeacherEmail.Name = "tbxUpdateTeacherEmail";
            this.tbxUpdateTeacherEmail.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateTeacherEmail.TabIndex = 23;
            // 
            // tbxUpdateTeacherSurname
            // 
            this.tbxUpdateTeacherSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTeacherSurname.Location = new System.Drawing.Point(86, 65);
            this.tbxUpdateTeacherSurname.Name = "tbxUpdateTeacherSurname";
            this.tbxUpdateTeacherSurname.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateTeacherSurname.TabIndex = 22;
            // 
            // tbxUpdateTeacherName
            // 
            this.tbxUpdateTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateTeacherName.Location = new System.Drawing.Point(86, 37);
            this.tbxUpdateTeacherName.Name = "tbxUpdateTeacherName";
            this.tbxUpdateTeacherName.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateTeacherName.TabIndex = 21;
            // 
            // rbxUpdateTeacherBio
            // 
            this.rbxUpdateTeacherBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxUpdateTeacherBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbxUpdateTeacherBio.Location = new System.Drawing.Point(6, 168);
            this.rbxUpdateTeacherBio.Name = "rbxUpdateTeacherBio";
            this.rbxUpdateTeacherBio.Size = new System.Drawing.Size(262, 90);
            this.rbxUpdateTeacherBio.TabIndex = 20;
            this.rbxUpdateTeacherBio.Text = "";
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Enabled = false;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateTeacher.Location = new System.Drawing.Point(316, 240);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTeacher.TabIndex = 19;
            this.btnUpdateTeacher.Text = "Update";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // pbxUpdateTeacherPhoto
            // 
            this.pbxUpdateTeacherPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxUpdateTeacherPhoto.ErrorImage")));
            this.pbxUpdateTeacherPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxUpdateTeacherPhoto.Image")));
            this.pbxUpdateTeacherPhoto.Location = new System.Drawing.Point(346, 31);
            this.pbxUpdateTeacherPhoto.Name = "pbxUpdateTeacherPhoto";
            this.pbxUpdateTeacherPhoto.Size = new System.Drawing.Size(100, 112);
            this.pbxUpdateTeacherPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUpdateTeacherPhoto.TabIndex = 18;
            this.pbxUpdateTeacherPhoto.TabStop = false;
            // 
            // lblUpdateTeacherBio
            // 
            this.lblUpdateTeacherBio.AutoSize = true;
            this.lblUpdateTeacherBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTeacherBio.Location = new System.Drawing.Point(6, 149);
            this.lblUpdateTeacherBio.Name = "lblUpdateTeacherBio";
            this.lblUpdateTeacherBio.Size = new System.Drawing.Size(34, 16);
            this.lblUpdateTeacherBio.TabIndex = 17;
            this.lblUpdateTeacherBio.Text = "Bio :";
            // 
            // lblUpdateTeacherEmail
            // 
            this.lblUpdateTeacherEmail.AutoSize = true;
            this.lblUpdateTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTeacherEmail.Location = new System.Drawing.Point(6, 99);
            this.lblUpdateTeacherEmail.Name = "lblUpdateTeacherEmail";
            this.lblUpdateTeacherEmail.Size = new System.Drawing.Size(48, 16);
            this.lblUpdateTeacherEmail.TabIndex = 16;
            this.lblUpdateTeacherEmail.Text = "Email :";
            // 
            // lblUpdateTeacherPhone
            // 
            this.lblUpdateTeacherPhone.AutoSize = true;
            this.lblUpdateTeacherPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTeacherPhone.Location = new System.Drawing.Point(6, 127);
            this.lblUpdateTeacherPhone.Name = "lblUpdateTeacherPhone";
            this.lblUpdateTeacherPhone.Size = new System.Drawing.Size(53, 16);
            this.lblUpdateTeacherPhone.TabIndex = 15;
            this.lblUpdateTeacherPhone.Text = "Phone :";
            // 
            // lblUpdateTeacherSurname
            // 
            this.lblUpdateTeacherSurname.AutoSize = true;
            this.lblUpdateTeacherSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTeacherSurname.Location = new System.Drawing.Point(6, 68);
            this.lblUpdateTeacherSurname.Name = "lblUpdateTeacherSurname";
            this.lblUpdateTeacherSurname.Size = new System.Drawing.Size(68, 16);
            this.lblUpdateTeacherSurname.TabIndex = 14;
            this.lblUpdateTeacherSurname.Text = "Surname :";
            // 
            // lblUpdateTeacherName
            // 
            this.lblUpdateTeacherName.AutoSize = true;
            this.lblUpdateTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateTeacherName.Location = new System.Drawing.Point(6, 40);
            this.lblUpdateTeacherName.Name = "lblUpdateTeacherName";
            this.lblUpdateTeacherName.Size = new System.Drawing.Size(51, 16);
            this.lblUpdateTeacherName.TabIndex = 13;
            this.lblUpdateTeacherName.Text = "Name :";
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
            this.teacherNameDataGridViewTextBoxColumn,
            this.teacherSurnameDataGridViewTextBoxColumn,
            this.teacherEmailDataGridViewTextBoxColumn,
            this.teacherPhoneDataGridViewTextBoxColumn,
            this.teacherBioDataGridViewTextBoxColumn,
            this.teacherPhotoDataGridViewTextBoxColumn,
            this.programIdDataGridViewTextBoxColumn,
            this.teacherIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dgvTeachersList.DataSource = this.teachersBindingSource;
            this.dgvTeachersList.Location = new System.Drawing.Point(6, 38);
            this.dgvTeachersList.Name = "dgvTeachersList";
            this.dgvTeachersList.Size = new System.Drawing.Size(1197, 191);
            this.dgvTeachersList.TabIndex = 28;
            this.dgvTeachersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachersList_CellClick);
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.educationProjectDataSet2;
            // 
            // educationProjectDataSet2
            // 
            this.educationProjectDataSet2.DataSetName = "EducationProjectDataSet2";
            this.educationProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabMentor
            // 
            this.tabMentor.Controls.Add(this.btnShowAllMentors);
            this.tabMentor.Controls.Add(this.gbxSearchMentor);
            this.tabMentor.Controls.Add(this.gbxNewMentor);
            this.tabMentor.Controls.Add(this.gbxUpdateMentor);
            this.tabMentor.Controls.Add(this.lblMentors);
            this.tabMentor.Controls.Add(this.dgvMentorsList);
            this.tabMentor.Location = new System.Drawing.Point(4, 22);
            this.tabMentor.Name = "tabMentor";
            this.tabMentor.Size = new System.Drawing.Size(1216, 520);
            this.tabMentor.TabIndex = 3;
            this.tabMentor.Text = "Mentors";
            this.tabMentor.UseVisualStyleBackColor = true;
            // 
            // btnShowAllMentors
            // 
            this.btnShowAllMentors.AutoSize = true;
            this.btnShowAllMentors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAllMentors.Location = new System.Drawing.Point(1077, 5);
            this.btnShowAllMentors.Name = "btnShowAllMentors";
            this.btnShowAllMentors.Size = new System.Drawing.Size(123, 26);
            this.btnShowAllMentors.TabIndex = 37;
            this.btnShowAllMentors.Text = "Show all mentors";
            this.btnShowAllMentors.UseVisualStyleBackColor = true;
            this.btnShowAllMentors.Click += new System.EventHandler(this.btnShowAllMentors_Click);
            // 
            // gbxSearchMentor
            // 
            this.gbxSearchMentor.Controls.Add(this.lblSearchMentorEducationPackage);
            this.gbxSearchMentor.Controls.Add(this.lblSearchMentorByName);
            this.gbxSearchMentor.Controls.Add(this.cbxSearchMentorEducationPackage);
            this.gbxSearchMentor.Controls.Add(this.tbxSearchMentorByName);
            this.gbxSearchMentor.Controls.Add(this.cbxSearchMentorGroup);
            this.gbxSearchMentor.Controls.Add(this.lblSearchMentorGroup);
            this.gbxSearchMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearchMentor.Location = new System.Drawing.Point(861, 235);
            this.gbxSearchMentor.Name = "gbxSearchMentor";
            this.gbxSearchMentor.Size = new System.Drawing.Size(337, 269);
            this.gbxSearchMentor.TabIndex = 39;
            this.gbxSearchMentor.TabStop = false;
            this.gbxSearchMentor.Text = "Search";
            // 
            // lblSearchMentorEducationPackage
            // 
            this.lblSearchMentorEducationPackage.AutoSize = true;
            this.lblSearchMentorEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchMentorEducationPackage.Location = new System.Drawing.Point(6, 37);
            this.lblSearchMentorEducationPackage.Name = "lblSearchMentorEducationPackage";
            this.lblSearchMentorEducationPackage.Size = new System.Drawing.Size(165, 16);
            this.lblSearchMentorEducationPackage.TabIndex = 6;
            this.lblSearchMentorEducationPackage.Text = "Select education package";
            // 
            // lblSearchMentorByName
            // 
            this.lblSearchMentorByName.AutoSize = true;
            this.lblSearchMentorByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchMentorByName.Location = new System.Drawing.Point(6, 110);
            this.lblSearchMentorByName.Name = "lblSearchMentorByName";
            this.lblSearchMentorByName.Size = new System.Drawing.Size(150, 16);
            this.lblSearchMentorByName.TabIndex = 11;
            this.lblSearchMentorByName.Text = "Search by mentor name";
            // 
            // cbxSearchMentorEducationPackage
            // 
            this.cbxSearchMentorEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSearchMentorEducationPackage.FormattingEnabled = true;
            this.cbxSearchMentorEducationPackage.Location = new System.Drawing.Point(173, 34);
            this.cbxSearchMentorEducationPackage.Name = "cbxSearchMentorEducationPackage";
            this.cbxSearchMentorEducationPackage.Size = new System.Drawing.Size(158, 24);
            this.cbxSearchMentorEducationPackage.TabIndex = 4;
            this.cbxSearchMentorEducationPackage.SelectedIndexChanged += new System.EventHandler(this.cbxSearchMentorEducationPackage_SelectedIndexChanged);
            // 
            // tbxSearchMentorByName
            // 
            this.tbxSearchMentorByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearchMentorByName.Location = new System.Drawing.Point(173, 107);
            this.tbxSearchMentorByName.Name = "tbxSearchMentorByName";
            this.tbxSearchMentorByName.Size = new System.Drawing.Size(158, 22);
            this.tbxSearchMentorByName.TabIndex = 10;
            this.tbxSearchMentorByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // cbxSearchMentorGroup
            // 
            this.cbxSearchMentorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSearchMentorGroup.FormattingEnabled = true;
            this.cbxSearchMentorGroup.Location = new System.Drawing.Point(173, 68);
            this.cbxSearchMentorGroup.Name = "cbxSearchMentorGroup";
            this.cbxSearchMentorGroup.Size = new System.Drawing.Size(158, 24);
            this.cbxSearchMentorGroup.TabIndex = 5;
            this.cbxSearchMentorGroup.SelectedIndexChanged += new System.EventHandler(this.cbxSearchMentorGroup_SelectedIndexChanged);
            // 
            // lblSearchMentorGroup
            // 
            this.lblSearchMentorGroup.AutoSize = true;
            this.lblSearchMentorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchMentorGroup.Location = new System.Drawing.Point(6, 71);
            this.lblSearchMentorGroup.Name = "lblSearchMentorGroup";
            this.lblSearchMentorGroup.Size = new System.Drawing.Size(84, 16);
            this.lblSearchMentorGroup.TabIndex = 9;
            this.lblSearchMentorGroup.Text = "Select group";
            // 
            // gbxNewMentor
            // 
            this.gbxNewMentor.Controls.Add(this.lblNewMentorEducationPackage);
            this.gbxNewMentor.Controls.Add(this.cbxNewMentorEducationPackage);
            this.gbxNewMentor.Controls.Add(this.btnAddNewMentor);
            this.gbxNewMentor.Controls.Add(this.tbxNewMentorPhone);
            this.gbxNewMentor.Controls.Add(this.tbxNewMentorEmail);
            this.gbxNewMentor.Controls.Add(this.tbxNewMentorSurname);
            this.gbxNewMentor.Controls.Add(this.tbxNewMentorName);
            this.gbxNewMentor.Controls.Add(this.lblNewMentorEmail);
            this.gbxNewMentor.Controls.Add(this.lblNewMentorPhone);
            this.gbxNewMentor.Controls.Add(this.lblNewMentorSurname);
            this.gbxNewMentor.Controls.Add(this.lblNewMentorName);
            this.gbxNewMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxNewMentor.Location = new System.Drawing.Point(505, 235);
            this.gbxNewMentor.Name = "gbxNewMentor";
            this.gbxNewMentor.Size = new System.Drawing.Size(350, 269);
            this.gbxNewMentor.TabIndex = 38;
            this.gbxNewMentor.TabStop = false;
            this.gbxNewMentor.Text = "New teacher";
            // 
            // lblNewMentorEducationPackage
            // 
            this.lblNewMentorEducationPackage.AutoSize = true;
            this.lblNewMentorEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewMentorEducationPackage.Location = new System.Drawing.Point(6, 157);
            this.lblNewMentorEducationPackage.Name = "lblNewMentorEducationPackage";
            this.lblNewMentorEducationPackage.Size = new System.Drawing.Size(131, 16);
            this.lblNewMentorEducationPackage.TabIndex = 29;
            this.lblNewMentorEducationPackage.Text = "Education package :";
            // 
            // cbxNewMentorEducationPackage
            // 
            this.cbxNewMentorEducationPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxNewMentorEducationPackage.FormattingEnabled = true;
            this.cbxNewMentorEducationPackage.Location = new System.Drawing.Point(143, 152);
            this.cbxNewMentorEducationPackage.Name = "cbxNewMentorEducationPackage";
            this.cbxNewMentorEducationPackage.Size = new System.Drawing.Size(189, 24);
            this.cbxNewMentorEducationPackage.TabIndex = 28;
            // 
            // btnAddNewMentor
            // 
            this.btnAddNewMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewMentor.Location = new System.Drawing.Point(257, 182);
            this.btnAddNewMentor.Name = "btnAddNewMentor";
            this.btnAddNewMentor.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewMentor.TabIndex = 25;
            this.btnAddNewMentor.Text = "Add";
            this.btnAddNewMentor.UseVisualStyleBackColor = true;
            this.btnAddNewMentor.Click += new System.EventHandler(this.btnAddNewMentor_Click);
            // 
            // tbxNewMentorPhone
            // 
            this.tbxNewMentorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewMentorPhone.Location = new System.Drawing.Point(86, 124);
            this.tbxNewMentorPhone.Name = "tbxNewMentorPhone";
            this.tbxNewMentorPhone.Size = new System.Drawing.Size(246, 22);
            this.tbxNewMentorPhone.TabIndex = 24;
            // 
            // tbxNewMentorEmail
            // 
            this.tbxNewMentorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewMentorEmail.Location = new System.Drawing.Point(86, 96);
            this.tbxNewMentorEmail.Name = "tbxNewMentorEmail";
            this.tbxNewMentorEmail.Size = new System.Drawing.Size(246, 22);
            this.tbxNewMentorEmail.TabIndex = 23;
            // 
            // tbxNewMentorSurname
            // 
            this.tbxNewMentorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewMentorSurname.Location = new System.Drawing.Point(86, 65);
            this.tbxNewMentorSurname.Name = "tbxNewMentorSurname";
            this.tbxNewMentorSurname.Size = new System.Drawing.Size(246, 22);
            this.tbxNewMentorSurname.TabIndex = 22;
            // 
            // tbxNewMentorName
            // 
            this.tbxNewMentorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNewMentorName.Location = new System.Drawing.Point(86, 37);
            this.tbxNewMentorName.Name = "tbxNewMentorName";
            this.tbxNewMentorName.Size = new System.Drawing.Size(246, 22);
            this.tbxNewMentorName.TabIndex = 21;
            // 
            // lblNewMentorEmail
            // 
            this.lblNewMentorEmail.AutoSize = true;
            this.lblNewMentorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewMentorEmail.Location = new System.Drawing.Point(6, 99);
            this.lblNewMentorEmail.Name = "lblNewMentorEmail";
            this.lblNewMentorEmail.Size = new System.Drawing.Size(48, 16);
            this.lblNewMentorEmail.TabIndex = 16;
            this.lblNewMentorEmail.Text = "Email :";
            // 
            // lblNewMentorPhone
            // 
            this.lblNewMentorPhone.AutoSize = true;
            this.lblNewMentorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewMentorPhone.Location = new System.Drawing.Point(6, 127);
            this.lblNewMentorPhone.Name = "lblNewMentorPhone";
            this.lblNewMentorPhone.Size = new System.Drawing.Size(53, 16);
            this.lblNewMentorPhone.TabIndex = 15;
            this.lblNewMentorPhone.Text = "Phone :";
            // 
            // lblNewMentorSurname
            // 
            this.lblNewMentorSurname.AutoSize = true;
            this.lblNewMentorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewMentorSurname.Location = new System.Drawing.Point(6, 68);
            this.lblNewMentorSurname.Name = "lblNewMentorSurname";
            this.lblNewMentorSurname.Size = new System.Drawing.Size(68, 16);
            this.lblNewMentorSurname.TabIndex = 14;
            this.lblNewMentorSurname.Text = "Surname :";
            // 
            // lblNewMentorName
            // 
            this.lblNewMentorName.AutoSize = true;
            this.lblNewMentorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewMentorName.Location = new System.Drawing.Point(6, 40);
            this.lblNewMentorName.Name = "lblNewMentorName";
            this.lblNewMentorName.Size = new System.Drawing.Size(51, 16);
            this.lblNewMentorName.TabIndex = 13;
            this.lblNewMentorName.Text = "Name :";
            // 
            // gbxUpdateMentor
            // 
            this.gbxUpdateMentor.Controls.Add(this.btnUpdateMentorPhoto);
            this.gbxUpdateMentor.Controls.Add(this.btnRemoveMentor);
            this.gbxUpdateMentor.Controls.Add(this.tbxUpdateMentorPhone);
            this.gbxUpdateMentor.Controls.Add(this.tbxUpdateMentorEmail);
            this.gbxUpdateMentor.Controls.Add(this.tbxUpdateMentorSurname);
            this.gbxUpdateMentor.Controls.Add(this.tbxUpdateMentorName);
            this.gbxUpdateMentor.Controls.Add(this.rbxUpdateMentorBio);
            this.gbxUpdateMentor.Controls.Add(this.btnUpdateMentor);
            this.gbxUpdateMentor.Controls.Add(this.pbxUpdateMentorPhoto);
            this.gbxUpdateMentor.Controls.Add(this.lblUpdateMentorBio);
            this.gbxUpdateMentor.Controls.Add(this.lblUpdateMentorEmail);
            this.gbxUpdateMentor.Controls.Add(this.lblUpdateMentorPhone);
            this.gbxUpdateMentor.Controls.Add(this.lblUpdateMentorSurname);
            this.gbxUpdateMentor.Controls.Add(this.lblUpdateMentorName);
            this.gbxUpdateMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdateMentor.Location = new System.Drawing.Point(1, 235);
            this.gbxUpdateMentor.Name = "gbxUpdateMentor";
            this.gbxUpdateMentor.Size = new System.Drawing.Size(478, 269);
            this.gbxUpdateMentor.TabIndex = 36;
            this.gbxUpdateMentor.TabStop = false;
            this.gbxUpdateMentor.Text = "Update";
            // 
            // btnUpdateMentorPhoto
            // 
            this.btnUpdateMentorPhoto.AutoSize = true;
            this.btnUpdateMentorPhoto.Enabled = false;
            this.btnUpdateMentorPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateMentorPhoto.Location = new System.Drawing.Point(346, 149);
            this.btnUpdateMentorPhoto.Name = "btnUpdateMentorPhoto";
            this.btnUpdateMentorPhoto.Size = new System.Drawing.Size(100, 26);
            this.btnUpdateMentorPhoto.TabIndex = 27;
            this.btnUpdateMentorPhoto.Text = "Update photo";
            this.btnUpdateMentorPhoto.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMentor
            // 
            this.btnRemoveMentor.BackColor = System.Drawing.Color.Red;
            this.btnRemoveMentor.Enabled = false;
            this.btnRemoveMentor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveMentor.Location = new System.Drawing.Point(397, 240);
            this.btnRemoveMentor.Name = "btnRemoveMentor";
            this.btnRemoveMentor.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMentor.TabIndex = 25;
            this.btnRemoveMentor.Text = "Remove";
            this.btnRemoveMentor.UseVisualStyleBackColor = false;
            // 
            // tbxUpdateMentorPhone
            // 
            this.tbxUpdateMentorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateMentorPhone.Location = new System.Drawing.Point(86, 124);
            this.tbxUpdateMentorPhone.Name = "tbxUpdateMentorPhone";
            this.tbxUpdateMentorPhone.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateMentorPhone.TabIndex = 24;
            // 
            // tbxUpdateMentorEmail
            // 
            this.tbxUpdateMentorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateMentorEmail.Location = new System.Drawing.Point(86, 96);
            this.tbxUpdateMentorEmail.Name = "tbxUpdateMentorEmail";
            this.tbxUpdateMentorEmail.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateMentorEmail.TabIndex = 23;
            // 
            // tbxUpdateMentorSurname
            // 
            this.tbxUpdateMentorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateMentorSurname.Location = new System.Drawing.Point(86, 65);
            this.tbxUpdateMentorSurname.Name = "tbxUpdateMentorSurname";
            this.tbxUpdateMentorSurname.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateMentorSurname.TabIndex = 22;
            // 
            // tbxUpdateMentorName
            // 
            this.tbxUpdateMentorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUpdateMentorName.Location = new System.Drawing.Point(86, 37);
            this.tbxUpdateMentorName.Name = "tbxUpdateMentorName";
            this.tbxUpdateMentorName.Size = new System.Drawing.Size(182, 22);
            this.tbxUpdateMentorName.TabIndex = 21;
            // 
            // rbxUpdateMentorBio
            // 
            this.rbxUpdateMentorBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbxUpdateMentorBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbxUpdateMentorBio.Location = new System.Drawing.Point(6, 168);
            this.rbxUpdateMentorBio.Name = "rbxUpdateMentorBio";
            this.rbxUpdateMentorBio.Size = new System.Drawing.Size(262, 90);
            this.rbxUpdateMentorBio.TabIndex = 20;
            this.rbxUpdateMentorBio.Text = "";
            // 
            // btnUpdateMentor
            // 
            this.btnUpdateMentor.Enabled = false;
            this.btnUpdateMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateMentor.Location = new System.Drawing.Point(316, 240);
            this.btnUpdateMentor.Name = "btnUpdateMentor";
            this.btnUpdateMentor.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMentor.TabIndex = 19;
            this.btnUpdateMentor.Text = "Update";
            this.btnUpdateMentor.UseVisualStyleBackColor = true;
            this.btnUpdateMentor.Click += new System.EventHandler(this.btnUpdateMentor_Click);
            // 
            // pbxUpdateMentorPhoto
            // 
            this.pbxUpdateMentorPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxUpdateMentorPhoto.ErrorImage")));
            this.pbxUpdateMentorPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxUpdateMentorPhoto.Image")));
            this.pbxUpdateMentorPhoto.Location = new System.Drawing.Point(346, 31);
            this.pbxUpdateMentorPhoto.Name = "pbxUpdateMentorPhoto";
            this.pbxUpdateMentorPhoto.Size = new System.Drawing.Size(100, 112);
            this.pbxUpdateMentorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUpdateMentorPhoto.TabIndex = 18;
            this.pbxUpdateMentorPhoto.TabStop = false;
            // 
            // lblUpdateMentorBio
            // 
            this.lblUpdateMentorBio.AutoSize = true;
            this.lblUpdateMentorBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateMentorBio.Location = new System.Drawing.Point(6, 149);
            this.lblUpdateMentorBio.Name = "lblUpdateMentorBio";
            this.lblUpdateMentorBio.Size = new System.Drawing.Size(34, 16);
            this.lblUpdateMentorBio.TabIndex = 17;
            this.lblUpdateMentorBio.Text = "Bio :";
            // 
            // lblUpdateMentorEmail
            // 
            this.lblUpdateMentorEmail.AutoSize = true;
            this.lblUpdateMentorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateMentorEmail.Location = new System.Drawing.Point(6, 99);
            this.lblUpdateMentorEmail.Name = "lblUpdateMentorEmail";
            this.lblUpdateMentorEmail.Size = new System.Drawing.Size(48, 16);
            this.lblUpdateMentorEmail.TabIndex = 16;
            this.lblUpdateMentorEmail.Text = "Email :";
            // 
            // lblUpdateMentorPhone
            // 
            this.lblUpdateMentorPhone.AutoSize = true;
            this.lblUpdateMentorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateMentorPhone.Location = new System.Drawing.Point(6, 127);
            this.lblUpdateMentorPhone.Name = "lblUpdateMentorPhone";
            this.lblUpdateMentorPhone.Size = new System.Drawing.Size(53, 16);
            this.lblUpdateMentorPhone.TabIndex = 15;
            this.lblUpdateMentorPhone.Text = "Phone :";
            // 
            // lblUpdateMentorSurname
            // 
            this.lblUpdateMentorSurname.AutoSize = true;
            this.lblUpdateMentorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateMentorSurname.Location = new System.Drawing.Point(6, 68);
            this.lblUpdateMentorSurname.Name = "lblUpdateMentorSurname";
            this.lblUpdateMentorSurname.Size = new System.Drawing.Size(68, 16);
            this.lblUpdateMentorSurname.TabIndex = 14;
            this.lblUpdateMentorSurname.Text = "Surname :";
            // 
            // lblUpdateMentorName
            // 
            this.lblUpdateMentorName.AutoSize = true;
            this.lblUpdateMentorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateMentorName.Location = new System.Drawing.Point(6, 40);
            this.lblUpdateMentorName.Name = "lblUpdateMentorName";
            this.lblUpdateMentorName.Size = new System.Drawing.Size(51, 16);
            this.lblUpdateMentorName.TabIndex = 13;
            this.lblUpdateMentorName.Text = "Name :";
            // 
            // lblMentors
            // 
            this.lblMentors.AutoSize = true;
            this.lblMentors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMentors.Location = new System.Drawing.Point(3, 9);
            this.lblMentors.Name = "lblMentors";
            this.lblMentors.Size = new System.Drawing.Size(97, 25);
            this.lblMentors.TabIndex = 35;
            this.lblMentors.Text = "Mentors";
            // 
            // dgvMentorsList
            // 
            this.dgvMentorsList.AutoGenerateColumns = false;
            this.dgvMentorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMentorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentorsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MentorName,
            this.MentorSurname,
            this.MentorEmail,
            this.MentorPhone,
            this.MentorBio,
            this.dataGridViewTextBoxColumn2,
            this.MentorPhoto,
            this.dataGridViewTextBoxColumn3,
            this.Column1});
            this.dgvMentorsList.DataSource = this.mentorsBindingSource;
            this.dgvMentorsList.Location = new System.Drawing.Point(1, 37);
            this.dgvMentorsList.Name = "dgvMentorsList";
            this.dgvMentorsList.Size = new System.Drawing.Size(1197, 191);
            this.dgvMentorsList.TabIndex = 34;
            this.dgvMentorsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMentorsList_CellClick);
            // 
            // mentorsBindingSource
            // 
            this.mentorsBindingSource.DataMember = "Mentors";
            this.mentorsBindingSource.DataSource = this.educationProjectDataSet4;
            // 
            // educationProjectDataSet4
            // 
            this.educationProjectDataSet4.DataSetName = "EducationProjectDataSet4";
            this.educationProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // mentorsTableAdapter
            // 
            this.mentorsTableAdapter.ClearBeforeFill = true;
            // 
            // dtpUpdateGroupStartDate
            // 
            this.dtpUpdateGroupStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpUpdateGroupStartDate.Location = new System.Drawing.Point(137, 180);
            this.dtpUpdateGroupStartDate.Name = "dtpUpdateGroupStartDate";
            this.dtpUpdateGroupStartDate.Size = new System.Drawing.Size(280, 22);
            this.dtpUpdateGroupStartDate.TabIndex = 24;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group name";
            this.GroupName.Name = "GroupName";
            // 
            // programIdDataGridViewTextBoxColumn1
            // 
            this.programIdDataGridViewTextBoxColumn1.DataPropertyName = "ProgramId";
            this.programIdDataGridViewTextBoxColumn1.HeaderText = "Program id";
            this.programIdDataGridViewTextBoxColumn1.Name = "programIdDataGridViewTextBoxColumn1";
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "Teacher id";
            this.TeacherId.Name = "TeacherId";
            // 
            // MentorId
            // 
            this.MentorId.DataPropertyName = "MentorId";
            this.MentorId.HeaderText = "Mentor id";
            this.MentorId.Name = "MentorId";
            // 
            // GroupTypeId
            // 
            this.GroupTypeId.DataPropertyName = "GroupTypeId";
            this.GroupTypeId.HeaderText = "Group type id";
            this.GroupTypeId.Name = "GroupTypeId";
            // 
            // GroupStartDate
            // 
            this.GroupStartDate.DataPropertyName = "GroupStartDate";
            this.GroupStartDate.HeaderText = "Group start date";
            this.GroupStartDate.Name = "GroupStartDate";
            // 
            // GroupEndDate
            // 
            this.GroupEndDate.DataPropertyName = "GroupEndDate";
            this.GroupEndDate.HeaderText = "Group end date";
            this.GroupEndDate.Name = "GroupEndDate";
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "GroupId";
            this.GroupId.HeaderText = "GroupId";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Visible = false;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            // 
            // teacherSurnameDataGridViewTextBoxColumn
            // 
            this.teacherSurnameDataGridViewTextBoxColumn.DataPropertyName = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.teacherSurnameDataGridViewTextBoxColumn.Name = "teacherSurnameDataGridViewTextBoxColumn";
            // 
            // teacherEmailDataGridViewTextBoxColumn
            // 
            this.teacherEmailDataGridViewTextBoxColumn.DataPropertyName = "TeacherEmail";
            this.teacherEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.teacherEmailDataGridViewTextBoxColumn.Name = "teacherEmailDataGridViewTextBoxColumn";
            // 
            // teacherPhoneDataGridViewTextBoxColumn
            // 
            this.teacherPhoneDataGridViewTextBoxColumn.DataPropertyName = "TeacherPhone";
            this.teacherPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.teacherPhoneDataGridViewTextBoxColumn.Name = "teacherPhoneDataGridViewTextBoxColumn";
            // 
            // teacherBioDataGridViewTextBoxColumn
            // 
            this.teacherBioDataGridViewTextBoxColumn.DataPropertyName = "TeacherBio";
            this.teacherBioDataGridViewTextBoxColumn.HeaderText = "Bio";
            this.teacherBioDataGridViewTextBoxColumn.Name = "teacherBioDataGridViewTextBoxColumn";
            // 
            // teacherPhotoDataGridViewTextBoxColumn
            // 
            this.teacherPhotoDataGridViewTextBoxColumn.DataPropertyName = "TeacherPhoto";
            this.teacherPhotoDataGridViewTextBoxColumn.HeaderText = "Teacher photo";
            this.teacherPhotoDataGridViewTextBoxColumn.Name = "teacherPhotoDataGridViewTextBoxColumn";
            this.teacherPhotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // programIdDataGridViewTextBoxColumn
            // 
            this.programIdDataGridViewTextBoxColumn.DataPropertyName = "ProgramId";
            this.programIdDataGridViewTextBoxColumn.HeaderText = "Program id";
            this.programIdDataGridViewTextBoxColumn.Name = "programIdDataGridViewTextBoxColumn";
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // MentorName
            // 
            this.MentorName.DataPropertyName = "MentorName";
            this.MentorName.HeaderText = "Name";
            this.MentorName.Name = "MentorName";
            // 
            // MentorSurname
            // 
            this.MentorSurname.DataPropertyName = "MentorSurname";
            this.MentorSurname.HeaderText = "Surname";
            this.MentorSurname.Name = "MentorSurname";
            // 
            // MentorEmail
            // 
            this.MentorEmail.DataPropertyName = "MentorEmail";
            this.MentorEmail.HeaderText = "Email";
            this.MentorEmail.Name = "MentorEmail";
            // 
            // MentorPhone
            // 
            this.MentorPhone.DataPropertyName = "MentorPhone";
            this.MentorPhone.HeaderText = "Phone";
            this.MentorPhone.Name = "MentorPhone";
            // 
            // MentorBio
            // 
            this.MentorBio.DataPropertyName = "MentorBio";
            this.MentorBio.HeaderText = "Bio";
            this.MentorBio.Name = "MentorBio";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProgramId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Program id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MentorPhoto
            // 
            this.MentorPhoto.DataPropertyName = "MentorPhoto";
            this.MentorPhoto.HeaderText = "MentorPhoto";
            this.MentorPhoto.Name = "MentorPhoto";
            this.MentorPhoto.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MentorId";
            this.Column1.HeaderText = "MentorId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.tabGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet3)).EndInit();
            this.gbxUpdateGroup.ResumeLayout(false);
            this.gbxUpdateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsToGroup)).EndInit();
            this.gbxAddGroup.ResumeLayout(false);
            this.gbxAddGroup.PerformLayout();
            this.tabTeacher.ResumeLayout(false);
            this.tabTeacher.PerformLayout();
            this.gbxSearchTeacher.ResumeLayout(false);
            this.gbxSearchTeacher.PerformLayout();
            this.gbxNewTeacher.ResumeLayout(false);
            this.gbxNewTeacher.PerformLayout();
            this.gbxTeacherUpdate.ResumeLayout(false);
            this.gbxTeacherUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdateTeacherPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).EndInit();
            this.tabMentor.ResumeLayout(false);
            this.tabMentor.PerformLayout();
            this.gbxSearchMentor.ResumeLayout(false);
            this.gbxSearchMentor.PerformLayout();
            this.gbxNewMentor.ResumeLayout(false);
            this.gbxNewMentor.PerformLayout();
            this.gbxUpdateMentor.ResumeLayout(false);
            this.gbxUpdateMentor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdateMentorPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentorsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet4)).EndInit();
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
        private System.Windows.Forms.Label lblSearchByStudentName;
        private System.Windows.Forms.ComboBox cbxSelectEducationPackage;
        private System.Windows.Forms.TextBox tbxSearchStudentByName;
        private System.Windows.Forms.ComboBox cbxSelectGroup;
        private System.Windows.Forms.Label lblSelectGroup;
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
        private System.Windows.Forms.Label lblSearchEducationPackage;
        private System.Windows.Forms.Label lblSearchByTeacherName;
        private System.Windows.Forms.ComboBox cbxSearchTeacherEducationPackage;
        private System.Windows.Forms.TextBox tbxSearchTeacherByName;
        private System.Windows.Forms.ComboBox cbxSearchTeacherGroup;
        private System.Windows.Forms.Label lblSearchGroup;
        private System.Windows.Forms.GroupBox gbxNewTeacher;
        private System.Windows.Forms.Button btnAddNewTeacher;
        private System.Windows.Forms.TextBox tbxNewTeacherPhone;
        private System.Windows.Forms.TextBox tbxNewTeacherEmail;
        private System.Windows.Forms.TextBox tbxNewTeacherSurname;
        private System.Windows.Forms.TextBox tbxNewTeacherName;
        private System.Windows.Forms.Label lblNewTeacherEmail;
        private System.Windows.Forms.Label lblNewTeacherPhone;
        private System.Windows.Forms.Label lblNewTeacherSurname;
        private System.Windows.Forms.Label lblNewTeacherName;
        private System.Windows.Forms.GroupBox gbxTeacherUpdate;
        private System.Windows.Forms.Button btnUpdateTeacherPhoto;
        private System.Windows.Forms.Button btnRemoveTeacher;
        private System.Windows.Forms.TextBox tbxUpdateTeacherPhone;
        private System.Windows.Forms.TextBox tbxUpdateTeacherEmail;
        private System.Windows.Forms.TextBox tbxUpdateTeacherSurname;
        private System.Windows.Forms.TextBox tbxUpdateTeacherName;
        private System.Windows.Forms.RichTextBox rbxUpdateTeacherBio;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.PictureBox pbxUpdateTeacherPhoto;
        private System.Windows.Forms.Label lblUpdateTeacherBio;
        private System.Windows.Forms.Label lblUpdateTeacherEmail;
        private System.Windows.Forms.Label lblUpdateTeacherPhone;
        private System.Windows.Forms.Label lblUpdateTeacherSurname;
        private System.Windows.Forms.Label lblUpdateTeacherName;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.DataGridView dgvTeachersList;
        private EducationProjectDataSet2 educationProjectDataSet2;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private EducationProjectDataSet2TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridView dgvStudentsToGroup;
        private System.Windows.Forms.Button btnAddStudentToGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxSelectWhicGroup;
        private System.Windows.Forms.Label lblSelectWhichGroup;
        private System.Windows.Forms.DataGridView dgvGroupsList;
        private System.Windows.Forms.GroupBox gbxUpdateGroup;
        private EducationProjectDataSet3 educationProjectDataSet3;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private EducationProjectDataSet3TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Label lblUpdateGroupStartDate;
        private System.Windows.Forms.TextBox tbxUpdateGroupName;
        private System.Windows.Forms.Label lblGroupUpdateName;
        private System.Windows.Forms.Label lblGroupUpdateGroupType;
        private System.Windows.Forms.Label lblGroupUpdateMentor;
        private System.Windows.Forms.Label lblGroupUpdateTeacher;
        private System.Windows.Forms.ComboBox cbxUpdateGroupGroupType;
        private System.Windows.Forms.ComboBox cbxUpdateGroupMentor;
        private System.Windows.Forms.ComboBox cbxUpdateGroupTeacher;
        private System.Windows.Forms.Label lblGroupUpdateProgramId;
        private System.Windows.Forms.ComboBox cbxUpdateGroupProgramId;
        private System.Windows.Forms.Button btnShowAllMentors;
        private System.Windows.Forms.GroupBox gbxSearchMentor;
        private System.Windows.Forms.Label lblSearchMentorEducationPackage;
        private System.Windows.Forms.Label lblSearchMentorByName;
        private System.Windows.Forms.ComboBox cbxSearchMentorEducationPackage;
        private System.Windows.Forms.TextBox tbxSearchMentorByName;
        private System.Windows.Forms.ComboBox cbxSearchMentorGroup;
        private System.Windows.Forms.Label lblSearchMentorGroup;
        private System.Windows.Forms.GroupBox gbxNewMentor;
        private System.Windows.Forms.Button btnAddNewMentor;
        private System.Windows.Forms.TextBox tbxNewMentorPhone;
        private System.Windows.Forms.TextBox tbxNewMentorEmail;
        private System.Windows.Forms.TextBox tbxNewMentorSurname;
        private System.Windows.Forms.TextBox tbxNewMentorName;
        private System.Windows.Forms.Label lblNewMentorEmail;
        private System.Windows.Forms.Label lblNewMentorPhone;
        private System.Windows.Forms.Label lblNewMentorSurname;
        private System.Windows.Forms.Label lblNewMentorName;
        private System.Windows.Forms.GroupBox gbxUpdateMentor;
        private System.Windows.Forms.Button btnUpdateMentorPhoto;
        private System.Windows.Forms.Button btnRemoveMentor;
        private System.Windows.Forms.TextBox tbxUpdateMentorPhone;
        private System.Windows.Forms.TextBox tbxUpdateMentorEmail;
        private System.Windows.Forms.TextBox tbxUpdateMentorSurname;
        private System.Windows.Forms.TextBox tbxUpdateMentorName;
        private System.Windows.Forms.RichTextBox rbxUpdateMentorBio;
        private System.Windows.Forms.Button btnUpdateMentor;
        private System.Windows.Forms.PictureBox pbxUpdateMentorPhoto;
        private System.Windows.Forms.Label lblUpdateMentorBio;
        private System.Windows.Forms.Label lblUpdateMentorEmail;
        private System.Windows.Forms.Label lblUpdateMentorPhone;
        private System.Windows.Forms.Label lblUpdateMentorSurname;
        private System.Windows.Forms.Label lblUpdateMentorName;
        private System.Windows.Forms.Label lblMentors;
        private System.Windows.Forms.DataGridView dgvMentorsList;
        private System.Windows.Forms.Label lblNewTeacherEducationPackage;
        private System.Windows.Forms.ComboBox cbxNewTeacherEducationPackage;
        private EducationProjectDataSet4 educationProjectDataSet4;
        private System.Windows.Forms.BindingSource mentorsBindingSource;
        private EducationProjectDataSet4TableAdapters.MentorsTableAdapter mentorsTableAdapter;
        private System.Windows.Forms.Label lblNewMentorEducationPackage;
        private System.Windows.Forms.ComboBox cbxNewMentorEducationPackage;
        private System.Windows.Forms.DateTimePicker dtpUpdateGroupStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherBioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorBio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}