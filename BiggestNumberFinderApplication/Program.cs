using System;

namespace BiggestNumberFinderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Input the 1st number: ");
                double num1 = double.Parse(Console.ReadLine());
                
                Console.Write("Input the 2nd number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Input the 3rd number: ");
                double num3 = double.Parse(Console.ReadLine());

                Console.Write("Input the 4rd number: ");
                double num4 = double.Parse(Console.ReadLine());

                if (num1 > num2 & num1 > num3 & num1 > num4)
                {
                    Console.WriteLine("The biggest number is: " + num1);
                }
                else if (num2 > num1 & num2 > num3 & num2 > num4)
                {
                    Console.WriteLine("The biggest number is: " + num2);
                }
                else if (num3 > num1 & num3 > num2 & num3 > num4)
                {
                    Console.WriteLine("The biggest number is: " + num3);
                }
                else
                {
                    Console.WriteLine("The biggest number is: " + num4);
                }
            }

            catch
            {
                Console.WriteLine("Please enter a valid input value");
            }

        }
    }
}
