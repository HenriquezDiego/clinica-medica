﻿using System;

namespace ClinicaMedica.DataAccess.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
