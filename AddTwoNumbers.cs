using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int a = 10;
            //int b = 20;
            //int c = a + b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //string name = "chandra";
            //Console.WriteLine(name);
            Console.WriteLine("This is my old value{0}", a);
            Console.WriteLine("Ënter any intiger");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This is my new value", a);
            Console.WriteLine(a);
            //Console.WriteLine("Enter first number :{0}", a);
            //Console.WriteLine("Enter Second number :{0}", b);
            //Console.WriteLine("Total of {0} and {1} is :{2}",b,a, c);
            Console.ReadLine();


        }

    }
}