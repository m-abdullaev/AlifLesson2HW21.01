using System;

namespace AlifLesson2HW21._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //task2
            // int a = Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());
            // if (a != b)
            // {
            //     if (a > b)
            //     {
            //         System.Console.WriteLine(a);
            //         System.Console.WriteLine(b = a);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine(a = b);
            //         System.Console.WriteLine(b);
            //     }
            // }
            // else if (a == b)
            // {
            //     System.Console.WriteLine(a = 0);
            //     System.Console.WriteLine(b = 0);
            // }

            //task3
            // System.Console.WriteLine("Please enter numbers");
            // var operand1 = Convert.ToDouble(Console.ReadLine());
            // var operand2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Please enter operation");
            // char sign = Convert.ToChar(Console.ReadLine());
            // switch (sign)
            // {
            //     case '+':
            //         System.Console.WriteLine(operand1 + operand1);
            //         break;
            //     case '-':
            //         System.Console.WriteLine(operand1 - operand1);
            //         break;
            //     case '*':
            //         System.Console.WriteLine(operand1 * operand1);
            //         break;
            //     case '/':
            //         if (operand2 != 0)
            //             System.Console.WriteLine(operand1 / operand2);
            //         else
            //             System.Console.WriteLine("Not allowed to divide to 0");
            //         break;
            // }

            //task4
            //System.Console.WriteLine("Please enter the number");
            //var number = Convert.ToDouble(Console.ReadLine());
            //if (number >= 0 && number <= 15)
            //{
            //    System.Console.WriteLine("You are in the 1st Interval");
            //}
            //else if (number > 15 && number <= 35)
            //{
            //    System.Console.WriteLine("You are in the 2nd Interval");
            //}
            //else if (number >= 36 && number <= 50)
            //{
            //    System.Console.WriteLine("You are in the 3rd Interval");
            //}
            //else if (number >= 51 && number <= 100)
            //{
            //    System.Console.WriteLine("You are in the 4th Interval");
            //}
            //else
            //{
            //    System.Console.WriteLine("You have entered incorrect number");
            //}

            //task5

            // System.Console.WriteLine("Please enter purchase amount");
            // var discount = 0.0;
            // var purchase = Double.Parse(Console.ReadLine());
            // if (purchase >= 500 && purchase < 1000)
            // {
            //     discount = purchase * 0.03;
            //     System.Console.WriteLine($"Your discount is 3% and your amount due is {purchase - discount}");

            // }
            // else if (purchase >=1000)
            // {
            //     discount = purchase * 0.05;
            //     System.Console.WriteLine($"Your discount is 5% and your amount due is {purchase - discount}");
            // }
            // else if (purchase < 500)
            // {
            //     System.Console.WriteLine("You are not eligible for discount");
            // }

            //task6

            //System.Console.WriteLine("Please provide the numbers");
            //var a = Int32.Parse(Console.ReadLine());
            //var b = Int32.Parse(Console.ReadLine());
            //var c = Int32.Parse(Console.ReadLine());
            //var d = Int32.Parse(Console.ReadLine());

            //var minab = 0;
            //var mincd = 0;
            //var min = 0;

            //if (a < b && b < c && c < d)
            //{
            //    System.Console.WriteLine("Provided numbers are in increasing order");
            //}
            //else if (a == b && b == c && c == d)
            //{
            //    System.Console.WriteLine(a * b * c * d);
            //}
            //else
            //{
            //    minab = Math.Min(a, b);
            //    mincd = Math.Min(c, d);
            //    min = Math.Min(minab, mincd);
            //    System.Console.WriteLine($"Minimum number is {min}");
            //}

            //task7

            System.Console.WriteLine("Please provide the numbers");
            var a = Int32.Parse(Console.ReadLine());
            var b = Int32.Parse(Console.ReadLine());
            var c = Int32.Parse(Console.ReadLine());

            int max = 0, mid = 0, min = 0;
            if (a > b && b > c)
            {
                max = a;
                mid = b;
                min = c;
                System.Console.WriteLine($"Maximum number is {a = max}");
                System.Console.WriteLine($"Middle number is {b = mid}");
                System.Console.WriteLine($"Minimum number is {c = min}");
            }
            else if (b > a && a > c)
            {
                max = b;
                mid = a;
                min = c;
                System.Console.WriteLine($"Maximum number is {a = max}");
                System.Console.WriteLine($"Middle number is {b = mid}");
                System.Console.WriteLine($"Minimum number is {c = min}");
            }
            else if (c > b && b > a)
            {
                max = c;
                mid = b;
                min = a;
                System.Console.WriteLine($"Maximum number is {a = max}");
                System.Console.WriteLine($"Middle number is {b = mid}");
                System.Console.WriteLine($"Minimum number is {c = min}");
            }
            else if (a > b && a > c && b < c)
            {
                max = a;
                mid = c;
                min = b;
                System.Console.WriteLine($"Maximum number is {a = max}");
                System.Console.WriteLine($"Middle number is {b = mid}");
                System.Console.WriteLine($"Minimum number is {c = min}");
            }
            else if (a < b && b > c)
            {
                max = b;
                mid = c;
                min = a;
                System.Console.WriteLine($"Maximum number is {a = max}");
                System.Console.WriteLine($"Middle number is {b = mid}");
                System.Console.WriteLine($"Minimum number is {c = min}");
            }
            else if (a > b && b < c && a < c)
            {
                max = c;
                mid = a;
                min = b;
                System.Console.WriteLine($"Maximum number is {a = max}");
                System.Console.WriteLine($"Middle number is {b = mid}");
                System.Console.WriteLine($"Minimum number is {c = min}");
            }
        }
    }
}
