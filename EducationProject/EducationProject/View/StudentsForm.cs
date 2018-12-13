using EducationProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View
{
    public partial class StudentsForm : Form
    {
        EducationProjectEntities db = Controller.Controller.db;
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            Students stud = db.Students.ToList().Find(x => x.UserId == Controller.Controller.user.UserId);
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
            }
            lblStudentGroupValue.Text = groupName;
        }
    }
}
