using System;

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
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void RunExerciseOne()
        {
            string firstName;
            string lastName;
           Console.WriteLine("Hello <firstName> <lastName>! I’m glad to inform you that you are the test \tsubject ofmy very first assignment!");
        }

        private static void RunExerciseTwo()
        {
            Console.WriteLine("The second Exercise");
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
            string myText;
            string subTemp;
            myText = Console.WriteLine("Write your text here: "); //The brown fox jumped over the lazy dog
            subTemp = input.substring(0, 3);

        }
    }
}
