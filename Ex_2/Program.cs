using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care sa verifice daca un sir de
            // caractere citit de la tastatura este sau nu palindrom

            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            // exemplu: ion a luat luni vinul tau la noi
            Palindrom(text);
        }

        static void Palindrom(string text)
        {
            text = text.Replace(" ", string.Empty);

            char[] caractere = text.ToCharArray();
            Array.Reverse(caractere);

            string textInversat = new string(caractere);

            if (text.Equals(textInversat))
                Console.WriteLine("Textul este un palindrom");
            else
                Console.WriteLine("Nu este un palindrom");
        }
    }
}
