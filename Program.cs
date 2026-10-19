namespace Braquage_de_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int numberOfCar = aleatoire.Next(3, 6);
            int numberOfChest;
            float money = 0 ;
            int openchests = 0;
            int closedchests = 0;
            int life = 2;
            float possibleMoney = 0;
            float rank;
            int finalRank;
            Console.WriteLine("---> Gagne le plus d'argent et ne mourrez pas <--- \n\nUn train arrive et il possède " + numberOfCar + " wagons !\n\nCertains coffres sont piégés et vous n'avez que 2 vies... \n\nQuel est ton nom de bandit ?");
            string name = Console.ReadLine();
            Console.WriteLine("\nA toi de jouer " + name + " !");
            for (int i = 1; i < numberOfCar + 1; i++)
            {
                int trap;
                int difficulty;
                difficulty = aleatoire.Next(1, 4);
                numberOfChest = aleatoire.Next(2, 5);
                Console.WriteLine("\n\n--> Tu approche du wagon numéro " + i + " et il contient " + numberOfChest + " Coffres !!!");
                if (difficulty == 1)
                {
                    Console.WriteLine("La chance vous sourit , ce wagon n'est pas sécurisé !!! ( 0% )");
                    for (int o = 1; o < numberOfChest + 1; o++)
                    {
                        int cashInChest;
                        int[] number = { 5, 15, 30, 50, 100 };
                        int index = aleatoire.Next(0, number.Length);                                   //Permet de chosir un nombre aléatoire a partir d'une certaine liste
                        cashInChest = number[index];
                        possibleMoney = possibleMoney + cashInChest;
                        Console.WriteLine("\n\n" + o + ": Voulez-vous ouvrir le coffre numéro " + o + " ? (y/n)");
                        string choice = Console.ReadLine();
                        if (choice == "y")
                        {
                            Console.WriteLine("\nVous ouvrez le coffre numéro " + o + " et trouvez " + cashInChest + "$");
                            money = money + cashInChest;
                            openchests++;
                        }
                        else
                        {
                            Console.WriteLine("Le coffre reste scellé...");
                            closedchests++;
                        }
                    }
                }
                if (difficulty == 2)
                {
                    Console.WriteLine("Faites attention celui-ci est partiellement sécurisé ! ( 25% )");
                    for (int o = 1; o < numberOfChest + 1; o++)
                    {
                        int cashInChest;
                        int[] number = { 5, 15, 30, 50, 100 };
                        int index = aleatoire.Next(0, number.Length);                                   //Permet de chosir un nombre aléatoire a partir d'une certaine liste
                        cashInChest = number[index];
                        possibleMoney = possibleMoney + cashInChest;
                        Console.WriteLine("\n\n" + o + ": Voulez-vous ouvrir le coffre numéro " + o + " ? (y/n)");
                        string choice = Console.ReadLine();
                        if (choice == "y")
                        {
                            trap = aleatoire.Next(1, 5);
                            if (trap == 1)
                            {
                                life--;
                                Console.WriteLine("Oh non le coffre était piégé... \nBOOOOOOOOM !!!\nVous perdez une vie , votre nombre de vie est de " + life + " vies...");
                            }
                            else
                            {
                                Console.WriteLine("\nVous ouvrez le coffre numéro " + o + " et trouvez " + cashInChest + "$");
                                money = money + cashInChest;
                                openchests++;
                            }
                            if (life == 0)
                            {
                                Console.WriteLine("Les authoritées ont retrouvés votre cadavre...\n~~~ GAME OVER ~~~");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Le coffre reste scellé...");
                            closedchests++;
                        }
                    }
                }
                if (difficulty == 3)
                {
                    Console.WriteLine("Le wagon est totalement sécurisé , bonne chance... ( 50 % )");
                    for (int o = 1; o < numberOfChest + 1; o++)
                    {
                        int cashInChest;
                        int[] number = { 5, 15, 30, 50, 100 };
                        int index = aleatoire.Next(0, number.Length);                                   //Permet de chosir un nombre aléatoire a partir d'une certaine liste
                        cashInChest = number[index];
                        possibleMoney = possibleMoney + cashInChest;
                        Console.WriteLine("\n\n" + o + ": Voulez-vous ouvrir le coffre numéro " + o + " ? (y/n)");
                        string choice = Console.ReadLine();
                        if (choice == "y")
                        {
                            trap = aleatoire.Next(1, 3);
                            if (trap == 1)
                            {
                                life--;
                                Console.WriteLine("Oh non le coffre était piégé... \nBOOOOOOOOM !!!\nVous perdez une vie , votre nombre de vie est de " + life + " vies...");
                            }
                            else
                            {
                                Console.WriteLine("\nVous ouvrez le coffre numéro " + o + " et trouvez " + cashInChest + "$");
                                money = money + cashInChest;
                                openchests++;
                            }
                            if (life == 0)
                            {
                                Console.WriteLine("Les authoritées ont retrouvés votre cadavre...\n~~~ GAME OVER ~~~");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Le coffre reste scellé...");
                            closedchests++;
                        }
                    }
                }
            }
            rank = money / possibleMoney;
            rank = rank * 100;
            finalRank = (int)rank;
            Console.WriteLine("\n\nVous vous échappé juste avant que le shérif n'arrive...");
            Console.WriteLine("\n\n~~~ BILAN DU BRAQUAGE ~~~\nWagons visités : " + numberOfCar + "\nNombres de coffres ouverts : " + openchests);
            Console.WriteLine("Nombres de coffres laissés fermé : " + closedchests + "\nArgent totale gagnés :" + money + "$");
            if (finalRank >= 0 && finalRank < 20)
            {
                Console.WriteLine("votre taux de réussite est de " + finalRank + "% ( " + money + "$/" + possibleMoney + "$ )\n\n=== RANK : E ===");
            }
            if (finalRank >= 20 && finalRank < 40)
            {
                Console.WriteLine("votre taux de réussite est de " + finalRank + "% ( " + money + "$/" + possibleMoney + "$ )\n\n=== RANK : D ===");
            }
            if (finalRank >= 40 && finalRank < 60)
            {
                Console.WriteLine("votre taux de réussite est de " + finalRank + "% ( " + money + "$/" + possibleMoney + "$ )\n\n=== RANK : C ===");
            }
            if (finalRank >= 60 && finalRank < 80)
            {
                Console.WriteLine("votre taux de réussite est de " + finalRank + "% ( " + money + "$/" + possibleMoney + "$ )\n\n=== RANK : B ===");
            }
            if (finalRank >= 80 && finalRank < 100)
            {
                Console.WriteLine("votre taux de réussite est de " + finalRank + "% ( " + money + "$/" + possibleMoney + "$ )\n\n=== RANK : A ===");
            }
            if (finalRank == 100)
            {
                Console.WriteLine("votre taux de réussite est de " + finalRank + "% ( " + money + "$/" + possibleMoney + "$ )\n\n=== RANK : S ===");
            }
        }
    }
}
