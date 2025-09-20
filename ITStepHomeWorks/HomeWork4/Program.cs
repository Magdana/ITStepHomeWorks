#region Half Pyramid of Stars
//დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას.

Console.Write("enter the number : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Invalid input. Please enter a valid integer: ");
}

string result = "";

for (int i = 1; i <= number; i++)
{
    for(int j = 1; j <= i; j++)
    {
        result += "*";
    }
    result += "\n";
}
Console.WriteLine(result);
Console.ReadLine();

#endregion