using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GI_Clinica.Domain.ValueObjects;

namespace GI_Clinica.Domain.Model
{
    public class ContactoEmergencia
    {
        public int IdContacto { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Relacion { get; set; }
        public Telefono TelefonoEmergencia { get; set; }
        public int IdPaciente { get; set; }
    }
}
