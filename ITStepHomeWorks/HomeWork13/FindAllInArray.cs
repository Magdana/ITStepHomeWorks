namespace HomeWork13;

public class FindAllInArray
{
    public static bool FindAll(int[] array, int[] values)
    {
        List<int> result = new List<int>();
        foreach (var item in array)
        {
            if (values.Contains(item))
            {
                result.Add(item);
            }
        }
        if (result.Count == values.Length)
        {
            return true;
        }
        return false;
    }
}
