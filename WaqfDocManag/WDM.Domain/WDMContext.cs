using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace WDM.Domain
{
    public class WDMContext : DbContext
    {
        public WDMContext() : base(ModelHelper.FamilyConnection)
        {
        }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentForward> DocumentForwards { get; set; }
        public virtual DbSet<DocumentReponse> DocumentReponses { get; set; }
        public virtual DbSet<DocumentAppointment> DocumentAppointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
    
}
