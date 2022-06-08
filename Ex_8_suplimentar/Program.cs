using System;

namespace Ex_8_suplimentar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Catalog
                Scrieti un program care va citi de la tastatura un numar n de elevi.
                Elevii vor avea nume, prenume precum si un numar de note m specific fiecarui
                elev si citit si el de la tastatura.
                Notele fiecarui elev vor fi la randul lor citite de la tastatura.
                Programul va afisa informatiile elevului cu media cea mai mare
                nume, prenume ,medie generala.
            */


            Console.WriteLine("Introduceti numarul de elevi din clasa");
            int numarElevi = int.Parse(Console.ReadLine());

            Catalog[] catalogClasaX = CreareCatalog(numarElevi);

            AfisareCatalog(catalogClasaX);
            AfisareElevMedieMax(catalogClasaX);
        }


        public class Catalog
        {
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public int NumarNoteElev { get; set; }
            public int[] Note { get; set; }
            public double MediaGenerala { get; set; }
        }


        static Catalog[] CreareCatalog(int numarElevi)
        {
            Catalog[] catalogAux = new Catalog[numarElevi];
            
            double mediaGeneralaTemp;

            for (int i = 0; i < catalogAux.Length; i++)
            {
                mediaGeneralaTemp = 0;
                catalogAux[i] = new Catalog();

                Console.WriteLine($"\nIntroduceti numele elevului {i + 1}");
                catalogAux[i].Nume = Console.ReadLine();

                Console.WriteLine($"Introduceti prenumele elevului {i + 1}");
                catalogAux[i].Prenume = Console.ReadLine();

                Console.WriteLine($"\nIntroduceti numarul de note al elevului {catalogAux[i].Nume} {catalogAux[i].Prenume}");
                catalogAux[i].NumarNoteElev = int.Parse(Console.ReadLine());

                catalogAux[i].Note = CreareNoteElev(catalogAux[i].NumarNoteElev, ref mediaGeneralaTemp, catalogAux[i].Nume, catalogAux[i].Prenume);

                catalogAux[i].MediaGenerala = mediaGeneralaTemp;
            }

            return catalogAux;
        }


        static int[] CreareNoteElev(int numarNoteElev, ref double mediaGeneralaTemp, string nume, string prenume)
        {
            int[] noteAux = new int[numarNoteElev];

            Console.WriteLine();

            for (int i= 0; i < numarNoteElev; i++)
            {
                Console.WriteLine($"Introduceti nota numarul {i+1} a elevului {nume} {prenume}");
                noteAux[i] = int.Parse(Console.ReadLine());

                mediaGeneralaTemp += noteAux[i];
            }

            mediaGeneralaTemp /= numarNoteElev;

            return noteAux;
        }


        static void AfisareCatalog(Catalog[] catalog)
        {
            for (int i = 0; i < catalog.Length; i++)
            {

                int elevCurent = i + 1;

                Console.WriteLine($"\n\nNumele elevului {elevCurent} este:  {catalog[i].Nume}");

                Console.WriteLine($"Prenumele elevului {elevCurent} este:  {catalog[i].Prenume}");

                Console.WriteLine($"Numarul de note al elevului {catalog[i].Nume} {catalog[i].Prenume} este:  {catalog[i].NumarNoteElev}");

                AfisareNoteElev(catalog[i].Nume, catalog[i].Prenume, catalog[i].Note);

                Console.WriteLine(String.Format("\nMedia generala a elevului {0} {1} este:  {2:N2}\n", catalog[i].Nume, catalog[i].Prenume, catalog[i].MediaGenerala));
            }
        }


        static void AfisareNoteElev(string nume, string prenume, int[] noteElev)
        {
            Console.Write($"Notele elevului {nume} {prenume} sunt:");
            for (int i = 0; i < noteElev.Length; i++)
            {
                Console.Write($"  {noteElev[i]}");
            }
        }


        static int GasireElevMedieMax(Catalog[] catalog)
        {
            int elevMedieMax = 0;
            double ceaMaiMareMedie = 0;

            for (int i = 0; i < catalog.Length; i++)
            {
                if (ceaMaiMareMedie < catalog[i].MediaGenerala)
                {
                    ceaMaiMareMedie = catalog[i].MediaGenerala;
                    elevMedieMax = i;
                }
            }
            return elevMedieMax;
        }


        static void AfisareElevMedieMax(Catalog[] catalog)
        {
            int indexElev = GasireElevMedieMax(catalog);

            Console.WriteLine($"\n\nElevul cu cea mai mare medie generala este {catalog[indexElev].Nume} {catalog[indexElev].Prenume}");
            Console.WriteLine(String.Format("Media generala a acestuia este {0:N2}", catalog[indexElev].MediaGenerala));
        }
    }
}
