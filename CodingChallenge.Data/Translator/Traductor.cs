using System.Collections.Generic;
using System.Globalization;

namespace CodingChallenge.Data.Translator
{
    internal static class Traductor
    {
        private static readonly CultureInfo _castellano;
        private static readonly CultureInfo _ingles;
        private static readonly CultureInfo _portugues;

        static Traductor()
        {
            _castellano = new CultureInfo("es-ES");
            _ingles = new CultureInfo("en-US");
            _portugues = new CultureInfo("pt-PT");
        }

        public static string Traducir(string texto, Traducible.Idioma idioma) => App_GlobalResources.Translations.ResourceManager.GetString(texto, GetCultureInfo(idioma)) ?? texto;

        private static CultureInfo GetCultureInfo(Traducible.Idioma idioma)
        {
            CultureInfo output;
            Dictionary<Traducible.Idioma, CultureInfo> CultureInfoList = new Dictionary<Traducible.Idioma, CultureInfo>()
            {
                { Traducible.Idioma.Castellano, _castellano },
                { Traducible.Idioma.Ingles,  _ingles },
                { Traducible.Idioma.Portugues,  _portugues}
            };         
            try
            {
                output = CultureInfoList[idioma];
            }
            catch
            {
                output = _castellano;
            }
            return output;
        }
    }
}
