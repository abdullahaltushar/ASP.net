using System;
using System.Collections;
using System.Collections.Generic;

namespace listArray
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(123);
            myArrayList.Add("abc");
            myArrayList.Add(12.30);
            myArrayList.Add('T');
            Console.WriteLine(myArrayList.Count);
            foreach (var data in myArrayList)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
