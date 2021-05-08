using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i=1; i<6; i++){

                Console.WriteLine(i);


            }

             for(int i=1; i<6; i++){
                 if(i%2==0){
                     Console.WriteLine(i);

                 }
             }
            


                 /* an other */
                 int size=6;
                 int[] number= new int[size];
                 for(int i=1;i<=size;i++){

                    number[i-1]=i;

                 }


                 for(int i=0;i<size;i++){
                    

                   
                     int nNumber= number[i];
                      if(nNumber%2==0){
                           Console.WriteLine(nNumber);

                      }
                 }
                     
                 

            Console.ReadKey();
            
        }
    }
}

