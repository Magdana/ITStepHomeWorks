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