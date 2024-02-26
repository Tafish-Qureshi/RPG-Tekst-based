using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbased {
    class Program {
        public static Player curentPlayer = new Player();
        static void Main(string[] args) {
            start();
        }

        static void start() {
            Console.WriteLine("Tales of Adventure!");
            Console.WriteLine("What is your name?");
            curentPlayer.name = Console.ReadLine();
            if (curentPlayer.name == "") {
                Console.WriteLine("Je moet een naam invoeren!");
                start();
                
            } else if (curentPlayer.name != ""){
                Console.WriteLine("Welcome" + curentPlayer.name + "!" );
                Console.WriteLine("Je wordt wakker in een klein dorpje omringd door weelderige groene velden. Als je om je heen kijkt, zie je een mysterieuze oude man vlakbij staan.");
                Console.WriteLine("De oude man komt naar je toe en zegt: 'Gegroet, jonge avonturier! Ik heb een zoektocht voor je. Ben je klaar om aan een groots avontuur te beginnen?'");
                Console.WriteLine("Je knikt gretig, klaar om aan je reis te beginnen. De oude man overhandigt je een kaart en wijst naar een verre bergketen.");
                Console.WriteLine("'Je zoektocht is om het legendarische Sword of Destiny terug te halen uit de verraderlijke Dragon's Lair. Alleen een echte held kan zijn kracht uitoefenen.'");
                Console.WriteLine("Met een gevoel van opwinding en vastberadenheid ga je op pad voor je epische zoektocht, klaar om de uitdagingen aan te gaan die je te wachten staan.");
                Console.WriteLine("Veel succes, dappere avonturier!");
            }
        }
    }
}