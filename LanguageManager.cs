using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public static class LanguageManager
    {
        public static CultureInfo CurrentCulture { get; private set; } = new CultureInfo("uk-UA");

        public static void SetCulture(string cultureName)
        {
            CurrentCulture = new CultureInfo(cultureName);
        }
    }
}
