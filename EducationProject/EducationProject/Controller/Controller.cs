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

        public static List<Groups> JoinMe(this DbSet<Groups> groups, object _class)
        {
            if (_class is Students)
            {
                var convertedClass = _class as Students;
                return db.Groups.Where(x => x.GroupId == convertedClass.GroupId).ToList();
            }
            else if (_class is Teachers)
            {
                var convertedClass = _class as Teachers;
                return db.Groups.Where(x => x.TeacherId == convertedClass.TeacherId).ToList();
            }
            else if (_class is Mentors)
            {
                var convertedClass = _class as Mentors;
                return db.Groups.Where(x => x.MentorId == convertedClass.MentorId).ToList();
            }
            return null;
        }
    }
}