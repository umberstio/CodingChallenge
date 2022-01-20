using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Translator;

namespace CodingChallenge.Data.FormaGeometrica.Printer
{
    public class FormasPrinter : Traducible
    {
        private static FormasPrinter instance = null;

        //Etiquetas
        private string lblArea;
        private string lblPerimetro;
        private string lblTotal;
        private string lblFormas;
        private string lblVacia;
        private string lblTitulo;

        protected FormasPrinter() { }

        public static FormasPrinter Instance
        {
            get => instance ?? new FormasPrinter();
        }

        public string Imprimir(List<IFigura> figuras, Idioma idioma)
        {
            string traducir(string texto) => Traductor.Traducir(texto, idioma);

            TraducirEtiquetas(traducir);

            if (!figuras.Any())
                return GetMensajeListaVacia();

            var resultSb = new StringBuilder();

            resultSb.Append(GetTitulo());

            var resultadoList = new FigurasCalculator(figuras).Calcular(); // Obtenemos los calculos del reporte

            resultSb.Append(GetCuerpo(resultadoList, traducir));
            resultSb.Append(GetFooter(resultadoList));

            return resultSb.ToString();
        }

        private void TraducirEtiquetas(Func<string, string> traducir)
        {
            lblArea = traducir("lbl_totales_area");
            lblPerimetro = traducir("lbl_totales_perimetro");
            lblTotal = traducir("lbl_total_general");
            lblFormas = traducir("lbl_formas");
            lblVacia = traducir("lista_vacia_formas");
            lblTitulo = traducir("reporte_formas_titulo");
        }

        private string GetNombreForma(int cantidad, string Tipo)
        {
            return cantidad == 1 ? $"forma_{Tipo.ToLower()}" : $"forma_{Tipo.ToLower()}_plural";
        }

        private string GetMensajeListaVacia() => lblVacia.ToH1();

        private string GetTitulo() => lblTitulo.ToH1();

        private string GetCuerpo(List<IResultado> resultados, Func<string, string> traducir)
        {
            var ourputSb = new StringBuilder();
            foreach (var resultado in resultados.OrderBy(x => x.Tipo))
            {
                var nombreFormaTraducida = traducir(GetNombreForma(resultado.Cantidad, resultado.Tipo));
                ourputSb.Append($"{resultado.Cantidad} {nombreFormaTraducida} | {lblArea} {resultado.Area:#.##} | {lblPerimetro} {resultado.Perimetro:#.##} {TagsExtension.BR}");
            }
            return ourputSb.ToString();
        }

        private string GetFooter(List<IResultado> resultados)
        {
            var outputSb = new StringBuilder();
            outputSb.Append($"{lblTotal}:{TagsExtension.BR}");
            outputSb.Append($"{resultados.Sum(x => x.Cantidad)} {lblFormas} ");
            outputSb.Append($"{lblPerimetro} {resultados.Sum(x => x.Perimetro):#.##} ");
            outputSb.Append($"{lblArea} {resultados.Sum(x => x.Area):#.##}");

            return outputSb.ToString();
        }

    }
}
