namespace Topic_5._5___More_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            /* Console.WriteLine(die1.Roll);
            die1.DrawRoll();
            die1.RollDie();
            Console.WriteLine(die2.Roll);
            die2.DrawRoll();
            die2.RollDie();*/


            double userAcctTotal = 100.00;
            Console.WriteLine("Welcome to my dice game. You will start out with $100.\n" + 
                "\r\nTo play my game, you will roll two dice. To profit you must roll what you bet, for example: " + 
                "\nYou bet doubles and roll doubles, you win your bet");
            Console.WriteLine();
            Console.WriteLine("Roll            | Profit\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Doubles       \t| Win double their bet (2x). Ex. Bet is $5, user wins $10\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Not double  \t| Win half their bet. Ex. Bet is $10, user wins $5\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Even Sum   \t| Win their bet. Ex. Bet is $10, user wins $10\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Odd Sum     \t| Win their bet. Ex. Bet is $10, user wins $10\r");

        }
    }
}