using System;
using System.Text.RegularExpressions;

namespace StringMath
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            //Console.Write("Type out a Math equation: ");
            //string input = Console.ReadLine();
            
            string user = "11 + 11";
            Console.WriteLine("User: {0}", user);
            string[] express = user.Split(" ");

            Regex regex = new Regex(@"\W");
            Match matchNumer = regex.Match(express[0]);
            Match matchOper = regex.Match(express[2]);

            if (matchNumer.Success == true)
            {
                double numer = double.Parse(express[0]);
                double oper = double.Parse(express[2]);
                Console.WriteLine("A:{0:R}    B: {1:R}",numer, oper);
            }
            else
            {
                int numer = int.Parse(express[0]);
                int oper = int.Parse(express[2]);
                Console.WriteLine("A:{0:R}    B: {1:R}", numer, oper);

            }

            char func = Convert.ToChar(express[1]);





            switch (func)
            {

                case '+':
                    Addition addThis = new Addition();
                    addThis.AddItUp(numer, oper);
                    break;
                case '-':
                 int   total = numer - oper;
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
