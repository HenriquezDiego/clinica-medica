namespace ClinicaMedica.DataAccess.Entities
{
    public class MedicamentoUnidad
    {
        public int MedicamentoUnidadId { get; set; }
        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }
        public decimal Precio { get; set; }
        
    }
}
