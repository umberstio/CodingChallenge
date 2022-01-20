using CodingChallenge.Data.FormaGeometrica.Shape.Interfarce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    public class Rectangulo : IRectangulo
    {
        public decimal Ancho { get; }

        public decimal Alto { get; }

        public Rectangulo(decimal alto, decimal ancho)
        {
            Alto = alto;
            Ancho = ancho;
        }
        public decimal CalcularArea() => Alto * Ancho;

        public decimal CalcularPerimetro() => (2 * Ancho) + (2 * Alto);

    }
}
