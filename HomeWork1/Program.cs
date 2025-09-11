// 1. Login Authentication

Console.WriteLine("Registration");
Console.WriteLine("-------------");
Console.Write("Enter your username: ");
string username = Console.ReadLine() ?? string.Empty;
Console.Write("Enter your password: ");
string password = Console.ReadLine() ?? string.Empty;

Console.Clear();

Console.WriteLine("Login");
Console.WriteLine("------");
Console.Write("Enter your username: ");
string loginUsername = Console.ReadLine() ?? string.Empty;
Console.Write("Enter your password: ");
string loginPassword = Console.ReadLine() ?? string.Empty;
if (loginUsername == username && loginPassword == password)
{
    Console.WriteLine("Login Successful!");
}
else
{
    Console.WriteLine("Invalid credentials!");
}
Console.ReadKey();