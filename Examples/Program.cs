using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Example1();
        }

        static void Example1()
        {
            var names = new string[] { "Ted", "Charlotte", "Micheal", "Mathew" };

            var nameList = new List<string>();
            nameList.Add("Ted");
            nameList.Add("Charlotte");
            nameList.Add("Michael");
            nameList.Add("Mathew");

            foreach (var name in nameList)
            {
                Console.WriteLine($"Found {name}");
            }

        }

        static void Esample2()
        {
            dynamic d1 = "String ";
            dynamic d2 = 32;
            dynamic d3 = new Program();

            Print(d3);
        }

        static void Example3()
        {
            foreach (var name in Names())
            {
                Console.WriteLine($"Found : {name}");
            }


            // Infinit e Loop!  Do not run
            //foreach (var rand in Randoms())
            //{
            //    Console.WriteLine($"Found : {rand}");
            //}
        }
        static IEnumerable<string> Names()
        {
            yield return "Cody";
            yield return "Connor";
            yield return "Tammy";
        }

        static IEnumerable<int> Randoms()
        {
            var rand = new Random();
            while (true)
            {
                yield return  rand.Next();
            }

            
        }

        static void Print(Program p)
        {
            Console.WriteLine("I got a program object");
        }
    }


   


}
