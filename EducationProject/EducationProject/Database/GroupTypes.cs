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
    
    public partial class GroupTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupTypes()
        {
            this.Groups = new HashSet<Groups>();
        }
    
        public int GroupTypeId { get; set; }
        public string GroupTypeName { get; set; }
        public int GroupLessonTimeId { get; set; }
    
        public virtual GroupLessonTimes GroupLessonTimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groups> Groups { get; set; }
    }
}
