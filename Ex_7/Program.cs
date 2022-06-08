using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va citi doua siruri de caractere de la tastatura
            // si va verifica daca cele doua siruri de caractere sunt anagrame


            string text1 = CitireText();
            string text2 = CitireText();

            Console.WriteLine(VerificareAnagrame(text1, text2) ? "\nSunt anagrame" : "\nNu sunt anagrame");
        }


        static string CitireText()
        {
            Console.WriteLine("Introduceti textul\n");
            return Console.ReadLine();
        }

        static bool VerificareAnagrame(string text1, string text2)
        {
            text1 = text1.Replace(" ", string.Empty);
            text2 = text2.Replace(" ", string.Empty);

            if (text1.Length != text2.Length)
                return false;

            char[] caractereText1 = text1.ToLower().ToCharArray();
            char[] caractereText2 = text2.ToLower().ToCharArray();

            Array.Sort(caractereText1);
            Array.Sort(caractereText2);

            text1 = new string(caractereText1);
            text2 = new string(caractereText2);

            return text1 == text2;
        }

    }
}
