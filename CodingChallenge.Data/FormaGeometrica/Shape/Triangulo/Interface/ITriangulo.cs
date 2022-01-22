using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    interface ITriangulo
    {
        decimal Base { get; }
        decimal Izquierda { get; }
        decimal Derecha { get; }
    }
}
