using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]); 
            Console.WriteLine(number[2]);

            number[1] = 10;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            bool[] flag = new bool[10];
            flag[4] = true;
            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[4]);
          

        }
    }
}
