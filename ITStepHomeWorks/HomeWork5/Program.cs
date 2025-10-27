// Print Array Element

int[] arr = [1, 2, 3, 4, 5];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


// Find Maximum Element

int[] arr2 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
int max = arr2.Max();
Console.WriteLine($"Max element is {max}");


//Find Minimum Element

int[] arr3 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
int min = arr3.Min();
Console.WriteLine($"Min element is {min}");


//Sum of Array Elements

int[] arr4 = [1, 2, 3, 4, 5];

int sum = arr4.Sum();
Console.WriteLine($"Sum of array elements is {sum}");


//Reverse Array

int[] arr5 = { 1, 2, 3, 4, 5 };
List<int> reversed = new List<int>();
for (int i = arr5.Length - 1; i >= 0; i--)
{
    reversed.Add(arr5[i]);
}
foreach (var item in reversed)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");


//Count Even and Odd Numbers

int[] arr6 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
int evenCount = 0;
int oddCount = 0;

for (int i = 0; i < arr6.Length; i++)
{
    if (arr6[i] % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}
Console.WriteLine($"even: {evenCount}, odd: {oddCount}");


//Search Element in Array

Console.Write("enter the number: ");
int[] arr7 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
int number;
if (int.TryParse(Console.ReadLine(), out number))
{
    if (arr7.Contains(number))
        Console.WriteLine($"the number {number} exists in array");
    else Console.WriteLine($"the number {number} does not exist in array");
}


//Copy Array

int[] arr8 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
List<int> arrCopy = new List<int>();
for (int i = 0; i < arr8.Length; i++)
{
    arrCopy.Add(arr8[i]);
}
foreach (int item in arrCopy)
{
    Console.WriteLine(item);
}


////Second Largest Number

//int[] arr9 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
//int max = arr9.Max();
//int[] secondArr = arr9.Where(x => x != max).ToArray();
//int secondMax = secondArr.Max();
//Console.WriteLine(secondMax);



////Frequency of Elements

//int[] arr9 = [20, 20, 20, 30, 45, 45, 15, 98, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 88, 120];
//int[] dist = arr9.DistinctBy(i => i).ToArray();


//for (int i = 0; i < dist.Length; i++)
//{
//    List<int> list = new List<int>();
//    for (int j = 0; j < arr9.Length; j++)
//    {
//        if (arr9[j] == dist[i])
//        {
//            list.Add(j);
//        }
//    }
//    Console.WriteLine($"count of: {dist[i]} is: " + list.Count());
//}


List<int> numbers = GetNumbers();
Console.WriteLine($"is winner: {IsWinner(numbers)}");


static List<int> GetNumbers()
{
    List<int> numbers = new List<int>();
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"enter the number {i}");
        numbers.Add(int.Parse(Console.ReadLine()));
        Console.Clear();
    }
    return numbers;
}

static bool IsWinner(List<int> numbers)
{
    bool isWinner = false;

    if (numbers.Contains(0) && numbers.Contains(2) && numbers.Contains(6))
    {
        isWinner = true;
    }
    return isWinner;
} 
