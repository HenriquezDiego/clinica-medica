namespace ClinicaMedica.DataAccess.Entities
{
    public class FacturaDetalle
    {
        public int FacturaDetalleId { get; set; }
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }
        public decimal Cantidad  { get; set; }
    }
}