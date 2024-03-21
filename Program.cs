namespace Topic_5._5___More_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            bool done = false;
            string userPrediction, dieOutcome, playAgain;
            double userBet, userAcctTotal = 100.00;
            int dieRoll1, dieRoll2;
            Die die1 = new Die();
            Die die2 = new Die();


            Console.WriteLine("Welcome to my dice game. You will start out with $100.\n" + 
                "\r\nTo play my game, you will roll two dice. To profit you must roll what you bet, for example: " + 
                "\nYou bet doubles and roll doubles, you win your bet");
            Console.WriteLine();
            Console.WriteLine("Roll            | Profit\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Doubles       \t| Win/Lose double their bet (2x). Ex. Bet is $5, user wins $10\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Not Doubles  \t| Win/Lose half their bet. Ex. Bet is $10, user wins $5\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Even Sum   \t| Win/Lose their bet. Ex. Bet is $10, user wins $10\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Odd Sum     \t| Win/Lose their bet. Ex. Bet is $10, user wins $10\r");
            Console.WriteLine();
            while (!done && userAcctTotal > 0)
            {
                Console.Write("How much would you like to bet? ");
                userBet = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                if (userBet > 0 && userBet <= userAcctTotal)
                {
                    Console.WriteLine($"You have bet ${userBet}");
                }
                else if (userBet <= 0 || userBet > userAcctTotal)
                {
                    Console.WriteLine("You have bet an invalid number, so your bet is $0.00");
                    userBet = 0;
                }
                else
                {
                    Console.WriteLine("Your bet was invalid, so your bet is $0.00");
                    userBet = 0;
                }
                Console.Write("What outcome do you predict? Please type your prediction exactly: ");
                userPrediction = Console.ReadLine().ToLower().Trim().Replace(" ", "");
                Console.WriteLine("Now it's time to roll!");
                Console.WriteLine(die1.Roll);
                die1.DrawRoll();
                die1.RollDie();
                dieRoll1 = die1.Roll;
                Console.WriteLine(die2.Roll);
                die2.DrawRoll();
                die2.RollDie();
                dieRoll2 = die2.Roll;

                // Doubles
                if (die1.Roll == die2.Roll)
                {
                    dieOutcome = "doubles";
                    Console.WriteLine("The outcome was doubles");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += (userBet * 2);
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= (userBet * 2);
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                // Not Doubles
                else if (die1.Roll != die2.Roll)
                {
                    dieOutcome = "notdoubles";
                    Console.WriteLine("The outcome was not doubles");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += (userBet / 2);
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= (userBet / 2);
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                // Even Sum
                else if (dieRoll1 + dieRoll2 == 2 || dieRoll1 + dieRoll2 == 4 || dieRoll1 + dieRoll2 == 6 || dieRoll1 + dieRoll2 == 8 || dieRoll1 + dieRoll2 == 10 || dieRoll1 + dieRoll2 == 12)
                {
                    dieOutcome = "evensum";
                    Console.WriteLine("The outcome was an even sum");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += userBet;
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= userBet;
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                // Odd Sum
                else if (dieRoll1 + dieRoll2 == 3 || dieRoll1 + dieRoll2 == 5 || dieRoll1 + dieRoll2 == 7 || dieRoll1 + dieRoll2 == 9 || dieRoll1 + dieRoll2 == 11)
                {
                    dieOutcome = "oddsum";
                    Console.WriteLine("The outcome was an odd sum");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += userBet;
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= userBet;
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                Console.WriteLine($"Your new account balance is {userAcctTotal}");
                Console.WriteLine("");
                Console.Write("Would you like to play again? Yes or no: ");
                playAgain = Console.ReadLine().ToLower().Trim().Replace(" ", "");
                if (playAgain == "no")
                {
                    done = true;
                }
            }
        }
    }
}