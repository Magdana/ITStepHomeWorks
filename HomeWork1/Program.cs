#region
// 1. Login Authentication

Console.WriteLine("Registration");
Console.WriteLine("-------------");
Console.Write("Enter your username: ");
string username = Console.ReadLine()?.Trim();
Console.Write("Enter your password: ");
string password = Console.ReadLine()?.Trim();
if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
{
    Console.WriteLine("credentials cannot be empty. Please enter valid information!");
    Console.ReadKey();
    return;
}

Console.Clear();

Console.WriteLine("Login");
Console.WriteLine("------");
Console.Write("Enter your username: ");
string loginUsername = Console.ReadLine()?.Trim();
Console.Write("Enter your password: ");
string loginPassword = Console.ReadLine()?.Trim();
if (loginUsername == username && loginPassword == password)
{
    Console.WriteLine("Login Successful!");
}
else
{
    Console.WriteLine("Invalid credentials!");
}
Console.ReadKey();
#endregion


#region
//2. Grade Calculator

Console.WriteLine("Grade Calculator");
Console.WriteLine("----------------");
Console.Write("Enter your score (0-100): ");
int input = int.Parse(Console.ReadLine().Trim());
if (input < 0 || input > 100)
{
    Console.WriteLine("Score must be between 0 and 100.");
    Console.ReadLine();
    return;
}
if (input < 70)
{
    Console.WriteLine("Grade: C or below");
    Console.ReadLine();
}
else if (input >= 70 && input < 80)
{
    Console.WriteLine("Grade: B");
    Console.ReadLine();
}
else if (input >= 80 && input < 90)
{
    Console.WriteLine("Grade: A");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Grade: A+");
    Console.ReadLine();
}

#endregion


#region
// 3.Discount Calculation
Console.WriteLine("Discount Calculation");
Console.WriteLine("--------------------");
Console.Write("Enter the total purchase amount: ");
decimal amount = decimal.Parse(Console.ReadLine().Trim());
if (amount <= 0)
{
    Console.WriteLine("Amount cannot be negative or null.");
    Console.ReadLine();
    return;
}
decimal discount;
decimal amountToPay;
if (amount > 1000)
{
    discount = amount * 0.10m;
    amountToPay = amount - discount;
}
else
{
    discount = amount * 0.05m;
    amountToPay = amount - discount;
}
Console.WriteLine($"Discount: {discount}, amount to pay {amountToPay}");
Console.ReadLine();

#endregion
