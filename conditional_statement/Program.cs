using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number:");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number<0 || number>100){
                Console.WriteLine("wrong number");
            }
            if(number>=80){

                Console.WriteLine("you pass");

            }
            else
            {
                Console.WriteLine("faill");
            }

             Console.WriteLine(number);
             Console.ReadKey();
        }
    }
}
