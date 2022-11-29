using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DummyBazaarBerko.Models
{
    public partial class DummyBazaarBerko : DbContext
    {
        public DummyBazaarBerko()
            : base("name=DummyBazaarBerko")
        {
        }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagerType> ManagerTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
