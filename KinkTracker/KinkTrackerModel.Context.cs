﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KinkTrackerEntities : DbContext
    {
        public KinkTrackerEntities()
            : base("name=KinkTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryOwner> CategoryOwners { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<PagedView> PagedViews { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
        public virtual DbSet<UserOwner> UserOwners { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<KinkRole> KinkRoles { get; set; }
    }
}