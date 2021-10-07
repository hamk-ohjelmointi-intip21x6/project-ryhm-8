using System;
using System.Collections.Generic;

namespace SovellusEsim1
{
    class Program
    {
        static string ohje = "0.Lopetus\n1.Lisää\n2.Listaa\n3.Palkanmaksupäivät\n4.Poista työntekijä";

        static void Main(string[] args)
        {
            Sovellus app = new Sovellus();

            Console.WriteLine(ohje);
            string komento = Console.ReadLine();
            while (!komento.StartsWith("0"))
            {
                switch (komento)
                {
                    case "1":
                        Console.WriteLine("Anna työntekijän nimi: ");
                        var nimi = Console.ReadLine();

                        Console.WriteLine("Anna palkkatiedot: ");
                        var palkkatiedot = Console.ReadLine();

                        Console.WriteLine("Anna ennakonpidätysprosentti: ");
                        var Ennakonpidätys = Console.ReadLine();

                        Console.WriteLine("Anna palkanmaksupäivä: ");
                        var Palkanmaksupäivä = Console.ReadLine();



                        var työntekijä = new Työntekijä(palkkatiedot,nimi,Ennakonpidätys,Palkanmaksupäivä);                        

                        app.LisääTyöntekijä(työntekijä);
                        break;

                    case "2":
                        Console.WriteLine("Lista työntekijöistä: ");
                        Console.WriteLine(app.ListaaTyöntekijät());
                        break;

                    default:
                        break;

                    case "3":
                        Console.WriteLine("Lista palkkapäivistä: ");
                        Console.WriteLine(app.ListaaPalkkapäivät());
                        break;

                    case "4":
                        Console.WriteLine("Syötä poistettavan työntekijän nimi: ");
                        Console.WriteLine(app.ListaaTyöntekijät());
                        var Nimi = Console.ReadLine();
                        app.PoistaTyöntekijä(Nimi);
                        Console.WriteLine(app.ListaaTyöntekijät());
                        break;
                }
                Console.WriteLine(ohje);
                komento = Console.ReadLine();
            }
        }
    }
}
