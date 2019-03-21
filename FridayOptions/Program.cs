using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("What are you in the mood for? Please enter 1, 2, 3, or 4.\n1 - Good Food\n2 - Sports\n3 - Action\n4 - Music");
            int action1 = int.Parse(Console.ReadLine());

            if (action1 == 1)
            {
                Console.WriteLine("Lets go get Tacos!");
            }
            else if (action1 == 2)
            {
                Console.WriteLine("Lets go to 5/3 ball park!");
            }
            else if (action1 == 3)
            {
                Console.WriteLine("Lets go hiking at Sleeping Bear National Park!");
            }
            else if (action1 == 4)
            {
                Console.WriteLine("Let's go to Van Andel for a concert!");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.WriteLine("How many people are traveling with you?");
            int numberOfPll = int.Parse(Console.ReadLine());



            if (numberOfPll == 0)
            {
                Console.WriteLine("You should take a bike.");
            }
            else if (numberOfPll >= 1 && numberOfPll <= 4)
            {
                Console.WriteLine("You should take a Lyft");
            }
            else if (numberOfPll >= 5 && numberOfPll <=10)
            {
                Console.WriteLine("You should take a UberXL");
            }
            else if (numberOfPll >= 11 )
            {
                Console.WriteLine("You should take the Rapid!");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }





        }
    }
}
