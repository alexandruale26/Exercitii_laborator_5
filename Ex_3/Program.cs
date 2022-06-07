using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere .
            // Atat caracterul cautat cat si sirul de caracter vor fi citite de la tastatura;


            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            Console.WriteLine("\nIntroduceti caracterul");
            char caracter = char.Parse(Console.ReadLine());

            Console.WriteLine($"\nCaracterul \"{caracter}\" apare de {IndexCaracter(caracter, text)} ori.");
        }

        static int IndexCaracter(char caracter, string text)
        {
            int contor = 0;

            foreach (char c in text.ToLower())
            {
                if (c.Equals(caracter))
                    contor++;
            }
            return contor;
        }
    }
}
