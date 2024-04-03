using System;
using System.Text;


namespace FuncForModulTest
{


    public class Program
    {

        public static string ToRoman(int number)
        {
            if (number < 0 || number > 3999)
                return "error";

            if (number == 0) return "N";

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }

            return result.ToString();
        }
        public static int ReverseNum(int num)
        {
            double result = 0;
            int h = 0;
            for (int i = num; i != 0; i = i / 10)
                h++;
            while (num != 0)
            {
                int a = num % 10;
                num /= 10;
                if (a != 0)
                {
                    result += a * Math.Pow(10, h - 1);
                }
                h--;
            }
            return (int)result;
        }
        public static bool simpleNumber(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n - 1; i++)
                if (n % i == 0)
                    return false;
            return true;

        }
        public static bool lineContaints(string str1, string str2)
        {
            if ((str1.Length < str2.Length))
                return false;
            else if (str1 == "" && str2 == "")
                return true;
            else if (str1 == "" || str2 == "")
                return false;
            return str1.Contains(str2);
        }
        public static int Fibonachi(int n)
        {
            if (n < 0 || n >= 47)
                return -1;

            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        public static int Factorial(int x)
        {
            if(x < 0 || x >= 13)
                return -1;
            int a = 1;
            for (int i = x; i > 0; i--)
            {
                a *= i;
            }
            return a; 
        }
        public static bool Palindrom(string s)
        {
            if (s == "")
                return false;
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j])
                    return false;
            return true;

        }
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 3, 2, 1, 8 };

            BubbleSort(array);


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(Palindrom("1221"));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Fibonachi(3));
            Console.WriteLine(lineContaints("Wolf", "olf"));
            Console.WriteLine(simpleNumber(5));
            Console.WriteLine(ToRoman(4));
            Console.WriteLine(ReverseNum(-12340));
        }
    }
}
