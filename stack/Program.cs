using System;
using System.Collections;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> newstack =new Stack<string>();
            newstack.Push("tushar");
            newstack.Push("taka");
            newstack.Push("book");
            newstack.Push("deydo");

            foreach (var data in newstack)
            {
                Console.WriteLine(data);
                
            }
            Console.WriteLine(newstack.Count);
            newstack.Pop();
            foreach (var data in newstack)
            {
                Console.WriteLine(data);
                
            }
            Console.WriteLine(newstack.Count);
            Console.ReadKey();

        }
    }
}
