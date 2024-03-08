namespace Topic_5._5___More_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine(die1.Roll);
            die1.DrawRoll();
            die1.RollDie();
            Console.WriteLine(die2.Roll);
            die2.DrawRoll();
            die2.RollDie();
        }
    }
}