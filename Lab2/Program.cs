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
            PlayingCards();
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
        public static void PlayingCards()
        {
            for (int i = 1; i <= 4; i++)
            {
                string suit;
                switch (i)
                {
                    case 1:
                        suit = "Hjärta";
                        break;
                    case 2:
                        suit = "Spade";
                        break;
                    case 3:
                        suit = "Klöve";
                        break;
                    case 4:
                        suit = "Ruta";
                        break;
                    default:
                        suit = "";
                        break;
                }
                for (int j = 1; j <= 13; j++)
                {
                    string st = null;
                    if (j > 10)
                    {
                        switch (j)
                        {
                            case 11:
                                st = "knekt";
                                break;
                            case 12:
                                st = "Dam";
                                break;
                            case 13:
                                st = "Kung";
                                break;
                            default:
                                break;

                        }
                        Console.WriteLine(suit + " " + st);

                    }
                    else
                        Console.WriteLine(suit + " " + j);
                }
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
