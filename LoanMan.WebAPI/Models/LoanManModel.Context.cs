﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanMan.WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LoanManModelContainer : DbContext
    {
        public LoanManModelContainer()
            : base("name=LoanManModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Gender> tbl_Gender { get; set; }
        public virtual DbSet<tbl_Interest_Rate> tbl_Interest_Rate { get; set; }
        public virtual DbSet<tbl_Loan> tbl_Loan { get; set; }
        public virtual DbSet<tbl_Client_Address> tbl_Client_Address { get; set; }
        public virtual DbSet<tbl_Client> tbl_Client { get; set; }
    }
}
