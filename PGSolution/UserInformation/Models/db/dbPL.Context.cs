﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserInformation.Models.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_PLEntities : DbContext
    {
        public db_PLEntities()
            : base("name=db_PLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblMstCity> tblMstCities { get; set; }
        public DbSet<tblMstCountry> tblMstCountries { get; set; }
        public DbSet<tblMstState> tblMstStates { get; set; }
        public DbSet<tblUserInfo> tblUserInfoes { get; set; }
    }
}
