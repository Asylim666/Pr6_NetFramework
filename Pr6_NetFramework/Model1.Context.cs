﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pr6_NetFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForKitchenEntities3 : DbContext
    {
        public ForKitchenEntities3()
            : base("name=ForKitchenEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Punkt_vidachi> Punkt_vidachi { get; set; }
        public virtual DbSet<Role2> Role2 { get; set; }
        public virtual DbSet<Tovari> Tovaris { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Zakaz> Zakazs { get; set; }
    }
}
