using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvvshestd
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int dec = Convert.ToInt32(x, 16);
            Console.WriteLine(dec);
        }
    }
}
