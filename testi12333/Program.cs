using System;


Console.WriteLine("Syötä numero: ");
Console.WriteLine("1. Näytä työntekijät");
Console.WriteLine("2. Lisää työntekijä");
Console.WriteLine("3. Näytä palkkamaksupäivät");

var vastaus1 = Console.ReadLine();

if (vastaus1 == "1")
{
    Console.WriteLine("Valitse työntekijä: ");

    Console.WriteLine("Lista työntekijöistä"); 
    //lista users

    var vastaus2 = Console.ReadLine();

    if (vastaus2 == "1")
    {
        Console.WriteLine("Matti Meikäläinen, palkka, palkanrakenne, palkkapäivä");

        // nollasta alkuvalikkoon
    }
}
if (vastaus1 == "2")
{
    Console.WriteLine("Syötä työntekijän tiedot: ");
    // tähän tulee listaan lisääminen
    // näytä lista
    Console.WriteLine("Työntekijä lisätty listaan!");
}

if (vastaus1 =="3")
{
    //näytä työntekijöitten palkkapäivät
}

else
{
    //error
}