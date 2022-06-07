using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va afisa pozitia unui substring intr-un string,
            // ambele siruri de caractere fiind citite de la tastatura


            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            Console.WriteLine("\nIntroduceti fragmentul");
            string fragment = Console.ReadLine();

           
            if (!text.Contains(fragment))
            {
                Console.WriteLine("Fragmentul nu se gaseste in text");
                return;
            }


            int index = text.IndexOf(fragment) + 1;

            Console.Write($"\nFragmentul incepe de la pozitia --> {index} ");
            Console.Write($"si se termina la pozitia --> {index + fragment.Length - 1}");
        }
    }
}
