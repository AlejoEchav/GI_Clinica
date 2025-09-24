using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI_Clinica.Domain.Model
{
    public class OrdenAyudaDiagnostica
    {
        public int IdOrdenAyuda { get; set; }
        public int IdOrden { get; set; }
        public int NumeroItem { get; set; }
        public int IdAyuda { get; set; }
        public string NombreAyuda { get; set; }
        public int Cantidad { get; set; }
        public bool RequiereEspecialista { get; set; }
        public int? IdEspecialidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Subtotal => Cantidad * CostoUnitario;
    }
}
