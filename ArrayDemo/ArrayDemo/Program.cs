using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany; 
            int entry;
           
            Console.WriteLine("How many numbers are you going to enter?");
            howMany = Convert.ToInt32(Console.ReadLine());

            int[] eightNums = new int[howMany];

            for (int i = 0; i < eightNums.Length; ++i)
            {
                Console.WriteLine("Please enter a number");
                eightNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("How do you wan to see the info.\n" + 
                "1) First to last?\n" + 
                "2) Last to first\n" + 
                "3) Choose a specific position\n" +
                "4) To exit press 999");
            entry = Convert.ToInt32(Console.ReadLine());
        }
        public static void DisplayFirstToLast()
        {

        }
    }
}
