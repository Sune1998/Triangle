namespace Trekant
{
    /**
     * Denne klasse er main klassen,
     * der er herfra at programmet
     * bliver kørt.
     */
    class Program 
    {
        
        static void Main(string[] args)
        {
           
            Udregner udregner = new Udregner(); // her intanseres et obejkt af beregner klassen 
                                                // og vi kalder udregner metoden.
            udregner.udregner();

        }
        
}
}