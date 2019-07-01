using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <= 255; i++){
            //     Console.WriteLine(i);
            // }
            // for (int i = 1; i <= 100; i++){
            //     if(i % 3 == 0 && i % 5 == 0){
            //         continue;
            //     }
            //     if(i % 3 ==0){
            //         Console.WriteLine(i);
            //     }
            //     if(i % 5 == 0){
            //         Console.WriteLine(i);
            //     }
            // }
            // for (int i = 1; i <= 100; i++){
            //     if(i % 3 == 0 && i % 5 == 0){
            //         Console.WriteLine("fizzbuzz");
            //     }
            //     if(i % 3 ==0){
            //         Console.WriteLine("fizz");
            //     }
            //     if(i % 5 == 0){
            //         Console.WriteLine("buzz");
            //     }
            // }
            // int i = 1;
            // while(i <= 255){
            //     Console.WriteLine(i);
            //     i++;
            // }
            // int i = 1;
            // while(i <= 100){
            //     if(i % 3 == 0 && i % 5 == 0){
            //         i++;
            //     }
            //     if(i % 3 ==0){
            //         Console.WriteLine(i);
            //     }
            //     if(i % 5 == 0){
            //         Console.WriteLine(i);
            //     }
            //     i++;
            // }
            int i = 1;
            while(i <= 100){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("fizzbuzz");
                }
                if(i % 3 ==0){
                    Console.WriteLine("fizz");
                }
                if(i % 5 == 0){
                    Console.WriteLine("buzz");
                }
                i++;
            }
        }
    }
}
