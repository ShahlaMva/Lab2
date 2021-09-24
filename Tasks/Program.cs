using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FindSpace("Hello World juheudh hydehdyeh"));
            //string k = Console.ReadLine();
            //Console.WriteLine(Symbolcheck(k));

            //Console.WriteLine( "eded daxil et:");
            //string num = Console.ReadLine();
            //int n = int.Parse(num);
            //Ededhasilcem(n);
            Calculator();

        }
        static void Ededhasilcem(int number)
        {
            int hasil = 1;
            int cem = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i%3==0)
                {
                    hasil *= i;
                }
                else
                {
                    cem += i;
                }

            }
            Console.WriteLine("cem");
            Console.WriteLine(cem);
            Console.WriteLine("hasil");
            Console.WriteLine(hasil);
            
            



        }

        static int FindSpace(string sentence)
        {
            int count = 0;
            foreach (char item in sentence)
            {
                if(item==' ')
                {
                    count++;
                }
            }
            return count;
        }

        static string Symbolcheck(string s)
        {
            string temp = "";
            for(int i = 0; i < s.Length; i++)
            {
                temp += s[i] + "*";
            }
            
            return temp;
            }

      static int Sum(int num1,int num2)
        {

            return num1 + num2;

        }

        static int Minus(int num1,int num2)
        {
            int result = 0;
            result = num1 - num2;
            return result;
        }
        static int Divide(int num1, int num2)
        {
            int result = 1;
            result = num1/num2;
            return result;
        }
        static int Multiply(int num1, int num2)
        {
            int result =1 ;
            result = num1*num2;
            return result;
           
        }

        static void Calculator()
        {
            Console.WriteLine("Zehmet olmasa 1-ci ededi daxil edin:");
            string num1 = Console.ReadLine();
            int number1 = Convert.ToInt32(num1);
            
            Console.WriteLine("Zehmet olmasa 2-ci ededi daxil edin:");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);

            Console.WriteLine("Emeliyyati daxil edin:");
            string symbol = Console.ReadLine();

            if (symbol == "+")
            {
                Console.WriteLine(Sum(number1, number2));
            }
            else if (symbol == "-")
            {
                Console.WriteLine(Minus(number1, number2));
            }
            else if (symbol == "*")
            {
                Console.WriteLine(Multiply(number1, number2));
            }
            else if (symbol == "/")
            {
                Console.WriteLine(Divide(number1, number2));
            }
            else
            {
                Console.WriteLine("Duzgun emeliyyati daxil edin!");
            }


        }
    }

}
