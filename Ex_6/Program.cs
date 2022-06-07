using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va numara vocalele
            // dintr-un sir de caractere citit de la tastatura


            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            Pair[] perechi =
            {
                new Pair { Vocala = 'a', Numar = 0 },
                new Pair { Vocala = 'e', Numar = 0 },
                new Pair { Vocala = 'i', Numar = 0 },
                new Pair { Vocala = 'o', Numar = 0 },
                new Pair { Vocala = 'u', Numar = 0 }
            };

            int total = 0;

            CalculeVocale(text, ref perechi, ref total);
            AfisareVocale(perechi, total);
        }


        static void CalculeVocale(string text, ref Pair[] perechi, ref int total)
        {
            foreach (char c in text.ToLower())
            {
                for (int i = 0; i < perechi.Length; i++)
                {
                    if (c.Equals(perechi[i].Vocala))
                    {
                        perechi[i].Numar++;
                        total++;
                    }
                }
            }
        }


        static void AfisareVocale(Pair[] perechi, int total)
        {
            for (int i = 0; i < perechi.Length; i++)
            {
                if (perechi[i].Numar > 0)
                {
                    Console.WriteLine($"\nTextul contine {perechi[i].Numar} vocale \"{perechi[i].Vocala}\"");
                }
            }
            Console.WriteLine($"\nIn total avem {total} vocale");
        }

        public class Pair
        {
            public char Vocala { get; set; }
            public int Numar { get; set; }
        }

    }
}
