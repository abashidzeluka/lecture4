using System.ComponentModel.Design;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            bool numValid = int.TryParse(Console.ReadLine(), out int num);

            while (!numValid)
            {
                Console.Write("invalid format try again:");
                numValid = int.TryParse(Console.ReadLine(), out num);
            }

            if (numValid)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num}*{i}={num * i}");
                }
            }
                                                                      
        }
    }
}
