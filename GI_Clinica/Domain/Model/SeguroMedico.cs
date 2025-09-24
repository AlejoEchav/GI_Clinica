using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI_Clinica.Domain.Model
{
    public class SeguroMedico
    {
        public int IdSeguro { get; set; }
        public string NombreCompania { get; set; }
        public string NumeroPoliza { get; set; }
        public bool Estado { get; set; }
        public DateTime Vigencia { get; set; }
        public int IdPaciente { get; set; }
    }
}
