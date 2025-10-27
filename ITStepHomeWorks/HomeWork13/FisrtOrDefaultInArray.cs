namespace HomeWork13;

public class FisrtOrDefaultInArray
{
    public static int FirstOrDefault(int[] array, int value)
    {
        foreach (var item in array)
        {
            if (item == value)
            {
                return item;
            }
        }
        return default;
    }
}
