using System;
namespace Trekant
/*
 *  I Udregner.cs ligger alt kode til at tage imod bruger input,
 * og finde ud af hvilken type trekant der er tale om.
 */
{
    public class Udregner
    {
        public void udregner()
        {
            while (true)
            {

                decimal sideA, sideB, sideC; // jeg bruger decimal da dette tilader brugeren både at indtaste hel
                                             // og decimaltal

                Console.WriteLine("Check om din trekant er ligesidet, uligesidet eller ligebenet");
                Console.WriteLine("\n\n");

                Console.WriteLine("Intast venligst 1. side af din trekant:");
                sideA = Convert.ToDecimal(Console.ReadLine()); // default inputtype for Readline er string, 
                                                               // derfor er vi nødt til at konvertere til decimal ellers kan vi ikke bruge user input til udregning

                Console.WriteLine("Intast venligst 2. side af din trekant:");
                sideB = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Intast venligst 3. side af din trekant:");
                sideC = Convert.ToDecimal(Console.ReadLine());


                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("Dette er en ligesidet trekant. \n");
                }

                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    Console.WriteLine("Dette er en ligebenet trekant \n");
                }

                else
                {
                    Console.WriteLine("Dette er en uligesidet trekant \n\n");
                }

            }
        }
    }
}