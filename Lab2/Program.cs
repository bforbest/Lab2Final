using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }
        /*
        = används när vi tilldelar någonting till något variable
        == för att jämföra två variabler
            */
        public static void BolingWater()
        {
            Console.WriteLine("Hur många grader är vattnet?");
            int degree =Int32.Parse( Console.ReadLine());
            if (degree >= 100)
            {
                Console.WriteLine("Vattnet Kokar!");
            }
            else if (degree >= 50)
            {
                Console.WriteLine("Vattnet halvkokar!");
            }
            else
            {
                Console.WriteLine("vattnet kokar inte!");
            }

        }

        public static void PekkasPonny()
        {
            WriteLine("Hur gammal är du?");
            int age = ReadInt();
            if (age>12)
            {
                WriteLine("Du är för ung!");
            }
            else
            {
                int weight = ReadInt();
                if(weight <= 30)
                {
                    WriteLine("A-Ponny");
                }
                else if (weight<=50)
                {
                    WriteLine("B-Ponny");
                }
                else if (weight<=65)
                {
                    WriteLine("C-Ponny");
                }
                else
                {
                    WriteLine("Ingen Ponny i denna viktklass");
                }
            }

        }

        public static void OkToSwim()
        {
            WriteLine("Finns det vatten?");
            string yesNo = Console.ReadLine();
            if (yesNo.ToLower() == "ja")
            {
                WriteLine("Hur många grader är vattnet?");
                int degree = ReadInt();
                if (degree >= 30)
                {
                    WriteLine("Varsågod och bada!");
                }
                else
                {
                    WriteLine("Vattnet för kallet!");
                }
            }
            else
            {
                WriteLine("Ingen vatten");

            }

        }

        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                string Fizz = i % 3 == 0? "Fizz" : "";
                string Buzz = i % 5 == 0 ? "Buzz" : "";
                if (Fizz != "" || Buzz != "")
                {
                    Console.Write(Fizz+Buzz);
                }
                else
                {
                    Console.Write(i);
                }
                Console.Write(" ");
                    
            }
        }

        public static void WriteLine(string s)
        {
            Console.WriteLine(s);
        } 
        public static int ReadInt()
        {
            int inInt;
            bool IsNumber = Int32.TryParse(Console.ReadLine(), out inInt);
            if (IsNumber)
            {
                return inInt;
            }
            else
            {
                Console.WriteLine("Not a number");
                return inInt;
            }

            
        }
    }
}
