using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    public class TrapecioRectangulo : ITrapecioRectCalculable
    {
        public decimal BaseMayor { get; }

        public decimal BaseMenor { get; }

        public decimal Altura { get; }

        public decimal Hipotenusa { get; }

        public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            if (baseMayor <= baseMenor)
                throw new ArgumentException($"La base mayor debe ser mas grande que la base menor");

            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;

            double cat1 = Convert.ToDouble(baseMayor - baseMenor);
            double cat2 = Convert.ToDouble(altura);
            Hipotenusa = Convert.ToDecimal(Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2)));
        }

        public decimal CalcularArea() => (Altura) * ((BaseMayor + BaseMenor) / 2);

        public decimal CalcularPerimetro() => BaseMayor + BaseMayor + BaseMenor + Hipotenusa;
    }
}
