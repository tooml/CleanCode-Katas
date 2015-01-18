using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RömischeZahlen
{
    public class DezimalzahlenWandler
    {
        private Dictionary<string, int> römischeZahlen = new Dictionary<string, int>() 
        { 
            { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } 
        };

        public int ParseRömischeZahlInDezimal(string römischeZahl)
        {
            var zahlen = RömischeZahlInDezimal(römischeZahl);
            var zahlen2 = ZahlenWertBestimmen(zahlen);
            return ZahlenSummieren(zahlen2);
        }

        internal IEnumerable<int> RömischeZahlInDezimal(string römischeZahl)
        {
            return römischeZahl.ToCharArray().Select(x => römischeZahlen[x.ToString()]);
        }

        internal IEnumerable<int> ZahlenWertBestimmen(IEnumerable<int> zahlen)
        {
            zahlen = zahlen.Reverse();
            List<int> zahlenListe = new List<int>();
            zahlen.ToList().ForEach(x =>
            {
                zahlenListe.Add((x < zahlenListe.LastOrDefault()) ? -x : x);
            });
            return zahlenListe;
        }

        internal int ZahlenSummieren(IEnumerable<int> zahlen)
        {
            return zahlen.Sum(x => Convert.ToInt32(x));
        }
    }
}
