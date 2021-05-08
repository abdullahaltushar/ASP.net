using System;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string message="hello ubuntu";/*string variable*/
            Console.WriteLine(message+" string value");
            int number=10;/*integer variable*/
            number=number-5;
            Console.WriteLine(number+" integer value");
            double dvalue=5.00;/* double value*/
            Console.WriteLine(dvalue+" double value");
            Console.ReadKey();
        }
    }
}
