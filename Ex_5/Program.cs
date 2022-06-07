using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare 
             * cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici
                 Exemplu:
                    Input: Ana ARE mErE
                    Rezultat: Ana Are Mere
            */

            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            string[] cuvinte = ModificareCuvinte(text);
            Afisare(cuvinte);

        }

        static string[] ModificareCuvinte(string text)
        { 
            string[] cuvinte = text.ToLower().Split();

            for (int i = 0; i < cuvinte.Length; i++)
            {
                string aux = string.Empty;

                for (int j = 0; j < cuvinte[i].Length; j++)
                {
                    if (j == 0)
                    {
                        aux += char.ToUpper(cuvinte[i][j]);
                        continue;
                    }
                    aux += cuvinte[i][j];
                }
                cuvinte[i] = aux;
            }
            return cuvinte;
        }

        static void Afisare(string[] cuvinte)
        {
            foreach (string s in cuvinte)
            {
                Console.Write($"{s} ");
            }
        }
    }
}
