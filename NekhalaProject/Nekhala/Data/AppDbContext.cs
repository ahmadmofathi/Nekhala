using Microsoft.EntityFrameworkCore;
using Nekhala.Models;

namespace Nekhala.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        // DB Set
        public DbSet<Admin> admins { get; set; }
        public DbSet<AgricultureDisbursement> agricultureDisbursements { get; set; }
        public DbSet<SupplyDisbursement> supplyDisbursements { get; set; }
        public DbSet<VeterinaryDisbursement> veterinaryDisbursements { get; set; }
    }
}
