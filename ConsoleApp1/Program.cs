using System;

class DistributeurDeBoissons
{
    static void Main()
    {
        int stock1 = 0;
        int stock2 = 2;
        int stock3 = 3;
        int choix;

        do
        {
            Console.WriteLine("Choisissez une boisson. Boisson1: 1, Boisson2: 2, Boisson3: 3, FINIR : 4");
            choix = int.Parse(Console.ReadLine());

            if (choix == 1)
            {
                if (stock1 > 0)
                {
                    Console.WriteLine("Voici votre boisson1, santé!");
                    stock1--;
                }
                else
                {
                    Console.WriteLine("Plus de boisson1");
                }
            }
            else if (choix == 2)
            {
                if (stock2 > 0)
                {
                    Console.WriteLine("Voici votre boisson2, santé!");
                    stock2--;
                }
                else
                {
                    Console.WriteLine("Plus de boisson2");
                }
            }
            else if (choix == 3)
            {
                if (stock3 > 0)
                {
                    Console.WriteLine("Voici votre boisson3, santé!");
                    stock3--;
                }
                else
                {
                    Console.WriteLine("Plus de boisson3");
                }
            }

        } while ((stock1 + stock2 + stock3) > 0 && choix != 4);

        Console.WriteLine("Merci d'utiliser distributeur 3000!");
    }
}

