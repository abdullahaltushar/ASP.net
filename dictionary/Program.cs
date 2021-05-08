using System;
using System.Collections;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> salary
            =new Dictionary<string, double>();


            salary.Add("tushar",5000);
            salary.Add("sabbir",3000);
            salary.Add("new",2000);

            foreach (KeyValuePair <string, double> aPair in salary)
            {
                Console.WriteLine(aPair.Key+ "  "+aPair.Value);

            }
            Console.ReadKey();
           
        }
    }
}
