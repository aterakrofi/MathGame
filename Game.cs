using System;
using System.Collections.Generic;
using System.Linq;
namespace MathGame
{

    public class Games
    {
        public int PrintMenu()
            {
                Console.Write("Hard - 3   ||");
                Console.Write("Medium - 2   ||");
                Console.WriteLine("Easy - 1 ");
                Console.Write("Select the game level :");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public int UserInput()
        {

            return int.Parse(Console.ReadLine());
        }


        Random random = new Random();
       
        public int FirstRandom()
        {
            int firstNumber = 0;
           
            Games newLevel = new Games();
            int levelSelection = newLevel.PrintMenu();

            switch (levelSelection)
            {
                case 1:  //easy
                    firstNumber = random.Next(1, 11);
                    break;
                case 2: //medium
                    firstNumber = random.Next(11, 21);
                    break;
                case 3: //Hard 
                    firstNumber = random.Next(21, 101);
                    break;
            }
            return firstNumber;
        }
        public int SecondRandom()
        {
            
            int secondNumber = 0;
            Games newLevel = new Games();
            int levelSelection = newLevel.PrintMenu();

            switch (levelSelection)
            {
                case 1:  //easy
                    secondNumber = random.Next(1, 11);
                    break;
                case 2: //medium
                    secondNumber = random.Next(11, 21);
                    break;
                case 3: //Hard 
                    secondNumber = random.Next(21, 101);
                    break;
            }
            return secondNumber;
        }

         
   
        


        static void Main(string[] args)
        {
            /*
1.You need to create a Math game containing the 4 basic operations
2.The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
3. Users should be presented with a menu to choose an operation
4.You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
5. You don't need to record results on a database. Once the program is closed the results will be deleted.

 1. Try to implement levels of difficulty.
 2. Add a timer to track how long the user takes to finish the game.
 3. Add a function that let's the user pick the number of questions.
 4. Create a 'Random Game' option where the players will be presented with questions from random operations


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
                            
                            gameName = "Addition Game";
                            Console.WriteLine(gameName);
                            Games level= new Games();
                            //level.PrintMenu();

                           //Logic to decide difficulty
                            firstNumber = level.FirstRandom();//
                            secondNumber = level.SecondRandom();

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
