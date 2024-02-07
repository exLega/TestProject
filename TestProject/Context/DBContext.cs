using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject.Context
{
    public class DBContext : DbContext
    {
        public DbSet<PacientModel> Pacients { get; set; }
        public DbSet<PassportModel> Passports { get; set; }
        public DbSet<MedicalCartModel> MedicalCartModels { get; set; }
        public DbSet<InsurancePolicyModel> InsurancePolicyModels { get; set; }
        public DbSet<HistoryDiseaseModel> HistoryDiseaseModels { get; set; }
        public DbSet<AppealsModel> AppealsModels { get; set; }
        public DbSet<VisitModel> VisitModels { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

    }

}
