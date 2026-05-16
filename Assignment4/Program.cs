namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);

            int guess = 0;

            while (guess != secret)
            {
                Console.Write("Guess the number (1-100): ");
                guess = int.Parse(Console.ReadLine());

                if (guess < secret)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }
            }
        }
    }
}
