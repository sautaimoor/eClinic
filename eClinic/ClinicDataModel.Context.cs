﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eClinic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Clinic_DBEntities : DbContext
    {
        public Clinic_DBEntities()
            : base("name=Clinic_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<VisitDisease> VisitDiseases { get; set; }
    }
}