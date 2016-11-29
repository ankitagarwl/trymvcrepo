namespace Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class trymvc1DataContext : DbContext
    {
        public trymvc1DataContext()
            : base("name=trymvc1DataContext")
        {
        }

        public virtual DbSet<StoreMaster> StoreMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
