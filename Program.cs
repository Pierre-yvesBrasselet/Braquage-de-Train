namespace Braquage_de_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int numberOfCar = aleatoire.Next(3, 6);
            int numberOfChest;
            int money = 0 ;
            int openchests = 0;
            int closedchests = 0;
            Console.WriteLine("---> Gagne le plus d'argent <--- \n\nUn train arrive et il possède " + numberOfCar + " wagons ! \n\nQuel est ton nom de bandit ?");
            string name = Console.ReadLine();
            Console.WriteLine("\nA toi de jouer " + name + " !");
            for (int i = 1; i < numberOfCar + 1; i++)
            {
                numberOfChest = aleatoire.Next(2, 5);
                Console.WriteLine("\n\n--> Tu approche du wagon numéro " + i + " et il contient " + numberOfChest + " Coffres !!!");
                for (int o = 1; o < numberOfChest + 1; o++)
                {
                    int cashInChest;
                    int[] number = { 5, 15, 30, 50, 100 };
                    int index = aleatoire.Next(0, number.Length);                                   //Permet de chosir un nombre aléatoire a partir d'une certaine liste
                    Console.WriteLine("\n\n" + o + ": Voulez-vous ouvrir le coffre numéro " + o + " ? (y/n)");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        cashInChest = number[index];
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
            Console.WriteLine("\n\nVous vous échappé juste avant que le shérif n'arrive...");
            Console.WriteLine("\n\n~~~ BILAN DU BRAQUAGE ~~~\nWagons visités : " + numberOfCar + "\nNombres de coffres ouverts : " + openchests);
            Console.WriteLine("Nombres de coffres laissés fermé : " + closedchests + "\nArgent totale gagnés :" + money + "$");
        }
    }
}
