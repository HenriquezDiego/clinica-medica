namespace ClinicaMedica.DataAccess.Entities
{
    public class HistorialMedicoDetalle
    {
        public int HistorialMedicoDetalleId { get; set; }
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }
        public int Dosis { get; set; }
    }
}