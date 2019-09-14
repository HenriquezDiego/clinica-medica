namespace ClinicaMedica.DataAccess.Entities
{
    public class DoctorEspecialidad
    {
        public int DoctorEspecialidadId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}
