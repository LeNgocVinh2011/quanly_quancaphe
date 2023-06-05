using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cafe_manager.Models
{
    public partial class DBCafe : DbContext
    {
        public DBCafe()
            : base("name=DBCafe")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BILLINFO> BILLINFOes { get; set; }
        public virtual DbSet<FRUID> FRUIDs { get; set; }
        public virtual DbSet<FRUID_CATEGORIES> FRUID_CATEGORIES { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_STATUS> TBL_STATUS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BILL>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.BILL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FRUID>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.FRUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FRUID_CATEGORIES>()
                .HasMany(e => e.FRUIDs)
                .WithRequired(e => e.FRUID_CATEGORIES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_STATUS>()
                .HasMany(e => e.BILLs)
                .WithRequired(e => e.TBL_STATUS)
                .HasForeignKey(e => e.tbl_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
