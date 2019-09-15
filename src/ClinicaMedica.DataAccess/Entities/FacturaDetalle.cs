namespace ClinicaMedica.DataAccess.Entities
{
    public class FacturaDetalle
    {
        public int FacturaDetalleId { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad  { get; set; }
        public decimal Precio { get; set; }
    }
}