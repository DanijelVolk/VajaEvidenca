﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Dijak> Dijak { get; set; }
        public virtual DbSet<DijakPodročje> DijakPodročje { get; set; }
        public virtual DbSet<Izvedba> Izvedba { get; set; }
        public virtual DbSet<IzvedbaDijak> IzvedbaDijak { get; set; }
        public virtual DbSet<IzvedbaMentor> IzvedbaMentor { get; set; }
        public virtual DbSet<Memberships> Memberships { get; set; }
        public virtual DbSet<Mentor> Mentor { get; set; }
        public virtual DbSet<PlanDejavnosti> PlanDejavnosti { get; set; }
        public virtual DbSet<PlanDijak> PlanDijak { get; set; }
        public virtual DbSet<PlanSodelavci> PlanSodelavci { get; set; }
        public virtual DbSet<Področja> Področja { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Razredniki> Razredniki { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Slike> Slike { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
