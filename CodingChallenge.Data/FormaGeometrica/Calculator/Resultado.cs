using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    public class Resultado : IResultado
    {
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public decimal Perimetro { get; set; }
        public decimal Area { get; set; }
    }
}
