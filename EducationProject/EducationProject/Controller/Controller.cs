using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationProject.Database;

namespace EducationProject.Controller
{
    public static class Controller
    {
        public static EducationProjectEntities db = new EducationProjectEntities();
        public static Users user { get; set; }

        public static string HidePassword(string studentPassword)
        {
            string unvisiblePassword = studentPassword;

            for (int i = 0; i < studentPassword.Length - 2; i++)
            {
                unvisiblePassword = unvisiblePassword.Replace(studentPassword[i], '*');
            }

            return unvisiblePassword;
        }
    }
}