namespace ClinicaMedica.DataAccess.Entities
{
    public class HistorialMedicoDetalle
    {
        public int HistorialMedicoDetalleId { get; set; }
        public int MedicamentoUnidadId { get; set; }
        public MedicamentoUnidad MedicamentoUnidad { get; set; }
        public int Dosis { get; set; }
    }
}