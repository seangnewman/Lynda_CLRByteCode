using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        
        static void Main(string[] args)
        {

            var foo = new Foo<string>();
            var foo2 = new Foo<int>();

            Console.WriteLine("Hello, World!");

            var rand = new Random();

            if(rand.Next() % 2 == 0)
            {
                Console.WriteLine("It is even");
            }
            else
            {
                Console.WriteLine("It is odd");
            }
        }
    }
}
