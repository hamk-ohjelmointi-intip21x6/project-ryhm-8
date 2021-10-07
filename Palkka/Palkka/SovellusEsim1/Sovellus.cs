using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovellusEsim1
{
    record Työntekijä(string PalkkaTieto, string Nimi, string Ennakonpidätys, string Palkanmaksupäivä);
    record Palkkatieto(string Palkkatietoja, Työntekijä Omistaja);


    class Sovellus
    {
        
        public List<Palkkatieto> Palkkatieto = new List<Palkkatieto>();
        public List<Työntekijä> Työntekijät = new List<Työntekijä>();
        

        /// <param name="työntekijä"
        public void LisääTyöntekijä(Työntekijä työntekijä)
        {
            Työntekijät.Add(työntekijä);
        }
        public void PoistaTyöntekijä(string Nimi)
        {
            var index = Työntekijät.FindIndex(x => x.Nimi == Nimi);
            Työntekijät.RemoveAt(index);
        }

        public string ListaaTyöntekijät()
        {
            string retval = "";
            foreach (var item in Työntekijät)
            {
                retval += $" Nimi:{item.Nimi}\n Palkka:{item.PalkkaTieto}\n Ennakonpidätysprosentti:{item.Ennakonpidätys}\n Palkanmaksupäivä:{item.Palkanmaksupäivä}\n";
            }
            return retval;
        }
        public string ListaaPalkkapäivät()
        {
            string retval = "";
            foreach (var item in Työntekijät)
            {
                retval += $"Nimi:{item.Nimi}\n Palkanmaksupäivä: {item.Palkanmaksupäivä}\n";
            }
            return retval;
        }

    }
}
