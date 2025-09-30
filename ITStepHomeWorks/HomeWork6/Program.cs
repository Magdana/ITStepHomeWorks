// Print Array Element

int[] arr = [1, 2, 3, 4, 5];

void PrintArrayElement(Array array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array.GetValue(i));
    }
}

PrintArrayElement(arr);



// Find Maximum Element

int[] arr2 = [20, 30, 45, 15, 98, 12, 4, 88, 120];

string FindMaximumElement(Array array)
{
    int max = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        int value = Convert.ToInt32(array.GetValue(i));
        if (value > max)
        {
            max = value;
        }
    }
    return $"Max element is {max}";
}

Console.WriteLine(FindMaximumElement(arr2));



//Find Minimum Element

int[] arr3 = [20, 30, 45, 15, 98, 12, 4, 88, 120];
string FindMinimumElement(Array array)
{
    int min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        int value = Convert.ToInt32(array.GetValue(i));
        if (value < min)
        {
            min = value;
        }
    }
    return $"Min element is {min}";
}

Console.WriteLine(FindMinimumElement(arr3));



//Sum of Array Elements

int[] arr4 = [1, 2, 3, 4, 5];
string SumOfArrayElements(Array array)
{
    int total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        total += Convert.ToInt32(array.GetValue(i));
    }
    return $"Sum of array elements is {total}";
}
Console.WriteLine(SumOfArrayElements(arr4));



//Reverse Array

int[] arr5 = { 1, 2, 3, 4, 5 };

string ReverseArray(Array array)
{
    List<int> reversed = new List<int>();
    for (int i = array.Length - 1; i >= 0; i--)
    {
        reversed.Add(Convert.ToInt32(array.GetValue(i)));
    }
    foreach (var item in reversed)
    {
        Console.Write(item + " ");
    }
    return $"reversed array is: {reversed}";
}
ReverseArray(arr5);
Console.WriteLine("\n");



//Count Even and Odd Numbers

int[] arr6 = [20, 30, 45, 15, 98, 12, 4, 88, 120];

string CountEvenAndOddNumbers(Array array)
{
    int evenCount = 0;
    int oddCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int value = Convert.ToInt32(array.GetValue(i));
        if (value % 2 == 0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }
    }
    return $"even: {evenCount} odd: {oddCount}";
}
Console.WriteLine(CountEvenAndOddNumbers(arr6));


//Search Element in Array

Console.Write("enter the number: ");
int[] arr7 = [20, 30, 45, 15, 98, 12, 4, 88, 120];

string SearchElementInArray(Array array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Convert.ToInt32(array.GetValue(i)) == number)
        {
            return $"the number {number} exists in array";
        }
    }
    return $"the number {number} does not exist in array";
}
Console.WriteLine(SearchElementInArray(arr7, int.Parse(Console.ReadLine())));




//Copy Array

int[] arr8 = [20, 30, 45, 15, 98, 12, 4, 88, 120];

List<int> CopyArray(Array array)
{
    List<int> arrCopy = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        arrCopy.Add(Convert.ToInt32(array.GetValue(i)));
    }
    return arrCopy;
}

foreach (var item in CopyArray(arr8))
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");


//Second Largest Number

int[] arr9 = [20, 30, 45, 15, 98, 12, 4, 88, 120];

string SecondLargestNumber(Array array)
{
    int max = int.MinValue;
    int secondMax = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        int value = Convert.ToInt32(array.GetValue(i));
        if (value > max)
        {
            secondMax = max;
            max = value;
        }
        else if (value > secondMax && value != max)
        {
            secondMax = value;
        }
    }
    return $"Second largest number is {secondMax}";
}
Console.WriteLine(SecondLargestNumber(arr9));



//Frequency of Elements

int[] arr10 = [20, 20, 20, 30, 45, 45, 15, 98, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 88, 120];

string FrequencyOfElements(Array array)
{
    Dictionary<int, int> frequency = new Dictionary<int, int>();
    for (int i = 0; i < array.Length; i++)
    {
        int value = Convert.ToInt32(array.GetValue(i));
        if (frequency.ContainsKey(value))
        {
            frequency[value]++;
        }
        else
        {
            frequency[value] = 1;
        }
    }
    foreach (var item in frequency)
    {
        Console.WriteLine($"Element: {item.Key}, Frequency: {item.Value}");
    }
    return "";
}
Console.WriteLine(FrequencyOfElements(arr10));


