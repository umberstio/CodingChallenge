using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    interface ICuadrilatero
    {
        decimal Izquierda { get; }
        decimal Derecha { get; }
        decimal BaseSuperior { get; }
        decimal BaseInferior { get; }
    }
}
