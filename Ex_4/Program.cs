using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa caracterul cu numarul cel mai mare de 
               aparitii dintr-un string citit de la tastatura, ignorand caseing-ul literelor

               Exemplu
                  Input: Elena are mere
                  Output: e apare de 5 ori
            */


            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            CelMaiMareCaracter(text);
        }


        static void CelMaiMareCaracter(string text)
        {
            string textModificat = text.ToLower().Replace(" ", "");
            string sirCaractere = EliminareDubluri(textModificat);

            char caracterMaxim = default;
            int max = 0;

            foreach (char c in sirCaractere)
            {
                int contor = 0;

                for (int i = 0; i< textModificat.Length; i++)
                {
                    if (textModificat[i].Equals(c))
                    {
                        contor++;
                    }
                }

                if ( contor >= max)
                {
                    max = contor;
                    caracterMaxim = c;
                }
            }
            Console.WriteLine($"\nCaracterul \"{caracterMaxim}\" apare de {max} ori");
        }


        static string EliminareDubluri(string textModificat)
        {
            string sirCaractere = "";

            foreach (char c in textModificat)
            {
                if (!sirCaractere.Contains(c))
                {
                    sirCaractere += c;
                }
            }
            //Console.WriteLine(sirCaractere);
            return sirCaractere;
        }
    }
}
