﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GenericAccountingDataEntities : DbContext
    {
        public GenericAccountingDataEntities()
            : base("name=GenericAccountingDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<creditor> creditors { get; set; }
        public virtual DbSet<creditoraccount> creditoraccounts { get; set; }
        public virtual DbSet<debtoraccount> debtoraccounts { get; set; }
        public virtual DbSet<debtor> debtors { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
