namespace HomeWork13;

internal class SumInArray
{
    public static int SumOfElements(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }
}
