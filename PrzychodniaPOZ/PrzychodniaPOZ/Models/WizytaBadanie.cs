//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrzychodniaPOZ.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WizytaBadanie
    {
        public int WizytaBadanieId { get; set; }
        public int BadanieId { get; set; }
        public Nullable<int> PacjentId { get; set; }
        public System.DateTime DataBadanie { get; set; }
        public System.TimeSpan GodzinaBadanie { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Badanie Badanie { get; set; }
        public virtual Pacjent Pacjent { get; set; }
    }
}
