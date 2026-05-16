namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int s = 1; s <= num - i; s++)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
