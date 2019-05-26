using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Month?{0}");
            month = int.Parse(Console.ReadLine());

            if (month == 4 || month == 6 || month == 9 || month == 11)
                Console.WriteLine("30 days");
            else if (month == 1 || month == 3 || month ==7 || month == 12 || month == 8 || month == 5)
                Console.WriteLine("31 days");
            else if (month == 2)
                Console.WriteLine("28 days or 29 days");
        }
    }
}
