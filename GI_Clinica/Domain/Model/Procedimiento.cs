using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI_Clinica.Domain.Model
{
    public class Procedimiento
    {
        public int IdProcedimiento { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public bool RequiereEspecialista { get; set; }
        public int? IdEspecialidad { get; set; }
    }
}
