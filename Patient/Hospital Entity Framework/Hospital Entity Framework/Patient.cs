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
    
    public partial class Patient
    {
        public Patient()
        {
            this.Consultations = new HashSet<Consultation>();
            this.Datings = new HashSet<Dating>();
            this.Laboratories = new HashSet<Laboratory>();
            this.MedicalHistories = new HashSet<MedicalHistory>();
            this.MedicalImagings = new HashSet<MedicalImaging>();
            this.MedicalRecords = new HashSet<MedicalRecord>();
            this.Prescriptions = new HashSet<Prescription>();
            this.VariousDocuments = new HashSet<VariousDocument>();
            this.Visits = new HashSet<Visit>();
            this.Waits = new HashSet<Wait>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public short Age { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public Nullable<short> Weight { get; set; }
        public Nullable<short> Height { get; set; }
    
        public virtual ICollection<Consultation> Consultations { get; set; }
        public virtual ICollection<Dating> Datings { get; set; }
        public virtual ICollection<Laboratory> Laboratories { get; set; }
        public virtual ICollection<MedicalHistory> MedicalHistories { get; set; }
        public virtual ICollection<MedicalImaging> MedicalImagings { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<VariousDocument> VariousDocuments { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<Wait> Waits { get; set; }
    }
}