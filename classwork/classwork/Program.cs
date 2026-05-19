using System.Transactions;

namespace classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            შექმენით მინი ATM აპლიკაცია
            //decimal balance = 1000;
            //            მანამ მომხმარებელი არ შეიყვანს კონსოლში 4 - ს მანამდე მუდმივად გამოვიდეს სარჩევი შემდეგი ოფშენებით.
            //1 - Check Balance
            //2 - Deposit Money
            //3 - Withdraw Money
            //4 – Exit


            //1 - ის  არჩევის შემთხვევაში კონსოლში გამოიტანეთ ბალანსი.
            //2 - ის ან 3 - ის არჩევის შემთხვევაში მოსთხოვეთ შეიყვანოს ჩასარიცხი ან გამოსატანი თანხის მოცულობა.
            //ყურადღება მიაქციეთ ვალიდაციებს.

            decimal balance = 1000;

            byte choosenum = 0;

           
         while (true)
            {
                Console.WriteLine(" 1 - Check Balance\r\n 2 - Deposit Money\r\n 3 - Withdraw Money\r\n 4 – Exit");
                bool validChoose = byte.TryParse(Console.ReadLine(), out choosenum);

                if (!validChoose || choosenum > 4 || choosenum < 1)
                {
                    Console.WriteLine("Try again\r\n 1 - Check Balance\\r\\n 2 - Deposit Money\\r\\n 3 - Withdraw Money\\r\\n 4 – Exit\"");
                    continue;
                }

                switch (choosenum)
                {
                    case 1:
                        Console.WriteLine(balance);
                        break;
                    case 4:
                        Console.WriteLine("Good bye");
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("enter amount of deposit");
                            bool validamount = decimal.TryParse(Console.ReadLine(), out decimal amount);
                            if (!validamount || amount <= 0)
                            {
                                Console.WriteLine("Deposit must be more then 0");
                                continue;
                            }
                            balance += amount;
                            break;
                        }
                        break;
                    case 3:
                        if (balance == 0) break;

                        while (true)
                        {
                            Console.WriteLine("enter amount of withdraw");
                            bool validamount = decimal.TryParse(Console.ReadLine(), out decimal amount);
                            if (!validamount || amount <= 0 || amount > balance)
                            {
                                Console.WriteLine("withdraw must be more then 0");
                                continue;
                            }
                            balance -= amount;
                            break;
                        }
                        break;


                }

            }


        


            

            

        }
    }
}
