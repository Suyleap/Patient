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
    
    public partial class Dating
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public string WorkerId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
