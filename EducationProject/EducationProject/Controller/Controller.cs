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
    }
}