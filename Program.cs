using System;
using Jogo_RPG_Usando_POO.src.Entities;

namespace Jogo_RPG_Usando_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 45, "Knight");
            Wizard wizard = new Wizard("Jennica", 53, "Magic");
            BlackWizard blackWizard = new BlackWizard("Topapa", 46, "Black Wizard");
            Ninja ninja = new Ninja("Wedge", 49, "Ninja");

            Console.WriteLine(arus.Attack());

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(8));

            Console.WriteLine(blackWizard.Attack(3));
            Console.WriteLine(blackWizard.Attack(7));

            Console.WriteLine(ninja.Attack(2));
            Console.WriteLine(ninja.Attack(9));

        }
    }
}
