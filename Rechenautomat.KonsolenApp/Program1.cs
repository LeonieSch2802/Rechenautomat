using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechenautomat.KonsolenApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (string eingabe = "-"; eingabe != "";) 
            {
                try
                {
                    Random r = new Random();

                    int punkte = 0;
                    int erg = 0;

                    Console.Write("Lieber Plus(+) oder Minus(-): ");
                    string eingabe1 = Convert.ToString(Console.ReadLine());

                    int zahl1 = r.Next(1, 10);
                    int zahl2 = r.Next(1, 10);

                    if(eingabe1 == "+")
                    {
                        Console.WriteLine("{0} + {1} =  ", zahl1, zahl2);
                        eingabe = Console.ReadLine();
                        erg = zahl1 + zahl2;
                        string ergebnis = Convert.ToString(erg);

                        if(eingabe == ergebnis)
                        {
                            punkte++;
                        }
                        else
                        {
                            Console.WriteLine("Das Ergebnis stimmt nicht. {0} richtige Antworten", punkte);
                        }


                    }
                    else if (eingabe1 == "-")
                    {
                        Console.WriteLine("{0} - {1} =  ", zahl1, zahl2);
                        eingabe = Console.ReadLine();
                        erg = zahl1 - zahl2;
                        string ergebnis = Convert.ToString(erg);

                        if (eingabe == ergebnis)
                        {
                            punkte++;
                        }
                        else
                        {
                            Console.WriteLine("Das Ergebnis stimmt nicht. {0} richtige Antworten", punkte);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Leider falsch. {0} richtige Aufgaben", punkte);
                    }
                    

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    }
}
