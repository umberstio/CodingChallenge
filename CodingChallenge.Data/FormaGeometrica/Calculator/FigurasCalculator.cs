using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    internal class FigurasCalculator
    {
        private readonly List<IFigura> _figuras;
        public FigurasCalculator(List<IFigura> figuras)
        {
            _figuras = figuras;
        }
        
        public List<IResultado> Calcular()
        {
            List<IResultado> resultados = new List<IResultado>();
            IResultado figuraMismoTipo;
            string tipoFigura = string.Empty;

            foreach (var figura in _figuras)
            {
                tipoFigura = figura.GetType().Name;          
                
                figuraMismoTipo = resultados.Find(f => f.Tipo == tipoFigura);      
                
                if (figuraMismoTipo != null)
                {
                    figuraMismoTipo.Cantidad += 1;
                    figuraMismoTipo.Area += figura.CalcularArea();
                    figuraMismoTipo.Perimetro += figura.CalcularPerimetro();
                }
                else
                {
                    resultados.Add(new Resultado()
                    {
                        Cantidad = 1,
                        Tipo = tipoFigura,
                        Area = figura.CalcularArea(),
                        Perimetro = figura.CalcularPerimetro()
                    });
                }

                figuraMismoTipo = null;
            }

            return resultados;
        }
    }
}
