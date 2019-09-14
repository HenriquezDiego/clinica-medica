using System;
using System.Collections;
using System.Collections.Generic;

namespace ClinicaMedica.DataAccess.Entities
{
    public class HistorialMedico
    {
        public int HistorialMedicoId { get; set; }
        public string Diagnostico { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public decimal PresionSanguinea { get; set; }
        public decimal Peso { get; set; }
        public decimal Estatura { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public IList<HistorialMedicoDetalle> Detalles { get; set; }
    }
}
