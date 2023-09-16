internal class Game
    {

    /*
 1.You need to create a Math game containing the 4 basic operations
 2.The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
 3. Users should be presented with a menu to choose an operation
 4.You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
 5. You don't need to record results on a database. Once the program is closed the results will be deleted.
   

        */

   public int Add(int a, int b) 
        {
        return a + b;
        }

    public int Subtract(int a, int b)
        {
        return a - b;
        }



        private static void Main(string [ ] args)
        {

        //Menu  Addition , Subtraction , Multiplication , Division ,Previous game
        //User can select operator using switch statements
        //Prompt the user to give an answer?
        //Exit menu

        int selection ;
        
        //Print menu for user
        Console.WriteLine("          Math Game App           ");
        Console.WriteLine("**************MENU**********************");
        //List Games = [ Addition, Subtraction, Multiplication, Division ];

        Console.WriteLine("1. Addition"  ) ;
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. View Previous Game ");
        Console.WriteLine("6. Exit Game : ");
        Console.Write("Select a number from the menu : ");
      
        //This should be looped to continue selecting a new operations
        selection = int.Parse(Console.ReadLine());
        
        //Perform selections using switch statements

        switch (selection){ //this should be looped to continue asking user to perform a specific operation

        case 1:
            string cont;
            do
            {
                Console.WriteLine("Addition Game");
                //Random numbers picked for the operators
                Random randomNumber = new Random();
                int var1 = randomNumber.Next(1, 21);
                int var2 = randomNumber.Next(1, 21);
                Game addition = new Game();
                int answerKey = addition.Add(var1, var2);

                

                Console.Write(var1 + " + " + var2 + " = ");

                int ans = int.Parse(Console.ReadLine());

                if ( ans == answerKey )
                    {
                    Console.WriteLine("Answer is Correct!");
                    }
                else
                    {
                    Console.WriteLine("Answer is Wrong!");
                    }
                Console.Write("Contine Game (Y/N) :");
                 cont = Console.ReadLine();
                

            } while(cont == "Y" || cont =="y");
            
            break;
        case 2:
            
            int sub1 = 5;
            int sub2 = 4;
            int res;
            Console.WriteLine("Subtraction Game");

            //create a method for operation. So that we can save it somewhere and call it as previous
            Console.Write("{0} - {1} = ? ", sub1, sub2);
           res = int.Parse(Console.ReadLine());

            if ( res == 1 )
                {
                Console.WriteLine("Answer is Correct!");
                }
            else
                {
                Console.WriteLine("Answer is Wrong!");
                }

        
            Console.WriteLine(res);
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
    }