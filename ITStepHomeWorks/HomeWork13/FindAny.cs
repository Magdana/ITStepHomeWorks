namespace HomeWork13;

public class FindAny
{
    public static bool FindAnyEx(int[] array, int[] values)
    {
        foreach (var item in array)
        {
            if (values.Contains(item))
            {
                return true;
            }
        }
        return false;
    }
}
