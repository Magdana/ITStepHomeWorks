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


//2. Grade Calculator

Console.WriteLine("Grade Calculator");
Console.WriteLine("----------------");
Console.Write("Enter your score (0-100): ");
int input = int.Parse(Console.ReadLine().Trim());
if(input < 0 || input > 100)
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