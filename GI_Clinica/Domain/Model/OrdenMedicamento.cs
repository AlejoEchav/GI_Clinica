using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI_Clinica.Domain.Model
{
    public class OrdenMedicamento
    {
        public int IdOrdenMedicamento { get; set; }
        public int IdOrden { get; set; }
        public int NumeroItem { get; set; }
        public int IdMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public string Dosis { get; set; }
        public string DuracionTratamiento { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Subtotal => Cantidad * CostoUnitario;
    }
}
