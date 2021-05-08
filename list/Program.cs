using System;
using System.Collections;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myArrayList = new List<string>();
            myArrayList.Add("123");
            myArrayList.Add("abc");
            myArrayList.Add("12.30");
            myArrayList.Add("Tushar");
            Console.WriteLine("list size previous :"+myArrayList.Count);

            List<string> newList = new List<string>();
            newList.Add("A");
            newList.Add("b");
            myArrayList.AddRange(newList);
            Console.WriteLine("list size now :"+myArrayList.Count);
            foreach (var data in myArrayList)
            {
                Console.WriteLine(data);

                 
             }

             Console.ReadKey();

            
        }
    }
}
