﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cs_bazy_comic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_WebtoonsEntities : DbContext
    {
        public db_WebtoonsEntities()
            : base("name=db_WebtoonsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<for_publishers> for_publishers { get; set; }
        public virtual DbSet<orig_publishers> orig_publishers { get; set; }
        public virtual DbSet<webtoon> webtoons { get; set; }
    }
}
