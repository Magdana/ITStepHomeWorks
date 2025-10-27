namespace HomeWork13;

delegate int[] ReverseArrayOperation(int[] array);
delegate int[] SortArrayOperation(int[] array);
delegate bool FindAnyOperation(int[] array, int[] value);
delegate bool FindAllOperation(int[] array, int[] value);
delegate int FirstOrDefaultOperation(int[] array, int value);
delegate int LastOrDefaultOperation(int[] array, int value);
delegate int[] FindAllInArrayByValueOperation(int[] array, int[] values);
delegate int FindIndexOperation(int[] array, int value);
delegate int FindLastIndexOperation(int[] array, int value);
delegate int SumInArrayOperation(int[] array);

class Program
{
    static void Main(string[] args)
    {
        //Reverse აბრუნებს გადაცემული მასივის შეტრიალებულ ვარიანტს

        int[] numbers = { 1, 2, 3, 4, 5 };
        ReverseArrayOperation reverseOperation = new ReverseArrayOperation(ReverseArray.Reverse);

        int[] reversedArray = reverseOperation(numbers);

        Console.WriteLine($"reversed: {string.Join(", ", reversedArray)}");


        //Sort აბრუნებს გადაცემული მასივის დალაგებულ ვარიანტს

        int[] numbers2 = { 5, 3, 4, 1, 2 };
        SortArrayOperation sortOperation  = new SortArrayOperation(SortArray.SortIntArray);

        int[] sortedArray = sortOperation(numbers2);

        Console.WriteLine($"sorted: {string.Join(", ", sortedArray)}");


        //Any აბრუნებს true თუ მასივის რომელიმე ელემენტი ემთხვევა მოსაძებნად გადაცემულ ელემენტებს

        int[] numbers3 = { 1, 2, 3, 4, 5 };
        FindAnyOperation findAnyOperation = new FindAnyOperation(FindAny.FindAnyEx);

        bool found = findAnyOperation(numbers3, new int[] { 5,8 });
        Console.WriteLine($"found any: {found}");


        //All აბრუნებს true თუ მასივის ყველა ელემენტი ემთხვევა მოსაძებნად გადაცემულ ელემენტებს

        int[] numbers4 = { 1, 2, 3, 4, 5 };
        FindAllOperation findAllOperation = new FindAllOperation(FindAllInArray.FindAll);
        bool allFound = findAllOperation(numbers4, new int[] { 1,2,7 });
        Console.WriteLine($"all found: {allFound}");


        //FirstOrDefault მასივში მოძებნის გადაცემული რიცხვის პირველივე მნიშვნელობას თუ არ მოიძებნა დააბრუნებს default - ს

        int[] numbers5 = { 1, 2, 3, 4, 5 };
        FirstOrDefaultOperation firstOrDefaultOperation = new FirstOrDefaultOperation(FisrtOrDefaultInArray.FirstOrDefault);
        int firstFound = firstOrDefaultOperation(numbers5, 7);
        Console.WriteLine($"first found: {firstFound}");


        //LastOrDefault მასივში მოძებნის გადაცემული რიცხვის ბოლო მნიშვნელობას თუ არ მოიძებნა დააბრუნებს default - ს

        int[] numbers6 = { 1, 2, 3, 4, 5, 3, 10, 7 };
        LastOrDefaultOperation lastOrDefaultOperation = new LastOrDefaultOperation(LastOrDefaultInArray.LastOrDefault);
        int lastFound = lastOrDefaultOperation(numbers6, 3);
        Console.WriteLine($"last found: {lastFound}");


        //FindAll მოძებნის და დააბრუნებს მასივის ყველა იმ ელემენტს რომელიც გადაცემულია მოსაძებნა

        int[] numbers7 = { 1, 2, 3, 4, 5, 3, 10, 7 };
        FindAllInArrayByValueOperation findAllInArrayByValueOperation = new FindAllInArrayByValueOperation(FindAllInArrayByValue.FindAllInArrayByValueMethod);
        int[] allFoundIndexes = findAllInArrayByValueOperation(numbers7, new int[] { 3, 10, 15 });
        Console.WriteLine($"all found values: {string.Join(", ", allFoundIndexes)}");



        //FindIndex მასივში მოძებნის გადაცემული რიცხვის პირველივე მნიშვნელობის ინდექსს თუ არ მოიძებნა დააბრუნებს -

        int[] numbers8 = { 1, 2, 3, 4, 5, 3, 10, 7 };
        FindIndexOperation findIndexOperation = new FindIndexOperation(FindIndexInArray.FindIndex);
        int foundIndex = findIndexOperation(numbers8, 17);
        Console.WriteLine($"found index: {foundIndex}");


        //FindLastIndex მასივში მოძებნის გადაცემული რიცხვის ბოლო მნიშვნელობის ინდექსს თუ არ მოიძებნა დააბრუნებს -1

        int[] numbers9 = { 1, 2, 3, 4, 5, 3, 10, 7 };
        FindLastIndexOperation findLastIndexOperation = new FindLastIndexOperation(FindLastIndexInArray.FindLastIndex);
        int foundLastIndex = findLastIndexOperation(numbers9, 3);
        Console.WriteLine($"found last index: {foundLastIndex}");


        //Sum შეკრებს მასივის ყველა ელემენტს.

        int[] numbers10 = { 1, 2, 3, 4, 5, 3, 10, };
        SumInArrayOperation sumInArrayOperation = new SumInArrayOperation(SumInArray.SumOfElements);
        int sum = sumInArrayOperation(numbers10);
        Console.WriteLine($"sum: {sum}");


    }
}


