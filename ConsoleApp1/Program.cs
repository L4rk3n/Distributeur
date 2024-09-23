using System;

class Program
{
    static void Main()
    {
        int stock1 = 5; 
        int stock2 = 2; 
        int stock3 = 0; 
        int choix;

        Console.WriteLine("Veuillez sélectionner une boisson :");
        Console.WriteLine("1. Eau");
        Console.WriteLine("2. Soda");
        Console.WriteLine("3. Orangeade");

        choix = int.Parse(Console.ReadLine());

        switch (choix)
        {
            case 1:
                if (stock1 != 0)
                {
                    Console.WriteLine("Voici votre eau");
                    stock1--;
                }
                else
                {
                    Console.WriteLine("Sold out!");
                }
                break;
            case 2:
                if (stock2 != 0)
                {
                    Console.WriteLine("Voici votre soda");
                    stock2--;
                }
                else
                {
                    Console.WriteLine("Sold out!");
                }
                break;
            case 3:
                if (stock3 != 0)
                {
                    Console.WriteLine("Voici votre orangeade");
                    stock3--;
                }
                else
                {
                    Console.WriteLine("Sold out!");
                }
                break;
            default:
                Console.WriteLine("Choix indisponible");
                break;
        }
    }
}
