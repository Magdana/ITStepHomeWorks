namespace HomeWork13;

public static class ReverseArray
{
    public static int[] Reverse(int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[array.Length - 1 - i];
        }
        return result;
    }
}