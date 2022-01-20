using System;
using System.Collections.Generic;
using CodingChallenge.Data;
using NUnit.Framework;
using CodingChallenge.Data.FormaGeometrica;
using CodingChallenge.Data.FormaGeometrica.Printer;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        // NUEVOS
        [TestCase(FormasPrinter.Idioma.Castellano, "<h1>Lista vacía de formas!</h1>")]
        [TestCase(FormasPrinter.Idioma.Ingles, "<h1>Empty list of shapes!</h1>")]
        [TestCase(FormasPrinter.Idioma.Portugues, "<h1>Lista vazia de formas!</h1>")]
        public void TestResumenListaVacia(FormasPrinter.Idioma idioma, string expected)
        {
            Assert.AreEqual(expected, FormasPrinter.Instance.Imprimir(new List<IFigura>(), idioma));
        }



        //Cuadrado
        [TestCase("Cuadrado", 1, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25")]
        [TestCase("Cuadrado", 2, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>2 Cuadrados | Area 50 | Perimetro 40 <br/>TOTAL:<br/>2 formas Perimetro 40 Area 50")]
        [TestCase("Cuadrado", 1, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25")]
        [TestCase("Cuadrado", 2, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>2 Squares | Area 50 | Perimeter 40 <br/>TOTAL:<br/>2 shapes Perimeter 40 Area 50")]
        [TestCase("Cuadrado", 1, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>1 Quadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25")]
        [TestCase("Cuadrado", 2, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>2 Quadrados | Area 50 | Perimetro 40 <br/>TOTAL:<br/>2 formas Perimetro 40 Area 50")]
        //Circulo 
        [TestCase("Circulo", 1, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>1 Círculo | Area 19,63 | Perimetro 15,71 <br/>TOTAL:<br/>1 formas Perimetro 15,71 Area 19,63")]
        [TestCase("Circulo", 2, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>2 Círculos | Area 39,27 | Perimetro 31,42 <br/>TOTAL:<br/>2 formas Perimetro 31,42 Area 39,27")]
        [TestCase("Circulo", 1, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>1 Circle | Area 19,63 | Perimeter 15,71 <br/>TOTAL:<br/>1 shapes Perimeter 15,71 Area 19,63")]
        [TestCase("Circulo", 2, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>2 Circles | Area 39,27 | Perimeter 31,42 <br/>TOTAL:<br/>2 shapes Perimeter 31,42 Area 39,27")]
        [TestCase("Circulo", 1, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>1 Círculo | Area 19,63 | Perimetro 15,71 <br/>TOTAL:<br/>1 formas Perimetro 15,71 Area 19,63")]
        [TestCase("Circulo", 2, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>2 Círculos | Area 39,27 | Perimetro 31,42 <br/>TOTAL:<br/>2 formas Perimetro 31,42 Area 39,27")]
        //Triangulo Equilatero
        [TestCase("Triangulo", 1, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>1 Triángulo | Area 10,83 | Perimetro 15 <br/>TOTAL:<br/>1 formas Perimetro 15 Area 10,83")]
        [TestCase("Triangulo", 2, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>2 Triángulos | Area 21,65 | Perimetro 30 <br/>TOTAL:<br/>2 formas Perimetro 30 Area 21,65")]
        [TestCase("Triangulo", 1, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>1 Triangle | Area 10,83 | Perimeter 15 <br/>TOTAL:<br/>1 shapes Perimeter 15 Area 10,83")]
        [TestCase("Triangulo", 2, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>2 Triangles | Area 21,65 | Perimeter 30 <br/>TOTAL:<br/>2 shapes Perimeter 30 Area 21,65")]
        [TestCase("Triangulo", 1, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>1 Triângulo | Area 10,83 | Perimetro 15 <br/>TOTAL:<br/>1 formas Perimetro 15 Area 10,83")]
        [TestCase("Triangulo", 2, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>2 Triângulos | Area 21,65 | Perimetro 30 <br/>TOTAL:<br/>2 formas Perimetro 30 Area 21,65")]
        //Trapecio Rectangulo
        [TestCase("Trapecio", 1, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>1 Trapecio | Area 20 | Perimetro 18,39 <br/>TOTAL:<br/>1 formas Perimetro 18,39 Area 20")]
        [TestCase("Trapecio", 2, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>2 Trapecios | Area 40 | Perimetro 36,77 <br/>TOTAL:<br/>2 formas Perimetro 36,77 Area 40")]
        [TestCase("Trapecio", 1, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>1 Trapezoid | Area 20 | Perimeter 18,39 <br/>TOTAL:<br/>1 shapes Perimeter 18,39 Area 20")]
        [TestCase("Trapecio", 2, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>2 Trapezoids | Area 40 | Perimeter 36,77 <br/>TOTAL:<br/>2 shapes Perimeter 36,77 Area 40")]
        [TestCase("Trapecio", 1, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>1 Trapézio | Area 20 | Perimetro 18,39 <br/>TOTAL:<br/>1 formas Perimetro 18,39 Area 20")]
        [TestCase("Trapecio", 2, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>2 Trapézios | Area 40 | Perimetro 36,77 <br/>TOTAL:<br/>2 formas Perimetro 36,77 Area 40")]
        //Rectangulo
        [TestCase("Rectangulo", 1, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>1 Rectangulo | Area 15 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 15")]
        [TestCase("Rectangulo", 2, FormasPrinter.Idioma.Castellano, "<h1>Reporte de Formas</h1>2 Rectangulos | Area 30 | Perimetro 32 <br/>TOTAL:<br/>2 formas Perimetro 32 Area 30")]
        [TestCase("Rectangulo", 1, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>1 Rectangle | Area 15 | Perimeter 16 <br/>TOTAL:<br/>1 shapes Perimeter 16 Area 15")]
        [TestCase("Rectangulo", 2, FormasPrinter.Idioma.Ingles, "<h1>Shapes report</h1>2 Rectangles | Area 30 | Perimeter 32 <br/>TOTAL:<br/>2 shapes Perimeter 32 Area 30")]
        [TestCase("Rectangulo", 1, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>1 Retângulo | Area 15 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 15")]
        [TestCase("Rectangulo", 2, FormasPrinter.Idioma.Portugues, "<h1>Relatório de Formas</h1>2 Retângulos | Area 30 | Perimetro 32 <br/>TOTAL:<br/>2 formas Perimetro 32 Area 30")]

        public void TestResumenListaConUnTipoDeForma(string forma, int cantidad, FormasPrinter.Idioma idioma, string expected)
        {
            Dictionary<string, IFigura> figurasCreator = new Dictionary<string, IFigura>
            {
                {"cuadrado", new Cuadrado(5)},
                {"triangulo", new TrianguloEquilatero(5)},
                {"circulo", new Circulo(5)},
                {"trapecio", new TrapecioRectangulo(5,3,5) },
                {"rectangulo", new Rectangulo(3,5)}
            };

            var lista = new List<IFigura>();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(figurasCreator[forma.ToLower()]);
            }

            var resumen = FormasPrinter.Instance.Imprimir(lista, idioma);

            Assert.AreEqual(expected, resumen);
        }



        [TestCase]
        public void TestsResumenListaConVariosTiposDeForma()
        {
            var listaFiguras = new List<IFigura>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new TrapecioRectangulo(5,3,5),
                new Rectangulo(3,5)
            };

            string expected = "<h1>Shapes report</h1>2 Circles | Area 13,01 | Perimeter 18,06 <br/>2 Squares | Area 29 | Perimeter 28 <br/>1 Rectangle | Area 15 | Perimeter 16 <br/>1 Trapezoid | Area 20 | Perimeter 18,39 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>9 shapes Perimeter 132,05 Area 126,65";

            Assert.AreEqual(expected, FormasPrinter.Instance.Imprimir(listaFiguras, FormasPrinter.Idioma.Ingles));
        }

    }
}
