﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.Database;
using EducationProject.Controller;
using EducationProject.View;

namespace EducationProject
{
    public partial class Form1 : Form
    {
        EducationProjectEntities db = Controller.Controller.db;
        Users user = new Users();


        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxEmail.Text) || String.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Please fill out all inputs!", "Invalid inputs", MessageBoxButtons.OK);
            }
            else
            {
                if (tbxEmail.Text == "admin" && tbxPassword.Text == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    //adminForm.SetDesktopLocation(DesktopBounds.Width / 2, DesktopBounds.Height / 2);
                    adminForm.Show();
                }
                else
                {

                    if (db.Users.ToList().Exists(x => x.UserEmail == tbxEmail.Text))
                    {
                        user = db.Users.ToList().Find(x => x.UserEmail == tbxEmail.Text);
                    }
                    UserTypes userType = db.UserTypes.ToList().Find(x => x.UserTypeId == user.UserTypeId);

                    if (tbxPassword.Text == user.UserPassword  && cbxUserType.SelectedItem.ToString()==userType.UserTypeName)
                    {
                        switch (cbxUserType.SelectedItem.ToString())
                        {
                            case "Student":
                                Controller.Controller.user = user;
                                StudentsForm studentsForm = new StudentsForm();
                                studentsForm.Show();
                                break;

                            case "Teacher":
                                Controller.Controller.user = user;
                                TeacherForm teacherForm = new TeacherForm();
                                teacherForm.Show();
                                break;

                            case "Mentor":
                                Controller.Controller.user = user;
                                MentorForm mentorForm = new MentorForm();
                                mentorForm.Show();
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inputs are invalid!", "Invalid inputs", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var userType in db.UserTypes.ToList())
            {
                cbxUserType.Items.Add(userType.UserTypeName);
            }
            cbxUserType.SelectedIndex = 0;
        }
    }
}
