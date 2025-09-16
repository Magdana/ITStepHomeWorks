#region

//Print Numbers 1–10

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

#endregion

#region

// Sum of Numbers 1–100

int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine($"Sum = " + sum);


#endregion

#region

// Odd Numbers

for (int i = 1; i < 20; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

#endregion


#region

// Multiplication Table

Console.Write("enter the number: ");
int number = int.Parse(Console.ReadLine()?.Trim());
for (int i = 0; i <= 9; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}
#endregion


#region

//Reverse Numbers

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}


#endregion


#region

// Factorial

int factorial = 1;
Console.Write("enter the number : ");
if (int.TryParse(Console.ReadLine()?.Trim(), out int num))
{
    if (num == 0)
    {
        Console.WriteLine("Factorial of 0 = 1");
        return;
    }
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    Console.WriteLine($"Factorial of {num} = {factorial}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}


#endregion


#region

// Repeat Character

for (int i = 1; i <= 10; i++)
{
    Console.Write("*");
}


#endregion