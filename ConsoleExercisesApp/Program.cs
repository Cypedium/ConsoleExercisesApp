using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercisesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assigment number ( or -1 to exit )\nSelect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (selectionNumber)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;

                        case 4:
                            RunExerciseFour();
                            break;

                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExcersieTwelve();
                            break;
                        case 13:
                            RunExcersie13();
                            break;
                        case 14:
                            RunExcersise14();
                            break;
                        case 15:
                            RunExersise15();
                            break;
                        case 16:
                            RunExersise16();
                            break;
                        // Add new cases as you progress with your exercises

                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid assigment number!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                    Console.WriteLine(e);
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void RunExerciseOne()
        {
            string firstName = "Mikael";
            string lastName = "Aurell";
            Console.WriteLine($"Hello {firstName} {lastName}! I’m glad to inform you that you are the test \tsubject ofmy very first assignment!");
        }

        private static void RunExerciseTwo()
        {
            DateTime value = new DateTime(2019, 10, 22);
            Console.WriteLine(value);
            Console.WriteLine(value == DateTime.Today);
        }

        private static void RunExerciseThree()
        {
            string firstName;
            string lastName;
            Console.Write("Write your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Write your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Välkommen {firstName} {lastName}!");
        }

        private static void RunExerciseFour()
        {
            //The quick fox Jumped Over the DOG

            string myText = "The brown fox jumped over the lazy dog";
            string subTemp = myText.Substring(0, 3); //The
            string subTemp2 = myText.Substring(10, 19); //fox jumped over the
            subTemp2 = subTemp2.Replace(subTemp2, "fox Jumped over the");
            string subTemp3 = myText.Substring(35); //dog
            subTemp3 = subTemp3.ToUpper();
            string subTemp4 = subTemp.Insert(3, " quick");
            myText = subTemp4.Insert(9, $" {subTemp2}");
            myText = myText.Insert(29, $" {subTemp3}");
            Console.WriteLine(myText);
            //Console.WriteLine($"{subTemp4} {subTemp2} {subTemp3}");

        }

        private static void RunExerciseFive()
        {
            string stringstr = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string newstring = stringstr.Substring(65, 10);
            string first = newstring.Substring(0, 3);
            string last = newstring.Substring(7, 3);
            newstring = first.Insert(3, $"{last}");
            newstring = newstring.Insert(6, ",6,7,8,9,10]");
            Console.WriteLine(newstring);

        }

        private static void RunExerciseSix()
        {
            Console.WriteLine("Type a number");
            string astring = Console.ReadLine();
            Console.WriteLine("Type a number");
            string bstring = Console.ReadLine();
            int a = int.Parse(astring);
            int b = int.Parse(bstring);
            int addition = a + b;
            int subtraktion = a - b;
            int multi = a * b;
            int divi = a / b;
            int divirest = a % b;
            if (a > b)
            {
                Console.WriteLine($"The biggest value is {a} and the smallest is {b}.");
                Console.WriteLine($"a+b={addition} a-b={subtraktion} a*b={multi} a/b={divi}.{divirest}");
            }
            else
            {
                Console.WriteLine($"The biggest value is {b} and the smallest is {a}.");
                Console.WriteLine($"a+b={addition} a-b={subtraktion} a*b={multi} a/b={divi}.{divirest}");
            }
        }

        private static void RunExerciseSeven()
        {
            Console.WriteLine("Type a radius: ");
            string myradius = Console.ReadLine();
            double myradiusDub = double.Parse(myradius);
            double area = 2 * Math.PI * Math.Pow(myradiusDub, 2);
            double volume = 4 * Math.PI * Math.Pow(myradiusDub, 3);
            volume = volume / 3;
            area = Math.Round(area, 1);
            volume = Math.Round(volume, 1);
            Console.WriteLine($"Your area is:{area} and your volume is:{volume}");
        }

        private static void RunExerciseEight()
        {
            Console.WriteLine("Type a number: ");
            string myNumberString = Console.ReadLine();
            
            double myNumber = double.Parse(myNumberString);
            double myNumberSqr = Math.Sqrt(myNumber);
            double myNumber_2 = Math.Pow(myNumber, 2);
            double myNumber_10 = Math.Pow(myNumber, 10);
            
            myNumberSqr = Math.Round(myNumberSqr, 1);
            myNumber_2 = Math.Round(myNumber_2, 1);
            myNumber_10 = Math.Round(myNumber_10, 1);
            Console.WriteLine($"{myNumberSqr} {myNumber_2} {myNumber_10}");

        }

        private static void RunExerciseNine()
        {
            Console.Write("Write your name: ");
            string myNameStr = Console.ReadLine();
            Console.Write($"Welcome {myNameStr}. Vilket år är du född? ");
            string myYearStr = Console.ReadLine();
            int myYear = int.Parse(myYearStr);
            int thisYear = DateTime.Now.Year;
            int myAge = thisYear - myYear;
            //char ja = Console.ReadKey(true).KeyChar;
            string ja = "ja";
            string Ja = "Ja";
            //string nej = "Nej";

            if (myAge > 17)
            {
                string beer = AskUserFor("Vill du ha en öl? (Ja/Nej)");
                if (beer == ja || beer == Ja)
                {
                    Console.WriteLine("Order a beer");
                }
                else
                {
                    string fanta = AskUserFor("Vill du ha en fanta? (Ja/Nej)");
                    if (fanta == ja || fanta == Ja)
                    {
                        Console.WriteLine("Order a Fanta");
                    }

                    else
                    {
                        Console.WriteLine("Inga fler val");
                    }
                }
            }
            
            else
            {
                string fanta = AskUserFor("Vill du ha en fanta? (Ja/Nej)");
                if (fanta == ja || fanta == Ja)
                {
                    Console.WriteLine("Order a Fanta");
                }

                else
                {
                    Console.WriteLine("Inga fler val");
                }
            }
        }
        
        private static void RunExerciseTen()

        {
            bool keepAlive2 = true;
            while (keepAlive2)
            {
                 try
                    { 

                    Console.Write("Enter assigment number 1,2 or 3. ( or -1 to exit )\nSelect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (selectionNumber)
                    {
                        case 1:
                            int a = int.Parse(Console.ReadLine());
                            int b = int.Parse(Console.ReadLine());
                            if (a != 0 && b != 0)
                            {
                                Console.WriteLine($"{a / b}");
                            }

                            else
                            {
                                Console.WriteLine("The number can't be 0");
                            }
                            break;
                        case 2:
                            RunExerciseFour();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("HEJ");
                            Console.ResetColor();
                            break;
                        case -1:
                            keepAlive2 = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                    Console.WriteLine(e);
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }    
        private static void RunExerciseEleven()
        {
            Console.Write("Pick a number ");
            int a = int.Parse(Console.ReadLine());
            
            if (a != 0)
            {
                a = a + 1;
                for (int i = 0; i < a; i++)
                {
                    int rest = i % 2;
                    if (rest != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(i);
                    }
                }
                for (int i = a - 1; i >= 0; i--)
                {
                    int rest = i % 2;
                    if (rest != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(i);
                    }
                }
            }

            else
            {
                Console.WriteLine("The number can't be 0");
            }
        }
        
        private static void RunExcersieTwelve()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine();
                for (int x = 1; x < 11; x++)
                {
                    Console.Write($"{i*x}\t");
                }
            }
        }
        private static void RunExcersie13()
        {
            var random = new Random();
            int result = random.Next(1, 500);
            int myTal = 0;
            int antalförsök = 1;
            Console.WriteLine("Gissa ett tal mellan 1 och 500");
            myTal = int.Parse(Console.ReadLine());
            while (myTal != result)
            {
                antalförsök = antalförsök + 1;
                if (myTal < result)
                {
                    Console.WriteLine("Talet är större");
                }
                else
                {
                    Console.WriteLine("Talet är mindre");
                }
                Console.WriteLine("Gissa igen ett tal mellan 1 och 500");
                myTal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Grattis! Du gissade rätt! Talet var {myTal} och {antalförsök} antal försök");
        }

        private static void RunExcersise14()
        {
            var numberFromUser = new List<double>();
            double dataInput = 0;
            double sumInput = 0;
            
            while (dataInput != -1)
            {
                Console.WriteLine("Add a number");
                dataInput = double.Parse(Console.ReadLine());
                
                if (dataInput ==-1)
                    {
                    ;
                }
                else
                {
                    numberFromUser.Add(dataInput);
                    sumInput = sumInput + 1;
                }
                
            }
            double result = (numberFromUser.Sum()) / sumInput;
            double sumList = numberFromUser.Sum();
            Console.WriteLine($"The average is: {result} and the sum is: {sumList}.");

        }

        private static void RunExersise15()
        {
            int number = int.Parse(AskUserFor("Type a number"));

            for (int i = number - 1; i > 0; i--)
            {
               int rest = number % i;
                if (rest == 0)
                {
                    Console.Write($"{i} ");

                }
                else
                {
                  ;
                }
            }
        }

        private static void RunExersise16()
        {
            int number = int.Parse(AskUserFor("Type a number"));
            int sum =0;
            for (int i = number - 1; i > 0; i--)
            {
                int rest = number % i;
               
                if (rest == 0)
                {
                    Console.Write($"{i} ");
                    sum=sum+i;
                    if (sum == number)
                    {
                        Console.WriteLine($"The {number} is a perfect number");
                    }
                }
                
            }
        }


        static string AskUserFor(string forWhat)
        {
             Console.Write($"{forWhat}: ");
             return Console.ReadLine();
           
            //return Console.ReadKey(true).KeyChar;
        }
    }
}
