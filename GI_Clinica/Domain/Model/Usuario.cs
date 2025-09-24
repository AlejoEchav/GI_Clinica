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
        public int IdUsuario;
        public string NombreCompleto;
        public DocumentoIdentidad Cedula;
        public Email Correo;
        public Telefono Telefono;
        public DateTime FechaNacimiento;
        public Direccion Direccion;
        public string Rol;
        public string UsuarioLogin;
        public string Password;
    }
}
