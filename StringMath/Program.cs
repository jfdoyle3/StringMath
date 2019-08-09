using System;
using System.Text.RegularExpressions;

namespace StringMath
{
    public class Program
    {
        static void Main(string[] args)
        {
            int total;
           
            //Console.Write("Type out a Math equation: ");
            //string input = Console.ReadLine();
            
            string user = "11 + 11";
            Console.WriteLine("User: {0}", user);

            string[] express = user.Split(" ");
            int numer = int.Parse(express[0]);
            int oper = int.Parse(express[2]);
            char func = Convert.ToChar(express[1]);

            switch (func)
            {
                case '+':
                    total = numer + oper;
                    Console.WriteLine(total);
                    break;
                case '-':
                    total = numer - oper;
                    Console.WriteLine(total);
                    break;
                case '*':
                    total = numer * oper;
                    Console.WriteLine(total);
                    break;
                case '/':
                    total = numer / oper;
                    Console.WriteLine(total);
                    break;
                case '%':
                    total = numer % oper;
                    Console.WriteLine(total);
                    break;
            }
        }
    }
}
