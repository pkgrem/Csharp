using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;
            x = 3;
            y  = 6;
            z = x * y;

            var numbers = new [] {12,1,2,3,5,7,66,44,2,1};
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            var result = 0;
            foreach(double number in numbers)
            {
                
            }
            Console.WriteLine(result);


            Console.WriteLine(numbers[0]+numbers[1]+numbers[2]);

            if(args.Length > 0)
            {
            Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello");
            }
            Console.WriteLine(y + x);
            Console.WriteLine(z);


        }
    }
}
