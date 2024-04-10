using The_Sieve.Classes;

namespace The_Sieve;

class Program
{
    
    static void Main(string[] args)
    {
        string? strChoice = "";
        Sieve sieve = new Sieve(); 
        int userChoice = 0; 

        do
        {
            //gatthering input 
            Console.WriteLine("Pick a filter: ");
            Console.WriteLine("1: EvenGood");
            Console.WriteLine("2: PositiveGood");
            Console.WriteLine("3: TensGood"); 
            userChoice = Convert.ToInt32(Console.ReadLine());

            //construct sieve class based on chosen varient of delegate type
            switch (userChoice)
            {
                case 1:
                    sieve = new Sieve(Good.EvenGood);
                    break; 

                case 2:
                    sieve = new Sieve(Good.PositiveGood);
                    break;

                case 3:
                    sieve = new Sieve(Good.TensGood);
                    break;

                default:
                    Console.WriteLine("Try again.");
                    userChoice = 0; 
                    break;
                    
            }//end switch


            //ask user to give input for method arg.
            
            do
            {
                userChoice = 0;


                Console.WriteLine("Enter a integer: ");
                userChoice = Convert.ToInt32(Console.ReadLine());
                sieve.IsGood(userChoice);


                //ask user if they would like to pick another num
                Console.WriteLine("Go again? Y/N");
                strChoice = Console.ReadLine();

            } while (strChoice == "Y" || strChoice == "y");


            //ask user if they would like to go back to the start of parent loop.
            Console.WriteLine("Select a new sieve type? Y/N");
            strChoice = Console.ReadLine();


        } while (strChoice == "Y" || strChoice == "y");//end parent loop
    }
}
