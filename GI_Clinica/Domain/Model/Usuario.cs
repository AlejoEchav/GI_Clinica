using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GI_Clinica.Domain.ValueObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GI_Clinica.Domain.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public DocumentoIdentidad Cedula { get; set; }
        public Email Correo { get; set; }
        public Telefono Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Direccion Direccion { get; set; }
        public string Rol { get; set; }
        public string UsuarioLogin { get; set; }
        public string Password { get; set; }
    }
}
