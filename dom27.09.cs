using System;

namespace domashno27._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine(); //programa koyato chete dvuichno chislo
            int dec = Convert.ToInt32(bin, 2); 
            string xec = Console.ReadLine();  //programa koyato chete shestnadesetno chislo
            int dec1 = Convert.ToInt32(xec, 16);
            int sumata = dec1 + dec;
            Console.WriteLine(sumata);
        }
    }
}
