using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    interface ITrapecioRect
    {
        decimal BaseMayor { get; }
        decimal BaseMenor { get; }
        decimal Altura { get; }
        decimal Hipotenusa { get; }
    }
}
