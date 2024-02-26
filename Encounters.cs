using System;

namespace textbased {
    class Encounters{

        static Random rand = new Random();
        // Encounter Generic
        
        //Encounters
        public void FirstEncounter() {
            Console.WriteLine("Je Gooit de deur open en je ziet dat de mannen een kist aan het stelen zijn.");
            Console.WriteLine("Je besluit om ze te verrassen en je valt ze aan.");
            Console.ReadKey();
            Combat(false, "Dieven", 4, 4);
            Console.WriteLine("Je hebt de dieven verslagen en je hebt de kist teruggekregen.");
            Console.WriteLine("Je opent de kist en je vindt 10 gouden munten.");
            int amountOfItems = rand.Next(1, 3);
            for(int i = 0; i < amountOfItems; i++) {
                Console.WriteLine("Je vindt een potion");
                Program.currentPlayer.potion++;
            }
            Console.WriteLine("Je hebt 10 gouden munten en " + amountOfItems + " potions gevonden");
            Console.Write("Wil je doorgaan? (J)a (N)ee");
            string input = Console.ReadLine() ?? "";
            if(input == "j" || input == "ja") {
                Console.WriteLine("Je gaat verder");
            }
            else {
                Console.WriteLine("Je gaat terug naar de bar");
            }
        }
        
        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health) {
            string n = " ";
            int p = 0;
            int h = 0;

            if(random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h > 0) {
                Console.WriteLine("*********************");
                Console.WriteLine("| (A)anval  (V)erdedigd |");
                Console.WriteLine("| (R)en     (H)eel| ");
                Console.WriteLine("*********************");
                Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine() ?? "";
                if (input.ToLower() == "a" || input.ToLower() == "aanval")
                {
                    // Aanval
                    Console.WriteLine("Met haast heb je minimale schade toegebracht, " + n + " slaat terug");
                    int damage = p - Program.currentPlayer.armor;
                    if(damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("Je HP is met " + p + " schade verminderd");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "v" || input.ToLower() == "verdedigd")
                {
                    // verdedigd
                    Console.WriteLine("Als je jezelf verdedigd, " + n + " en slaat de vijand terug in je defensieve stand");
                    int damage = (p / 4) - Program.currentPlayer.armor;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("Je HP is met " + p + " schade verminderd");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "ren")
                {
                    // Ren
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("Je probeert te rennen, maar je bent te langzaam en " + n + " slaat je neer");
                        int damage = p - Program.currentPlayer.armor;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("Je HP is met " + damage + " schade verminderd en je kont niet wegrennen");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Je hebt met gekke ninja skills kunnen ontsnappen " + n + "en je bent veilig");
                        Console.ReadKey();
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heel")
                {
                    // Heel
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("Je voelt rond en je hebt geen potions meer");
                        int damage = p - Program.currentPlayer.armor;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("De" + n + " slaat je neer" + damage + "HP");
                    }
                    else
                    {
                        Console.WriteLine("Je reikt naar je zak en je drinkt een potion met een lange slurp");
                        int potionV = 10;
                        Console.WriteLine("Je HP is" + potionV + "verhoogd");
                        Program.currentPlayer.health += potionV;
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
