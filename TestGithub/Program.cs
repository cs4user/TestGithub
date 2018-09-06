using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Hithub"+
                Environment.NewLine+"Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A + B = " + (a + b).ToString());
            Console.ReadLine();
        }
    }
}
