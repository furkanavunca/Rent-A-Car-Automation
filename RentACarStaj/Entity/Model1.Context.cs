﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarStaj.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBRentACarEntities1 : DbContext
    {
        public DBRentACarEntities1()
            : base("name=DBRentACarEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAracAlimLog> TblAracAlimLog { get; set; }
        public virtual DbSet<TblAraclar> TblAraclar { get; set; }
        public virtual DbSet<TblDurum> TblDurum { get; set; }
        public virtual DbSet<TblEhliyetTipleri> TblEhliyetTipleri { get; set; }
        public virtual DbSet<TblLogin> TblLogin { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblYetki> TblYetki { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblHasarLog> TblHasarLog { get; set; }
        public virtual DbSet<TblCinsiyet> TblCinsiyet { get; set; }
    }
}