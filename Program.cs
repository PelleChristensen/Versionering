namespace Versionering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string obj = Console.ReadLine();

            Console.WriteLine("Du slog, " + Dice.RollDice() + "!");
        }
    }
}
