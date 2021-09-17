using System;

namespace First__Console_Application
{
    class Program
    {
        //entry point of our program
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            //assigning a value to a variable
            num1 = 13;
            //declaring and initializing a variable in one go
            int num2 = 23;

            Console.WriteLine(num1 + num2);
            Console.WriteLine("num1: " + num1);

            //declaring multiple variable
            int num3, num4, num5;

            //double
            double d1 = 3.14;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            //float
            float f1 = 3.14f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            //mixing variable types
            double dIDiv = d1 / num1;

            //below doesn't work because return value is not a int
            //int dIDivInt = d1 / num1;

            string myname = "Loi Pham";
            string uppercaseName = myname.ToUpper();
            Console.WriteLine(uppercaseName);
        }
    }
}
