namespace HomeWork13;

public class LastOrDefaultInArray
{
    public static int LastOrDefault(int[] array, int value)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == value)
            {
                return array[i];
            }
        }
        return default;
    }
}
