//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaEvidenca.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Slike
    {
        public int IDSlika { get; set; }
        public Nullable<int> IzvedbaID { get; set; }
        public byte[] SlikaSl { get; set; }
    
        public virtual Izvedba Izvedba { get; set; }
    }
}
