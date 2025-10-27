namespace HomeWork13;

internal class FindAllInArrayByValue
{
    public static int[] FindAllInArrayByValueMethod(int[] array, int[] values)
    {
        List<int> res = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (values.Contains(array[i]))
            {
                res.Add(array[i]);
            }
        }
        return res.ToArray();
    }
}
