//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class LaboratoryCategoryStatu
    {
        public LaboratoryCategoryStatu()
        {
            this.ServiceCategories = new HashSet<ServiceCategory>();
        }
    
        public string Laboratory_CategoryId { get; set; }
        public string CategoryId { get; set; }
        public bool Status { get; set; }
    
        public virtual LaboratoryCategory LaboratoryCategory { get; set; }
        public virtual ICollection<ServiceCategory> ServiceCategories { get; set; }
    }
}
