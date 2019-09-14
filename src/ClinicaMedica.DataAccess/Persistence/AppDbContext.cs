using ClinicaMedica.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.DataAccess.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<DoctorEspecialidad> DoctorEspecialidad { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public DbSet<HistorialMedico> HistorialesMedicos { get; set; }
        public DbSet<HistorialMedicoDetalle> HistorialMedicoDetalles { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<UnidadMedida> UnidadesDeMedidas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=localhost;Database=ClinicaDbV1.0.0;Integrated Security=true;MultipleActiveResultSets=true;");
        }
    }
}
