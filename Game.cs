using System;
using System.Collections.Generic;

namespace MathGame
{

    public class Program
    {
        static void Main(string[] args)
        {

            //Print Menu to screen
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Previous Game");
            Console.WriteLine("6. Exit Game");

            int selection;
            Random rand = new Random();
            int firstNumber;
            int secondNumber;
            string playOn;
            string gameName;
            string tracker;

            int calculatedAnswer;
            int userAnswer;
            var previousGame = new List<string>();

            do
            {

                Console.Write("Select Game to play :");
                selection = int.Parse(Console.ReadLine());

                //Selections
                switch (selection)
                {
                    case 1:
                        do
                        {
                            firstNumber = rand.Next(1, 21);
                            secondNumber = rand.Next(1, 21);
                            gameName = "Addition";
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
                            gameName = "Subtraction";
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
                            gameName = "Multiplication";
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
                            firstNumber = rand.Next(1, 21);
                            secondNumber = rand.Next(1, 21);
                            gameName = "Division";
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
                        Console.WriteLine("Previous Game selected");
                        for (int i = 0; i < previousGame.Count; i++) { Console.WriteLine(previousGame[i]); }

                        break;
                }
            } while (selection != 6);

        }
    }
}
