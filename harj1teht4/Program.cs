using System;
using static System.Console;

namespace harj1teht4
{
    class Program
    {

        static void Main(string[] args)
        {
            //ohjelman käyttäjältä kysytyt inputit kommentoitu pois päältä, toimii PiirraKolmio(int) muuttamalla

            //string korkeus;
            //int koko;

            //Write("Anna kolmion korkeus: ");
            //korkeus = ReadLine();
            //koko = int.Parse(korkeus);
            //WriteLine("");

            PiirraKolmio(5);
            //PiirraKolmio(koko);

            ReadKey();
        }

        static void PiirraKolmio(int koko)
        {
            {

                for (int v = 0; v < koko; v++)
                {
                    for (int s = v + 1; s < koko; s++)
                    {
                        Write(" ");
                    }

                    for (int tahti = v; tahti >= 0; tahti--)
                    {
                        Write("*");
                    }

                    WriteLine();
                }
            }
        }

    }
}
