using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica.Printer
{
    internal static class TagsExtension
    {
        public static string ToH1(this string text)
        {
            return string.Concat("<h1>", text, "</h1>");
        }

        public static string BR = "<br/>";
    }
}
