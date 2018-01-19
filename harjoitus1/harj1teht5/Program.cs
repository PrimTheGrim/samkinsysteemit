using System;
using static System.Console;

namespace harj1teht5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string koko;
            int korkeus;
            Write("Anna kuusen korkeus: ");
            koko = ReadLine();
            korkeus = int.Parse(koko);
            WriteLine("");
            Joulukuusi(korkeus);
            ReadKey();
        }

        static void Joulukuusi(int korkeus)
        {
            if (korkeus >= 3)
            {

                for (int v = 0; v < korkeus; v++)
                {
                    for (int s = v + 1; s < korkeus; s++)
                    {
                        Write(" ");
                    }

                    for (int tahti = 2 * v; tahti >= 0; tahti--)
                    {
                        Write("*");
                    }

                    WriteLine();
                }


                int jalka = korkeus - 2;

                for (int i = 0; i < jalka; i++)
                {
                    Write(" ");
                }

                WriteLine("***");

                for (int i = 0; i < jalka; i++)
                {
                    Write(" ");
                }

                WriteLine("***");

            } else
            {
                WriteLine("Numero on alle 3, kuusta ei voi tulostaa");
            }
            
        }

    }
}
