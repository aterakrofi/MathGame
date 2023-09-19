using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Game
    {

    /*
 1.You need to create a Math game containing the 4 basic operations
 2.The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
 3. Users should be presented with a menu to choose an operation
 4.You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
 5. You don't need to record results on a database. Once the program is closed the results will be deleted.
   

        */

    //Method to display Menu
    public void Menu()
        {
        //Print menu for user
        Console.WriteLine("          Math Game App           ");
        Console.WriteLine("**************MENU**********************");
        string Game1 = "1. Addition";

        string Game2 = "2. Subtraction";
        string Game3 = "3. Multiplication";
        string Game4 = "4. Division";
        string menu1 = "5. View Previous Game ";
        string menu2 = "6. Exit Game : ";

        Console.WriteLine(Game1); //Menu will be as functions so that user can call them in any screen
        Console.WriteLine(Game2);
        Console.WriteLine(Game3);
        Console.WriteLine(Game4);
        Console.WriteLine(menu1);
        Console.WriteLine(menu2);
       

        }

    //Selections 

    //Operations
    public int Add(int a, int b)
        {
        return a + b;
        //Math operations go here
        }

    public int Subtract(int a, int b)
        {
        return a - b;
        }

    //Random Number

    public int FirstRandonNumber(int startRange , int endRange)
        {
        //Random numbers picked for the operators
        Random randomNumber = new Random();
        int firstNum = randomNumber.Next(startRange, endRange);

        return firstNum;
        }

    public int SecondRandonNumber(int startRange, int endRange)
        {
        //Random numbers picked for the operators
        Random randomNumber = new Random();
        int secondNum = randomNumber.Next(startRange, endRange);

        return secondNum;
        }

        //Method for selection
        public void SelectGame()
        {
        int selection;

        //This should be looped to continue selecting a new operations
        Console.Write("Select a number from the menu : ");
        selection = int.Parse(Console.ReadLine());  // ----> This should be a return from the method so that it can be added to method for previous

        //Perform selections using switch statements

        switch ( selection )
            { //this should be looped to continue asking user to perform a specific operation

        case 1:
            string cont;
            do
                {

                Console.WriteLine("Addition Game");
                //Random numbers picked for the operators
                
                Game addition = new Game();

                 int firstNumber =  addition.FirstRandonNumber(1,21);
                 int secondNumber = addition.SecondRandonNumber(1, 21);

                 int answerKey = addition.Add(firstNumber, secondNumber );

                Console.Write(firstNumber + " + " + secondNumber + " = ");

                int ans = int.Parse(Console.ReadLine());

                
                //This should be a called method so that it can be used everywhere
                string strNumber1 = firstNumber.ToString();
                string strNumber2 = secondNumber.ToString();
                string strAnswer = ans.ToString();

                string Prev = strNumber1 + " " + " + " + strNumber2 + " " + " = " + strAnswer;
                //string previous = "Previous Game : {0} + {1} = {2}",firstNumber, secondNumber, ans ); // this will be a function that can be called

                //switch into if 1 is selected then currentGame = that

                if ( ans == answerKey )
                    {
                    Console.WriteLine("Answer is Correct!");
                    }
                else
                    {
                    Console.WriteLine("Answer is Wrong!");
                    }
                Console.WriteLine("The previous game is {0} --> {1}", selection, Prev); //call the method to reveal previous game.so that user can call them in any screen
                Console.Write("Contine Game (Y/N) or (0/1) to return to menu:");

                cont = Console.ReadLine();



                } while ( cont == "Y" || cont =="y" );

            break;
        case 2:
            Console.WriteLine("Subtraction Game");

            break;
        case 3:
            Console.WriteLine("Multiplication Game");
            break;
        case 4:
            Console.WriteLine("Division Game");
            break;
        case 5:
            Console.WriteLine("Previous Game");
            Console.ReadLine();



            break;
        default:
            Console.WriteLine("Exit");
            break;
            }

        }

   public void PreviousGame()
        {
        Game previous = new Game();
        previous.SelectGame();
        
        }


    private static void Main(string [ ] args)
        {

        //Menu  Addition , Subtraction , Multiplication , Division ,Previous game
        //User can select operator using switch statements
        //Prompt the user to give an answer?
        //Exit menu
        Game game = new Game();
        game.Menu(); //Print Menu
        game.SelectGame(); //Select Game to play
        game.PreviousGame();

        }
    }