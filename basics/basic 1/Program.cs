using System;
//This imports namespaces that provide access to various classes and methods.
//In this case, System is a namespace containing basic input/output functionalities like Console.

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//basic_1 is a namespace that contains Program class
namespace basic_1
{

    //internal means methods can be accessed within same assembly, public means by other assembly if referenced, private, protected....
    //internal method is provided as default
    internal class Program
    {

        //static: Indicates that the method belongs to the class, not an instance of it. In other words you dont have to create object to use it. you can directly use it as Program.method();
        //void: Specifies that the method does not return any value.
        //string[] args: Accepts command-line arguments as an array of strings.
        static void Main(string[] args)
        {
            //  CHECK EVEN ODD

            //while (true)
            //{
            //Console.WriteLine("enter a number: ");
            //int randomNumber = int.Parse(Console.ReadLine());
            //if(randomNumber % 2 == 0)
            //{
            //    Console.WriteLine($"the number {randomNumber} is a even number");
            //}
            //else
            //{
            //    Console.WriteLine($"the number {randomNumber} is a odd number");
            //}
            //}


            //CHECK PRIME  
            //while (true)
            //{
            //    int count = 0;
            //    Console.WriteLine("enter a number: ");
            //    int randomNumber = int.Parse(Console.ReadLine());
            //    for(int i = 1; i <= randomNumber; i++)
            //    {
            //        if (randomNumber % i == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count > 2)
            //    {
            //        Console.WriteLine("its not a prime number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("its  a prime number");

            //    }
            //}


            //SIMPLE CALCULATOR
            Console.WriteLine(("press 1 for addition\n"));
            Console.WriteLine(("press 2 for subtraction\n"));
            Console.WriteLine(("press 3 for division\n"));
            Console.WriteLine(("press 4 for multiplication\n"));
            Console.WriteLine("press 5 for exiting\n\n");

            Console.WriteLine("enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a character \n");
            char operationSelect = Console.ReadKey().KeyChar;

            while (true)
            {
                switch (operationSelect)
                {
                    case '1':
                        Console.WriteLine(firstNumber + secondNumber);
                        break;

                    case '2':
                        Console.WriteLine(firstNumber - secondNumber);
                        break;

                    case '3':
                        Console.WriteLine(firstNumber / secondNumber);
                        break;

                    case '4':
                        Console.WriteLine(firstNumber * secondNumber);
                        break;

                    case '5':
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("invalid keyword");
                        break;
                }

            }


            //LOWERCASE TO UPPERCASE AND VICE VERSA

            //Console.WriteLine("enter a string in uppercase");
            //string uppercase = Console.ReadLine();
            //Console.WriteLine(uppercase.ToLower());
            //Console.WriteLine("enter a string in lowercase");
            //string lowercase = Console.ReadLine();
            //Console.WriteLine(lowercase.ToUpper());

        }
    }
}
