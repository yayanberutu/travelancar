﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PinguinAirService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pinguin_airEntities : DbContext
    {
        public pinguin_airEntities()
            : base("name=pinguin_airEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<penerbangan> penerbangan { get; set; }
        public virtual DbSet<penumpang> penumpang { get; set; }
        public virtual DbSet<tiket> tiket { get; set; }
    }
}
