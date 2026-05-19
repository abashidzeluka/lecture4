

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            decimal balance = 1000;

            byte choose = 0;

            

            while (true)
            {
                Console.WriteLine(" 1 - Check Balance\r\n 2 - Deposit Money\r\n 3 - Withdraw Money\r\n 4 – Exit");
                bool validChoose = byte.TryParse(Console.ReadLine(), out choose);

                if (validChoose)
                {
                    if (choose < 1 || choose > 4)
                    {
                        Console.WriteLine("Try again \r\n 1 - Check Balance\r\n 2 - Deposit Money\r\n 3 - Withdraw Money\r\n 4 – Exit");
                    }

                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Your balance is: " + balance);
                            break;
                        case 2:

                            Console.WriteLine("Enter deposit amount: ");
                            bool amountValid = decimal.TryParse(Console.ReadLine(), out decimal amount);

                            while (!amountValid || amount <= 0)
                            {
                                    Console.WriteLine("Amount must be more then 0, try again: ");
                                amountValid = decimal.TryParse(Console.ReadLine(), out amount);
                            }
                            balance += amount;
                            Console.WriteLine("Deposit successful!");
                            Console.WriteLine("New balance: " + balance);
                            break;
                        case 3:
                            if (balance == 0) break;
                            Console.WriteLine("Enter withdraw amount: ");
                            amountValid = decimal.TryParse(Console.ReadLine(), out amount);

                            while (!amountValid || amount <= 0 || amount > balance)
                            {
                                    Console.WriteLine("Amount must be more then 0 and less then balance!");
                                    amountValid = decimal.TryParse(Console.ReadLine(), out amount);
                            }

                            balance -= amount;
                            Console.WriteLine("Withdraw successful!");
                            Console.WriteLine("New balance: " + balance);
                            break;



                        case 4:
                                Console.WriteLine("Good bye!");
                            return;
                    }
                   

                }

            }

        }
    }
}
