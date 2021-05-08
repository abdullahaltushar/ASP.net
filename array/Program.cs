using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names= new string[10];
            names[0]="Aliya";
            names[1]="Raina";
            names[2]="Ratan";

            Console.WriteLine(names[2]);
            Console.WriteLine(names[5]);




            int[] numberList =new int[5];
            numberList[0]=1;
            numberList[1]=2;
            numberList[2]=3;
            numberList[3]=4;
            numberList[4]=5;

            Console.WriteLine(numberList[4]);
            Console.ReadKey();
        }
    }
}
