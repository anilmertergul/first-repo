using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvuichni
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string des = Console.ReadLine();
            int bin = Convert.ToInt32(des, 2);   
            int dec = Convert.ToInt32(x, 16);
            Console.WriteLine("dvuichno chislo "+bin);
            Console.WriteLine("shesn chislo "+dec);


        }
    }
}
