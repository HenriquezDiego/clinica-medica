using System;
using System.Collections.Generic;

namespace ClinicaMedica.DataAccess.Entities
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public string Prefijo  { get; set; }
        public  string Correlativo { get; set; }
        public string Comentario  { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime FechaEmision { get; set; }
        public IList<FacturaDetalle> Detalles { get; set; }
    }
}
