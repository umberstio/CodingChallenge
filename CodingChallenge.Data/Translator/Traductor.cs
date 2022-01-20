using System.Collections.Generic;
using System.Globalization;

namespace CodingChallenge.Data.Translator
{
    internal  class Traductor: Traducible
    {
        private static readonly Dictionary<Idioma, string> CultureInfoList = new Dictionary<Idioma, string>()
            { { Idioma.Castellano,  "es-ES" }, { Idioma.Ingles,  "en-US" }, { Idioma.Portugues, "pt-PT" } };

        public static string Traducir(string texto, Idioma idioma) => App_GlobalResources.Translations.ResourceManager.GetString(texto, GetCultureInfo(idioma)) ?? texto;

        private static CultureInfo GetCultureInfo(Idioma idioma)
        {
            CultureInfo output;
            try
            {
                output = new CultureInfo(CultureInfoList[idioma]);
            }
            catch
            {
                output = new CultureInfo("es-ES");
            }
            return output;
        }
    }
}
