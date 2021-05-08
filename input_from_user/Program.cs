using System;

namespace input_from_user
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1st number input");
            int firstnumber=Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd number input");
            int secondnumber=Convert.ToInt32(Console.ReadLine());
            int result=firstnumber+secondnumber;
            Console.WriteLine("Result:" + result);
            Console.ReadKey();


        }
    }
}
