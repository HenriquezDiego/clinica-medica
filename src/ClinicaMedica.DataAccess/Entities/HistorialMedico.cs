using System;
using System.Collections.Generic;

namespace ClinicaMedica.DataAccess.Entities
{
    public class HistorialMedico
    {
        public int HistorialMedicoId { get; set; }
        public int? CitaId { get; set; }
        public Cita Cita { get; set; }
        public string Diagnostico { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal PresionSanguinea { get; set; }
        public decimal PasientePeso { get; set; }
        public decimal PasienteEstatura { get; set; }
        public IList<HistorialMedicoDetalle> Detalles { get; set; }
    }
}
