namespace HomeWork13
{
    public static class SortArray
    {
        public static int[] SortIntArray(int[] array)
        {
            int[] sorted = (int[])array.Clone();
            Array.Sort(sorted);
            return sorted;
        }
    }
}