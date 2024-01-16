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
            int numberOfGuesses = 1;
            if (userGuess != favNumber)
            {
                do
                {
                    Console.WriteLine(Evaluate(userGuess, favNumber));
                    userGuess = Guess();
                    ++numberOfGuesses;
                }
                while (userGuess != favNumber);
            }
            
            Console.WriteLine($"You got it! It took you {numberOfGuesses} attempts to guess the number {favNumber}.");

            //Console.WriteLine("What is your favorite subject in school?");
            //string favSubject = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Here's a joke you might like:");
            //Console.WriteLine(SubjectMessage(favSubject));
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

        public static string SubjectMessage(string favSubject)
        {
            string message;

            switch (favSubject.ToLower())
            {
                case "math":
                    message = "Why is six afraid of seven?\n" +
                        "Because 789!";
                    break;
                case "english":
                    message = "Knock knock.\n" +
                        "Who's there?\n" +
                        "To.\n" +
                        "To who?\n" +
                        "No, to WHOM.";
                    break;
                case "science":
                    message = "What did the biologist wear to impress their date?\n" +
                        "Designer genes.";
                    break;
                case "french" or "spanish":
                    message = "Have you ever wanted to speak a foreign language fluently?\n" +
                        "I did. So I went to Germany and spoke English.";
                    break;
                case "history":
                    message = "How was the Roman Empire cut in half?\n" +
                        "With a pair of Caesars.";
                    break;
                default:
                    message = "Why are fish so smart?\n" +
                        "Because they live in schools!";
                    break;
            }

            return message;
        }
    }
}
