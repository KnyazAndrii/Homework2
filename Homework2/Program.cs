using System;

namespace Homework2
{
    class Program
    {
        static int ValidateTwoNumbers(int a, int b)
        {
            int result = 0;

            if(a > b)
            {
                result = a + b;
            }    
            else if(a == b)
            {
                result = a* b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        static int DetermineQuarter(int x, int y)
        {
            int quarter = 0;

            if (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    quarter = 1;
                }
                else if (x < 0 && y > 0)
                {
                    quarter = 2;
                }
                else if (x < 0 && y < 0)
                {
                    quarter = 3;
                }
                else
                {
                    quarter = 4;
                }
            }

            return quarter;
        }

        static (int a, int b, int c) SelectFromLowToHigh(int a, int b, int c)
        {
            if(a > b)
            {
                Swap(ref a, ref b);
            }
            else if(a > c)
            {
                Swap(ref a, ref c);
            }
            else if (b > c)
            {
                Swap(ref b, ref c);
            }
            return (a, b, c);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static (double x1, double x2) CalculateQuadraticEquation(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;
            double SqrtD = Math.Sqrt(b * b - 4 * a * c);

            if (SqrtD > 0)
            {
                x1 = (-b + SqrtD) / (2 * a);
                x2 = (-b - SqrtD) / (2 * a);

            }
            else if (SqrtD == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                x1 = double.NaN;
                x2 = double.NaN;
            }

            return (x1, x2);
        }

        static string CapitalizateNumbers(int num)
        {
            string firstWord = string.Empty;
            string secondWord = string.Empty;

            int firstDigit = num / 10;
            int secondDigit = num % 10;

            if (firstDigit != 1)
            {
                firstWord = GetDozens(firstDigit);
                secondWord = GetUnits(secondDigit);

                return $"{firstWord}-{secondWord}";
            }
            else
            {
                firstWord = GetFormTenToNineteen(secondDigit);

                return firstWord;
            }
        }

        private static string GetDozens(int firstDigit)
        {
            string result = string.Empty;
            switch (firstDigit)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }
            return result;
        }

        private static string GetUnits(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }
            return result;
        }

        private static string GetFormTenToNineteen(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 1:
                    result = "eleven";
                    break;
                case 2:
                    result = "twelve";
                    break;
                case 3:
                    result = "thirteen";
                    break;
                case 4:
                    result = "fourteen";
                    break;
                case 5:
                    result = "fifteen";
                    break;
                case 6:
                    result = "sixteen";
                    break;
                case 7:
                    result = "seventeen";
                    break;
                case 8:
                    result = "eighteen";
                    break;
                case 9:
                    result = "nineteen";
                    break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: " + ValidateTwoNumbers(5, 6));
            Console.WriteLine("Task 2: " + DetermineQuarter(3, -6) + "-th quarter");
            Console.WriteLine("Task 3: " + SelectFromLowToHigh(5, 12, 99));
            Console.WriteLine("Task 4: " + CalculateQuadraticEquation(2, 5, 2));
            Console.Write("Task 5: " + CapitalizateNumbers(58));
        }
    }
}
