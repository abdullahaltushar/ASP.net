using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            do
            {

                Console.WriteLine(i);
                i++;
                
            } while (i<5);
            
            Console.ReadKey();
        }
    }
}
