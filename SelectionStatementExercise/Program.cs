namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            int userGuess = Guess();
            
            do
            {
                Console.WriteLine(Evaluate(userGuess, favNumber));
                userGuess = Guess();
            } while (userGuess != favNumber);

            Console.WriteLine($"You got it! I was thinking of the number {favNumber}.");
        }

        public static int Guess()
        {
            Console.Write("What number am I thinking of? ");
            int guess = int.Parse(Console.ReadLine());
            return guess;
        }

        public static string Evaluate(int userGuess, int actualNumber)
        {
            bool tooLow = userGuess < actualNumber;
            bool tooHigh = userGuess > actualNumber;

            string message;

            if (tooLow)
            {
                message = "Too low! Try again:";
            }
            else if (tooHigh)
            {
                message = "Too high! Try again:";
            }
            else
            {
                message = "Sorry, I didn't understand. Try again:";
            }
            return message;
        }
    }
}
