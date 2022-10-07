using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheMedicine.Data.Entity;
using TheMedicine.Models;

namespace TheMedicine.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<PatientModel> Patients { get; set; } = null!;
        public DbSet<ProtocolModel> Protocols { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем бд с новой схемой
        }

    }
}
