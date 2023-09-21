using System;
using System.Collections.Generic;
using System.Linq;
namespace MathGame
{

    public class Program
    {
        static void Main(string[] args)
        {
            /*
1.You need to create a Math game containing the 4 basic operations
2.The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
3. Users should be presented with a menu to choose an operation
4.You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
5. You don't need to record results on a database. Once the program is closed the results will be deleted.


      */
            //Print Menu to screen
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Previous Game History");
            Console.WriteLine("6. Exit Game");
            //Variable declarations
            int selection;
            int firstNumber;
            int secondNumber;
            string playOn;
            string gameName;
            string tracker;
            int calculatedAnswer;
            int userAnswer;
            //Create list to store game history
            var previousGame = new List<string>();
            //Generate random numbers
            Random rand = new Random();
            do
            {

                Console.Write("Select a number on the Menu :");
                selection = int.Parse(Console.ReadLine());

                //Selections from Menu
                switch (selection)
                {
                    case 1:
                        do
                        {
                            firstNumber = rand.Next(1, 21);
                            secondNumber = rand.Next(1, 21);
                            gameName = "Addition Game";
                            Console.WriteLine(gameName);
                            Console.Write("{0} + {1} = ", firstNumber, secondNumber);
                            userAnswer = int.Parse(Console.ReadLine());
                            calculatedAnswer = firstNumber + secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct"); }
                            else { Console.WriteLine("Answer is Wrong"); }
                            tracker = gameName + " " + firstNumber + " " + "+" + " " + secondNumber + "  =  " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);
                            Console.Write("Continue (Y/N) ");
                            playOn = Console.ReadLine();
                        } while (playOn == "Y" || playOn == "y");

                        break;

                    case 2:
                        do
                        {
                            firstNumber = rand.Next(1, 21);
                            secondNumber = rand.Next(1, 21);
                            gameName = "Subtraction Game";
                            Console.WriteLine(gameName);
                            Console.Write("{0} - {1} = ", firstNumber, secondNumber);
                            userAnswer = int.Parse(Console.ReadLine());
                            calculatedAnswer = firstNumber - secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct"); }
                            else { Console.WriteLine("Answer is Wrong"); }
                            tracker = gameName + " " + firstNumber + " " + " - " + secondNumber + " = " + " " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);
                            Console.Write("Continue (Y/N) ");
                            playOn = Console.ReadLine();
                        } while (playOn == "Y" || playOn == "y");
                        break;

                    case 3:
                        do
                        {
                            firstNumber = rand.Next(1, 11);
                            secondNumber = rand.Next(1, 11);
                            gameName = "Multiplication Game";
                            Console.WriteLine(gameName);
                            Console.Write("{0} * {1} = ", firstNumber, secondNumber);
                            userAnswer = int.Parse(Console.ReadLine());
                            calculatedAnswer = firstNumber * secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct"); }
                            else { Console.WriteLine("Answer is Wrong"); }
                            tracker = gameName + " " + firstNumber + " " + " * " + secondNumber + " = " + " " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);
                            Console.Write("Continue (Y/N) ");
                            playOn = Console.ReadLine();
                        } while (playOn == "Y" || playOn == "y");
                        break;

                    case 4:
                        do
                        {
                            firstNumber = rand.Next(1, 101);
                            secondNumber = rand.Next(1, 11);
                            while (firstNumber % secondNumber != 0)
                            {
                                secondNumber = rand.Next(1, 11);
                            }
                            gameName = "Division Game";
                            Console.WriteLine(gameName);
                            Console.Write("{0} / {1} = ", firstNumber, secondNumber);
                            userAnswer = int.Parse(Console.ReadLine());
                            calculatedAnswer = firstNumber / secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct"); }
                            else { Console.WriteLine("Answer is Wrong"); }
                            tracker = gameName + " " + firstNumber + " " + " / " + secondNumber + " = " + " " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);
                            Console.Write("Continue (Y/N) ");
                            playOn = Console.ReadLine();
                        } while (playOn == "Y" || playOn == "y");
                        break;

                    case 5:
                        Console.WriteLine("Previous Game History");
                        for (int i = 0; i < previousGame.Count; i++) { Console.WriteLine(previousGame[i]); }
                        break;
                }
            } while (selection != 6);

        }
    }
}
