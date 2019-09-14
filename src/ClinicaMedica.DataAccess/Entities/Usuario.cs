namespace ClinicaMedica.DataAccess.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
