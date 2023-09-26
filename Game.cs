using System;
using System.Collections.Generic;
using System.Linq;
namespace MathGame
{

    public class Games
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

        // print Levels of difficulty
        public void PrintMenu()
        {
            Console.Write("Hard - 3   ||");
            Console.Write("Medium - 2   ||");
            Console.WriteLine("Easy - 1 ");
        }


        public int firstRandom(int choice)
        {
            Random random = new Random();
            int firstNumber = 0;
            switch (choice)
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

        public int secondRandom(int choice)
        {
            Random random = new Random();
            int secondNumber = 0;
            switch (choice)
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


        public int NumberOfQuestions()
        {
            int questionNumber = int.Parse(Console.ReadLine());
            return questionNumber;
        }
        static void Main(string[] args)
        {
            //Variable declarations
            int selection,firstNumber, secondNumber,calculatedAnswer,userAnswer;
            string playOn, gameName,tracker;

            //Create list to store game history
            var previousGame = new List<string>();
            
            //Generate random numbers
            Random rand = new Random();

           //Print Menu to screen
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Previous Game History");
            Console.WriteLine("6. Select Random Game");
            Console.WriteLine("7. Exit Game");
           
         
            do 
            {
                
                Console.Write("Select a number on the Menu :");
                selection = int.Parse(Console.ReadLine());
                if (selection == 6) { selection = rand.Next(1, 4); }

                //Selections from Menu
                switch (selection)
                {
                    case 1:
                        do  // CONVERT TO FOR LOOP ?? yOU SLECTED THE GAME. hOW MANY DO YOU WAN TO PLAY
                        {
                            Games level = new Games();
                            gameName = "Addition Game";
                            Console.WriteLine(gameName);
                            level.PrintMenu();
                            Console.Write("Select the game level :");
                            int userChoice = int.Parse(Console.ReadLine());

                            //Logic to decide difficulty
                            firstNumber = level.firstRandom(userChoice);//
                            secondNumber = level.secondRandom(userChoice);
                            Console.Write("{0} + {1} = ", firstNumber, secondNumber);

                            //calculate time spent on question
                            var timer = System.Diagnostics.Stopwatch.StartNew();
                            userAnswer = int.Parse(Console.ReadLine());
                            var timeSpent = timer.ElapsedMilliseconds/1000;

                            calculatedAnswer = firstNumber + secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct.You spent {0} seconds on this game", timeSpent); }
                            else { Console.WriteLine("Answer is Wrong . You spent {0}seconds on this game", timeSpent); }

                            tracker = gameName + " " + firstNumber + " " + "+" + " " + secondNumber + "  =  " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);

                            Console.Write("Continue (Y/N) ");

                            playOn = Console.ReadLine();
                        } while (playOn == "Y" || playOn == "y" ); 

                        break;

                    case 2:
                        do
                        {
                            Games level = new Games();
                            gameName = "Subtraction Game";
                            Console.WriteLine(gameName);
                            level.PrintMenu();
                            Console.Write("Select the game level :");
                            int userChoice = int.Parse(Console.ReadLine());

                            //Logic to decide difficulty
                            firstNumber = level.firstRandom(userChoice);//
                            secondNumber = level.secondRandom(userChoice);
                            Console.Write("{0} - {1} = ", firstNumber, secondNumber);
                            
                            //calculate time spent on question
                            var timer = System.Diagnostics.Stopwatch.StartNew();
                            userAnswer = int.Parse(Console.ReadLine());
                            var timeSpent = timer.ElapsedMilliseconds/1000;
                            
                            calculatedAnswer = firstNumber - secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct.You spent {0} seconds on this game", timeSpent); }
                            else { Console.WriteLine("Answer is Wrong . You spent {0} seconds on this game", timeSpent); }
                            
                            tracker = gameName + " " + firstNumber + " " + " - " + secondNumber + " = " + " " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);
                            Console.Write("Continue (Y/N) ");
                            playOn = Console.ReadLine();
                        } while ( playOn == "Y" || playOn == "y");
                        break;

                    case 3:
                        do
                        {
                            Games level = new Games();
                            gameName = "Multiplication Game";
                            Console.WriteLine(gameName);
                            level.PrintMenu();
                            Console.Write("Select the game level :");
                            int userChoice = int.Parse(Console.ReadLine());

                            //Logic to decide difficulty
                            firstNumber = level.firstRandom(userChoice);//
                            secondNumber = level.secondRandom(userChoice);
                            Console.Write("{0} * {1} = ", firstNumber, secondNumber);

                            //calculate time spent on question
                            var timer = System.Diagnostics.Stopwatch.StartNew();
                            userAnswer = int.Parse(Console.ReadLine());
                            var timeSpent = timer.ElapsedMilliseconds/1000;
                            
                            calculatedAnswer = firstNumber * secondNumber;
                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct.You spent {0} seconds on this game", timeSpent); }
                            else { Console.WriteLine("Answer is Wrong . You spent {0} seconds on this game", timeSpent); }
                            
                            tracker = gameName + " " + firstNumber + " " + " * " + secondNumber + " = " + " " + userAnswer + " || correct Answer ===> " + calculatedAnswer;
                            previousGame.Add(tracker);
                            Console.Write("Continue (Y/N) ");
                            playOn = Console.ReadLine();
                        } while (playOn == "Y" || playOn == "y"  );
                        break;

                    case 4:
                        do
                        {

                            gameName = "Division Game";
                            Console.WriteLine(gameName);
                            Games level = new Games();
                            level.PrintMenu();
                            Console.Write("Select the game level :");
                            int userChoice = int.Parse(Console.ReadLine());

                            //Logic to decide difficulty
                            firstNumber = level.firstRandom(userChoice);//
                            secondNumber = level.secondRandom(userChoice);

                            while (firstNumber % secondNumber != 0 && userChoice == 1) {
                                secondNumber = rand.Next(1, 5);}

                            while (firstNumber % secondNumber != 0 && userChoice == 2){
                                secondNumber = rand.Next(1, 15);}

                            while (firstNumber % secondNumber != 0 && userChoice == 3){
                                secondNumber = rand.Next(1, 51); }
                            Console.Write("{0} / {1} = ", firstNumber, secondNumber);

                            //calculate time spent on question
                            var timer = System.Diagnostics.Stopwatch.StartNew();
                            userAnswer = int.Parse(Console.ReadLine());
                            var timeSpent = timer.ElapsedMilliseconds/1000;

                            calculatedAnswer = firstNumber / secondNumber;

                            if (userAnswer == calculatedAnswer) { Console.WriteLine("Answer is correct.You spent {0} seconds on this game", timeSpent); }
                            else { Console.WriteLine("Answer is Wrong . You spent {0} seconds on this game", timeSpent); }
                            
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
                    default:
                        //if{ } selection is not a number //aDD IF SELECTION IS NOT A 
                        Console.WriteLine("Input is not valid, please enter a number between 1 and 7 ");
                        break;
                }
            } while (selection != 7 );

           
        }
    }
}
