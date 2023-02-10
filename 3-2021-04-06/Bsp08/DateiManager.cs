using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp08
{
    public class DateiManager
    {
        internal static string DateiLesen(string dateiPath)
        {
            string inhalt = "";

            // Datei Lesen
            inhalt = File.ReadAllText(dateiPath);

            return inhalt;
        }

        internal static void DateiSchreiben(string dateiPath, string derNeueInhalt)
        {
            File.WriteAllText(dateiPath, derNeueInhalt);
        }
    }
}
