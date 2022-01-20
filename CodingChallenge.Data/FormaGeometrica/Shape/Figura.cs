using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    public abstract class Figura
    {
        protected readonly decimal _lado;

        public Figura(decimal ancho)
        {
            _lado = ancho;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
