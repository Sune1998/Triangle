using System;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA, sideB, sideC;
            
            Console.WriteLine("Check om din trekant er ligesidet, uligesidet eller ligebenet");
            Console.WriteLine("\n\n");
            
            Console.WriteLine("Intast venligst 1. side af din trekant:");
            sideA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Intast venligst 2. side af din trekant:");
            sideB = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Intast venligst 3. side af din trekant:");
            sideC = Convert.ToInt32(Console.ReadLine());
              
              
        }
    }
}