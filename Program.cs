internal class Program
    {

    /*
 1.You need to create a Math game containing the 4 basic operations
 2.The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
 3. Users should be presented with a menu to choose an operation
 4.You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
 5. You don't need to record results on a database. Once the program is closed the results will be deleted.
   

        */

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
       
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. View Previous Game ");
        Console.WriteLine("6. Exit Game : ");
        Console.Write("Select a number from the menu : ");
      
        selection = int.Parse(Console.ReadLine());
        //Perform selections using switch statements

        switch (selection){

        case 1:
            int num1 = 4;
            int num2 = 5;
            int ans;
            Console.WriteLine("Addition Game");
            Console.Write("{0} + {1} = ? ", num1, num2);
            ans = int.Parse(Console.ReadLine());

            if (ans == 9 )
                {
                Console.WriteLine("Answer is Correct!");
                }
              else
                {
                Console.WriteLine("Answer is Wrong!");
                }
            
            
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
            break;
        default:
            Console.WriteLine("Exit");
            break;
            }

        }
    }