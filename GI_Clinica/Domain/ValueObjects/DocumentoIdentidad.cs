using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI_Clinica.Domain.ValueObjects
{
    public class DocumentoIdentidad
    {
        public string Value { get; private set; }

        public DocumentoIdentidad(string value)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d+$"))
                throw new ArgumentException("El documento solo puede contener numeros.");

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El documento no puede estar vacio.");

            if (value.Length < 6 || value.Length > 15)
                throw new ArgumentException("El documento debe tener entre 6 y 15 caracteres.");

            Value = value;

        }

        public override string ToString() => Value;
    }
}
