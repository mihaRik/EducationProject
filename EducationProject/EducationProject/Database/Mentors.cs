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
    
    public partial class Mentors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mentors()
        {
            this.Groups = new HashSet<Groups>();
        }
    
        public int MentorId { get; set; }
        public int ProgramId { get; set; }
        public int UserId { get; set; }
        public string MentorName { get; set; }
        public string MentorSurname { get; set; }
        public string MentorEmail { get; set; }
        public string MentorPhone { get; set; }
        public string MentorPhoto { get; set; }
        public string MentorBio { get; set; }
    
        public virtual EducationPackages EducationPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groups> Groups { get; set; }
        public virtual Users Users { get; set; }
    }
}
