//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Designation
    {
        public Designation()
        {
            this.Teachers = new HashSet<Teacher>();
        }
    
        public int designationID { get; set; }
        public string designationName { get; set; }
    
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
