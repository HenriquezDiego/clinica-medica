namespace ClinicaMedica.DataAccess.Entities
{
    public class Medicamento
    {
        public int MedicamentoId { get; set; }
        public string Nombre { get; set; }
        public string Indicaciones { get; set; }
        public string Contraindicaciones { get; set; }
    }
}