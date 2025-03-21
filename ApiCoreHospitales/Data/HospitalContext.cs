using ApiCoreHospitales.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreHospitales.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
