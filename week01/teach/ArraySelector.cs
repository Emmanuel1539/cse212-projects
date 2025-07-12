public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> result = new();
        int firstListValue = 0, secondListValue = 0;


        foreach (int sel in select)
        {
            if (sel == 1)
            {
                result.Add(list1[firstListValue]);
                firstListValue++;
            }
            else if (sel == 2)
            {
                result.Add(list2[secondListValue]);
                secondListValue++;
            }
            else
            {
                throw new ArgumentException("Selector must contain only 1 or 2.");
            }
        }
        return result.ToArray();
    }
}