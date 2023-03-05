// Mini ATM proyekti

Console.WriteLine("Welcome to Azerbaijan Bank ATM");



int balans = 1000;
while (true)
{
    Console.WriteLine("****************");
    Console.WriteLine("1 - Balance");
    Console.WriteLine("2 - Withdraw money");
    Console.WriteLine("3 - Cash money");
    Console.WriteLine("q - Quit");
    Console.Write("Enter step number : ");



    string UserNumber =(Console.ReadLine());

    if (UserNumber == "1")
    {
        Console.WriteLine("Your balance is : " + balans);
    }
    else if (UserNumber == "2")
    {
        Console.WriteLine("Please enter withdraw money");
        int withdraw = int.Parse(Console.ReadLine());
        if (withdraw > balans)
        {
            Console.WriteLine("You do not have enough money");
        }
        else
        {

            balans -= withdraw;
            Console.WriteLine("Your current balance is :" + balans);
        }
    }
    else if (UserNumber == "3")
    {
        Console.WriteLine("Please enter your cash money");
        int CashMoney = int.Parse(Console.ReadLine());
        balans += CashMoney;
        Console.WriteLine("Now your current balance is :" + balans);
    }



    else if (UserNumber == "q")
    {
        Console.WriteLine("Thank you for using our bank");
        break;
    }
    else
    {
        Console.WriteLine("Please enter step correctly");
    }

} 
