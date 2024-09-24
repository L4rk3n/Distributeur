using System;

class DistributeurBoissons
{
    const int LIMITE_MAX = 3;

    static void Main()
    {
        int[] stocks = { 3, 0, 2 };
        string[] noms = { "Eau", "Soda", "Orangeade" };

        int totalStock = 0;
        for (int i = 0; i < LIMITE_MAX; i++)
        {
            totalStock += stocks[i];
        }

        int choix = 0;

        while (totalStock > 0 && choix != 4)
        {
            Console.WriteLine("Choisissez une boisson.");
            for (int i = 0; i < LIMITE_MAX; i++)
            {
                Console.WriteLine($"{noms[i]} : {i + 1}");
            }
            Console.WriteLine("FINIR : 4");

            choix = int.Parse(Console.ReadLine());

            if (choix != 4)
            {
                if (stocks[choix - 1] > 0)
                {
                    Console.WriteLine($"Voici votre {noms[choix - 1]}, santé!");
                    stocks[choix - 1]--;
                }
                else
                {
                    Console.WriteLine($"Plus de {noms[choix - 1]}");
                }
            }

            totalStock = 0;
            for (int i = 0; i < LIMITE_MAX; i++)
            {
                totalStock += stocks[i];
            }
        }

        Console.WriteLine("Merci d'utiliser distributeur 3000!");
    }
}
