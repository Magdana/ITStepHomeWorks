namespace HomeWork13;

internal class FindLastIndexInArray
{
    public static int FindLastIndex(int[] array, int value)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
}
