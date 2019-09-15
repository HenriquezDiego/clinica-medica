using System;

namespace ClinicaMedica.DataAccess.Entities
{
    public class Auditoria
    {
        public string CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyOn { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteOn { get; set; }
    }
}