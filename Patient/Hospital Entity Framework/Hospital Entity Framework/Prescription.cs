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
    
    public partial class Prescription
    {
        public Prescription()
        {
            this.ManagementServices = new HashSet<ManagementService>();
            this.ServiceCategories = new HashSet<ServiceCategory>();
            this.ServiceEstimates = new HashSet<ServiceEstimate>();
            this.VisitServices = new HashSet<VisitService>();
        }
    
        public string Id { get; set; }
        public string WorkerId { get; set; }
        public string PatientId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<ManagementService> ManagementServices { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ICollection<ServiceCategory> ServiceCategories { get; set; }
        public virtual ICollection<ServiceEstimate> ServiceEstimates { get; set; }
        public virtual ICollection<VisitService> VisitServices { get; set; }
    }
}
