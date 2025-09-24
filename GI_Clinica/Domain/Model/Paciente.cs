using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GI_Clinica.Domain.ValueObjects;

namespace GI_Clinica.Domain.Model
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public DocumentoIdentidad Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public Direccion Direccion { get; set; }
        public Telefono Telefono { get; set; }
        public Email Correo { get; set; }
        public string UsuarioPortal { get; set; }
        public string ContrasenaPortal { get; set; }
        public ContactoEmergencia ContactoEmergencia { get; set; }
        public SeguroMedico SeguroMedico { get; set; }
    }
}
