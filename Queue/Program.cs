using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> newqueue =new Queue<string>();
            newqueue.Enqueue("tushar");
            newqueue.Enqueue("taka");
            newqueue.Enqueue("book");
            newqueue.Enqueue("deydo");

            foreach (var data in newqueue)
            {
                Console.WriteLine(data);
                
            }
            Console.WriteLine(newqueue.Count);
            newqueue.Dequeue();
            foreach (var data in newqueue)
            {
                Console.WriteLine(data);
                
            }
            Console.WriteLine(newqueue.Count);
            Console.ReadKey();
        }
    }
}
