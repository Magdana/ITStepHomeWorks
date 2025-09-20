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
for (int j = 1; j <= i; j++)
{
result += "*";
}
result += "\n";
}
Console.WriteLine(result);
Console.ReadLine();

#endregion


#region Calculator
//ყველა ლუწი რიცხვი მითითებულ დიაპაზონში
try
{
    int first, second;
    do
    {
        Console.Write("enter first number: ");

        while (!int.TryParse(Console.ReadLine(), out first))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        Console.Write("enter second number: ");

        while (!int.TryParse(Console.ReadLine(), out second))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        Console.Clear();
    }
    while (first == second);

    int smallest = (first < second) ? first : second;
    int largest = (first > second) ? first : second;
    List<int> evenNumbers = new List<int>();
    for (int i = smallest; i <= largest; i++)
    {
        if (i % 2 == 0)
        {
            evenNumbers.Add(i);

        }
    }
    Console.WriteLine($"\nEven numbers between {smallest} and {largest} are:");
    Console.WriteLine(string.Join(", ", evenNumbers));
}
catch (Exception ex)
{

    throw new Exception(ex.Message);
}


#endregion