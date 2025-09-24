using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI_Clinica.Domain.ValueObjects
{
    public class Telefono
    {
        public string Value { get; private set; }

        public Telefono(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El teléfono no puede estar vacío.");

            if (value.Length != 10)
                throw new ArgumentException("El teléfono debe tener 10 dígitos.");

            Value = value;
        }

        public override string ToString() => Value;
    }
}
