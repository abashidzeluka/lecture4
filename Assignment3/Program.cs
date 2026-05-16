namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            bool numValid = int.TryParse(Console.ReadLine(), out int num);
            int res = 0;
            if (numValid)
            {
                
                for (int i = 0; i < num; i+=2)
                {
                    res += i;
                    
                }
                
            }
            Console.WriteLine(res);
        }
    }
}
