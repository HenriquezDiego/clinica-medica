﻿using System;

namespace ClinicaMedica.DataAccess.Entities
{
    public class Cita
    {
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int EstadoCitaId { get; set; }
        public Estado EstadoCita { get; set; }

    }
}
