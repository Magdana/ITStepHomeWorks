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


#region

// 4. Day of the Week

Console.Write("enter the number (1-7) : ");
int numberOfDay = int.Parse(Console.ReadLine().Trim());
if (numberOfDay < 1 || numberOfDay > 7)
{
    Console.WriteLine("Invalid day number");
    Console.ReadLine();
    return;
}
List<int> daysInNumbers = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7
};

List<string> days = new List<string>()
{
  "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
};

var dayIndex = daysInNumbers.FindIndex(d => d == numberOfDay);
Console.WriteLine(days[dayIndex]);
Console.ReadLine();

#endregion

#region

// 5. Traffic Light System

Console.Write("signal ('Red', 'Yellow', 'Green'): ");
string signal = Console.ReadLine()?.Trim();

if (string.IsNullOrWhiteSpace(signal) || (signal != "Red" && signal != "Yellow" && signal != "Green"))
{
    Console.WriteLine("Invalid signal");
    Console.ReadLine();
    return;
}
if (signal == "Red")
{
    Console.WriteLine("Stop!");
    Console.ReadLine();
}
else if (signal == "Yellow")
{
    Console.WriteLine("Get Ready!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Go!");
    Console.ReadLine();
}

#endregion


#region

// 6. ATM Withdrawal Validation

Console.WriteLine("ATM Withdrawal Validation");
Console.WriteLine("-------------------------");
Console.Write("Enter your balanse: ");
int balance = int.Parse(Console.ReadLine()?.Trim());
if (balance < 0)
{
    Console.WriteLine("Balance cannot be negative.");
    Console.ReadLine();
    return;
}
Console.Write("Enter the amount to withdraw: ");
int withdrawAmount = int.Parse(Console.ReadLine().Trim());
if (withdrawAmount <= 0)
{
    Console.WriteLine("Invalid withdrawal amount");
    Console.ReadLine();
    return;
}
if (withdrawAmount > balance)
{
    Console.WriteLine("Insufficient balance");
    Console.ReadLine();
    return;
}
balance -= withdrawAmount;
Console.WriteLine($"Withdrawal successful! Remaining balance: {balance}");
Console.ReadLine();
#endregion

#region

// 7. Pass/Fail Result


Console.WriteLine("Pass/Fail Result");
Console.WriteLine("----------------");

Console.Write(" enter your score (score 0–100): ");
int score = int.Parse(Console.ReadLine().Trim());
if (score < 0 || score > 100)
{
    Console.WriteLine("Score must be between 0 and 100.");
    Console.ReadLine();
    return;
}
if (score >= 50)
{
    Console.WriteLine("Pass");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Fail");
    Console.ReadLine();
}

#endregion