//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationProject.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentTasks
    {
        public int StudentTaskId { get; set; }
        public System.DateTime TaskStartDate { get; set; }
        public System.DateTime TaskEndDate { get; set; }
        public int TaskId { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> TaskPoint { get; set; }
    
        public virtual Students Students { get; set; }
        public virtual Tasks Tasks { get; set; }
    }
}