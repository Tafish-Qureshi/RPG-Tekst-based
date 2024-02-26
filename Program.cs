using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbased
{
    class Program
    {   
        public static Player currentPlayer = new Player();
        public static Encounters encounters = new Encounters();
        static void Main(string[] args)
        {
            Start();
            encounters.FirstEncounter(); //Starts the first encounter with the player and the thieves 
        }
        


        static void Start() {
            Console.WriteLine("Welkom tot het spel genaamd Tales of Adventure! Wat is je Naam?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Je Werd wakker in een kroeg, je weet niet meer wie je bent of wat je hier doet.");
            Console.WriteLine("Je kijkt vragend om je heen en vraagt je af wat er is gebeurd?.");
            if(currentPlayer.name == "")
                Console.WriteLine("Je weet je naam niet meer, probeer opnieuw");
            else
                Console.WriteLine("Je weet dat je naam is " + currentPlayer.name);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("De barman kijkt je aan en zegt: 'Je bent hier gisteren binnengekomen en je was dronken.'");
                Console.WriteLine("Je hebt een kamer gehuurd en bent naar bed gegaan.");
                Console.WriteLine("Je hebt de hele dag geslapen en je hebt jezelf opgesloten in je kamer.");
                Console.Write("Hoe lang sliep ik vroeg je dan" + currentPlayer.name + "?");
                Console.WriteLine("De barman antwoordde: 'Je hebt 3 dagen geslapen, je hebt jezelf opgesloten in je kamer en je hebt niemand gezien.'");
                Console.WriteLine("Je kijkt achter de barman en merkt dat er 4 mannen de kelder betreden.");
                Console.WriteLine("Je vraagt de barman wat er aan de hand is en hij vertelt je dat ze iets willen stelen.");
                Console.WriteLine("Je vraagt de barman of je hem kan helpen en hij zegt dat je dat kan doen.");
                Console.WriteLine("Je vraagt de barman wat je moet doen en hij zegt dat je de mannen moet stoppen.");
                Console.WriteLine("Je vraagt de barman of je wapens hebt en hij zegt dat je een zwaard hebt.");
                Console.WriteLine("Je pakt het zwaard en je gaat naar de kelder.");
                Console.WriteLine("Je ziet dat de mannen met de rug naar je toe kijken en je besluit om ze te verrassen.");
        }
    }
}
