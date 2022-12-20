using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            methods math = new methods();
            Console.WriteLine("Hello, Please enter your favorite number:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered minus 2 = " + math.mathOperation2(input));
            Console.WriteLine("The number you entered times 3 = " + math.mathOperation3(input));
            Console.WriteLine("The number you entered add 4 = " + math.mathOperation4(input));



        }
    }
}
