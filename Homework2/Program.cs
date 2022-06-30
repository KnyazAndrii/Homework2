using System;

namespace Homework2
{
    class Program
    {
        static int ValidateTwoNumbers(int a, int b)
        {
            if(a > b)
            {
                return a + b;
            }    
            else if(a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        static int DetermineQuarter(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    return 1;
                }
                else if (x < 0 && y > 0)
                {
                    return 2;
                }
                else if (x < 0 && y < 0)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                return 0;
            }
        }

        static void SelectFromLowToHigh(int a, int b, int c)
        {
            if(a < b && a < c)
            {
                Console.Write(a + " ");

                if(b < c)
                {
                    Console.Write(b + " ");
                    Console.WriteLine(c);
                }
                else
                {
                    Console.Write(c + " ");
                    Console.WriteLine(b);
                }
            }
            else if(b < a && b < c)
            {
                Console.Write(b + " ");
                if(a < c)
                {
                    Console.Write(a + " ");
                    Console.WriteLine(c);
                }
                else
                {
                    Console.Write(c + " ");
                    Console.WriteLine(a);
                }
            }
            else if (c < a && c < b)
            {
                Console.Write(c + " ");
                if (b < a)
                {
                    Console.Write(b + " ");
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                    Console.WriteLine(b);
                }
            }
        }

        static void CalculateQuadraticEquation(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;
            double Crimeans = b * b - 4 * a * c;

            if(Crimeans > 0)
            {
                x1 = (-b + Math.Sqrt(Crimeans)) / (2 * a);
                x2 = (-b - Math.Sqrt(Crimeans)) / (2 * a);

                Console.WriteLine("x1 = " + x1 + "; x2 = " + x2);
            }
            else if(Crimeans == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("The roots are equal; x1 = x2 = " + x1);
            }
            else
            {
                Console.WriteLine("There are no roots of equation");
            }
        }

        static void CapitalizateNumbers(int num)
        {
            string ten = "ten";
            string twenty = "twenty";
            string eleven = "eleven";
            string twelve = "twelve";  
            string thirt = "thirt";
            string fift = "fift";
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            int firstDigit = num / 10;
            int secondDigit = num % 10;

            if (num == 10)
            {
                Console.WriteLine(ten);
            }
            else if (num == 11)
            {
                Console.WriteLine(eleven);
            }
            else if (num == 12)
            {
                Console.WriteLine(twelve);
            }
            else if (num == 13)
            {
                Console.WriteLine(thirt + "een");
            }
            else if (num == 14)
            {
                Console.WriteLine(four + "teen");
            }
            else if (num == 15)
            {
                Console.WriteLine(fift + "een");
            }
            else if (num == 16)
            {
                Console.WriteLine(six + "teen");
            }
            else if (num == 17)
            {
                Console.WriteLine(seven + "teen");
            }
            else if (num == 18)
            {
                Console.WriteLine(eight + "een");
            }
            else if (num == 19)
            {
                Console.WriteLine(nine + "teen");
            }
            else if (num >= 20 && num <= 99)
            {
                switch (firstDigit)
                {
                    case 2:
                        Console.Write(twenty);
                        break;
                    case 3:
                        Console.Write(thirt + "y");
                        break;
                    case 4:
                        Console.Write(four + "ty");
                        break;
                    case 5:
                        Console.Write(fift + "y");
                        break;
                    case 6:
                        Console.Write(six + "ty");
                        break;
                    case 7:
                        Console.Write(seven + "ty");
                        break;
                    case 8:
                        Console.Write(eight + "y");
                        break;
                    case 9:
                        Console.Write(nine + "ty");
                        break;
                }
                switch (secondDigit)
                {
                    case 1:
                        Console.Write("-" + one);
                        break;
                    case 2:
                        Console.Write("-" + two);
                        break;
                    case 3:
                        Console.Write("-" + three);
                        break;
                    case 4:
                        Console.Write("-" + four);
                        break;
                    case 5:
                        Console.Write("-" + five);
                        break;
                    case 6:
                        Console.Write("-" + six);
                        break;
                    case 7:
                        Console.Write("-" + seven);
                        break;
                    case 8:
                        Console.Write("-" + eight);
                        break;
                    case 9:
                        Console.Write("-" + nine);
                        break;
                }
            }        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: " + ValidateTwoNumbers(5, 6));
            Console.WriteLine("Task 2: " + DetermineQuarter(3, -6) + "-th quarter");
            Console.Write("Task 3: ");
            SelectFromLowToHigh(5, 12, 99);
            Console.Write("Task 4: ");
            CalculateQuadraticEquation(2, 5, 2);
            Console.Write("Task 5: ");
            CapitalizateNumbers(98);
        }
    }
}
