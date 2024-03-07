using System.Globalization;
using Entities;
using Entities.Exceptions;

Account account;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial Balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Withdraw Limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account = new Account(number, holder, balance, withDrawLimit);

    Console.WriteLine();

    Console.Write("Enter amouunt for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account.WithDraw(amount);


    Console.WriteLine("Balance Updated: ");
    Console.WriteLine(account);
}
catch(DomainException e)
{
    Console.WriteLine("Error in operation: " + e.Message);
}

catch(FormatException e)
{
    Console.WriteLine("Error in operation: " + e.Message );
}

catch(Exception e)
{
    Console.WriteLine("Unexpected Error: " + e.Message);
}


Console.ReadKey();



