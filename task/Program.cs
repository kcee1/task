using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter any first number of your choice: ");
            var firstnumber = Console.ReadLine();
            var Firstnumber = Convert.ToInt32(firstnumber);
            Console.Write("enter any second number of your choice: ");
            var secondnumber = Console.ReadLine();
            var Secondnumber = Convert.ToInt32(secondnumber);

            if (Firstnumber > Secondnumber)
            {
                Console.WriteLine("first number: " + Firstnumber + "is bigger than " + " secondnumber " + Secondnumber);
            }
            else if(Firstnumber < Secondnumber) 
            {
                Console.WriteLine("second number: " + Secondnumber + " is bigger than " + Firstnumber);
            }

            


        





            Console.ReadLine();
        }
    }
}
