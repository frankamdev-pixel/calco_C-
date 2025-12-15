using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("🧮 Calculatrice simple en C#");
        Console.WriteLine("===========================\n");

        while (true)
        {
            try
            {
                Console.Write("Entrez le premier nombre : ");
                double a = double.Parse(Console.ReadLine()!);

                Console.Write("Entrez l'opérateur (+ - * /) : ");
                string op = Console.ReadLine()!.Trim();

                Console.Write("Entrez le second nombre : ");
                double b = double.Parse(Console.ReadLine()!);

                double resultat = op switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => b != 0 ? a / b : throw new DivideByZeroException(),
                    _ => throw new InvalidOperationException()
                };

                Console.WriteLine($"\n➤ {a} {op} {b} = {resultat}\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("❌ Erreur : division par zéro !\n");
            }
            
            catch
            {
                Console.WriteLine("❌ Erreur : entrée invalide ou opérateur inconnu.\n");
            }

            Console.Write("Continuer ? (o/n) : ");
            if (Console.ReadLine()!.Trim().ToLower() != "o") break;
        }

        Console.WriteLine("Bye ! 👋");
    }
}