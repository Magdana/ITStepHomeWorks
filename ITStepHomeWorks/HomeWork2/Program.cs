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