using System;

namespace C_sharp_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the Program choice Number From the List Below: ");
            Console.WriteLine();
            Console.WriteLine("1. Write a C# Sharp program to print Hello and your name in a separate line. \n2. Write a C# Sharp program to print the sum of two numbers. \n3. Write a C# Sharp program to print the result of dividing two numbers. \n4. Write a C# Sharp program to print the result of the specified operations.  \n5.Write a C# Sharp program to swap two numbers. \n6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. \nWrite a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. \n8. Write a C# Sharp program that takes a number as input and print its multiplication table. \n9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. \n10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. ");
            Console.WriteLine();
            Console.Write("Whats your choice number pls enter ?????");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your Program choice Number is {x}");
            switch (x)
            {
                case 1:
                    Console.Write("Enter your name : ");
                    string name = Console.ReadLine();
                    Console.Write("Hello :");
                    Console.WriteLine(" {0}",name);
                    break; 
                case 2:
                    Console.WriteLine("Enter 1st number : ");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 1st number : ");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sum of the 2 number is : \n" + (x1 + x2));
                    break;
                case 3:
                    Console.WriteLine("Enter 1st number : ");
                    int x3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 1st number : ");
                    int x4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Division of the 2 number is(num1/num2) : \n" + (x3 / x4));
                    break;
                case 4:
                    Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
                    Console.WriteLine("(35 + 5) % 7 = "+((35 + 5) % 7));
                    Console.WriteLine("14 + -4 * 6 / 11 = "+( 14 + -4 * 6 / 11 ));
                    Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));
                    break;
                case 5 :
                    Console.WriteLine("Enter 1st number : ");
                    int x5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int x6 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Number before swapping is number 1 = {x5} and number2 = {x6}  ");
                    swap(ref x5,ref x6);
                    Console.WriteLine($"Number before swapping is number 1 = {x5} and number2 = {x6}  ");
                    break;
                case 6:
                    Console.WriteLine("Enter 1st number : ");
                    int x7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int x8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 3rd number : ");
                    int x9 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Multiply \n {x7}X{x8}X{x9} = ");
                    break;
                case 7:
                    Console.WriteLine("Enter 1st number : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sum of the 2 number is : \n" + (a + b));
                    Console.WriteLine("Difference of the 2 number is : \n" + (a - b));
                    Console.WriteLine("Multiply of the 2 number is : \n" + (a * b));
                    Console.WriteLine("Divide of the 2 number is : \n" + (a % b));
                    break;
                case 8:
                    Console.WriteLine("Enter  number : ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Table of the number {a1} : \n");
                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine($"{a1}X{i} = {a1*i}");
                    break;
                case 9:
                    Console.WriteLine("Enter 1st number : ");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int a3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 3rd number : ");
                    int a4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 4th number : ");
                    int a5 = int.Parse(Console.ReadLine());
                    float avg;
                    avg = (float)(a2 + a3 + a4 + a5) / 4;
                    Console.WriteLine("Avg of 4 Numbers :{0} ", avg);
                    break;
                case 10:
                    Console.WriteLine("Enter 1st number : ");
                    int a6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int a7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 3rd number : ");
                    int a8 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"({a6} + {a7}) X {a8} = {(a6 + a7) * a8}");
                    Console.WriteLine($"{a6}X{a7} + {a7}X{a8} = {a6*a7 + a7*a8}");
                    break;
                default:
                    Console.WriteLine("Your Choice is Incorrect");
                    break;
            }
        }
        static void swap(ref int x5,ref int x6)
        {
            int temp = x5;
            x5 = x6 ;
            x6 = temp;
            //Console.WriteLine($"Number before swapping is number 1 = {x5} and number2 = {x6}  ");
        }

    }
    

}
