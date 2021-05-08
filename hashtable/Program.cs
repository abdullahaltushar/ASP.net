using System;
using System.Collections;
using System.Collections.Generic;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable salaryData= new Hashtable();
            salaryData.Add("1",1000);
            salaryData.Add("2",2000);
            salaryData.Add("3",3000);
            salaryData.Add("4",4000);

            double salary =Convert.ToDouble(salaryData["2"]);
            salaryData["3"]=3500;
            Console.WriteLine("Employee Id and salary");
            foreach (DictionaryEntry data in salaryData)
            {
                Console.WriteLine(data.Key+"  "+ data.Value);
            }

            Console.ReadKey();

            
        }
    }
}
