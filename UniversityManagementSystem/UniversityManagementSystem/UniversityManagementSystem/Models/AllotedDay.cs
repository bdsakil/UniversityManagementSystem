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
    
    public partial class AllotedDay
    {
        public AllotedDay()
        {
            this.AllotedRooms = new HashSet<AllotedRoom>();
        }
    
        public int dayID { get; set; }
        public string daysName { get; set; }
    
        public virtual ICollection<AllotedRoom> AllotedRooms { get; set; }
    }
}
