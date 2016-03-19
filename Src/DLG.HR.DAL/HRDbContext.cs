using System;
using DLG.Framework.DAL;
using DLG.Core.Config;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using DLG.HR.Contract;
using DLG.Core.Log;

namespace DLG.HR.DAL
{
    public class HRDbContext : DbContextBase
    {
        public HRDbContext()
            : base(CachedConfigContext.Current.DaoConfig.HR, new LogDbContext())
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HRDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Branch> Branchs { get; set; }
    }
}
