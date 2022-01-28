using System;
using DesafioGameDio.Entities;

namespace DesafioGameDio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Kleia = new Wizard("Kleia", 23, "Wizard");
            WhiteMage Glenn = new WhiteMage("Glenn", 23, "WhiteMage");

            Console.WriteLine(Arus);
            Console.WriteLine(Kleia);
            Console.WriteLine(Glenn);

            Console.WriteLine(Kleia.Atack());
            Console.WriteLine(Arus.Atack());
            Console.WriteLine(Glenn.Atack());

        }


    }
}