using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    public class TrapecioRectangulo : ICuadrilateroCalculable
    {
     
        public decimal Izquierda { get; }

        public decimal Derecha { get; }

        public decimal BaseSuperior { get; }

        public decimal BaseInferior { get; }

        public TrapecioRectangulo(decimal baseInferior, decimal baseSuperior, decimal altura)
        {
            if (baseInferior <= baseSuperior)
                throw new ArgumentException($"La base BaseInferior debe ser mas larga que la base BaseSuperior");

            BaseInferior = baseInferior;
            BaseSuperior = baseSuperior;
            Izquierda = altura;
            Derecha = CalcHipotenusa();
        }

        private decimal CalcHipotenusa()
        {
            double cat1 = Convert.ToDouble(BaseSuperior - BaseInferior);
            double cat2 = Convert.ToDouble(Izquierda);
            return Convert.ToDecimal(Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2)));
        }

        public decimal CalcularArea() => (Izquierda) * ((BaseInferior + BaseSuperior) / 2);

        public decimal CalcularPerimetro() => BaseInferior + BaseSuperior + Izquierda + Derecha;
    }
}
