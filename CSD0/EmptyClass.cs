public class toSort
{
    public IEnumerable<int> ToSort(IEnumerable<int> nu,int begin,int end)
    {
        int[]num = nu.ToArray();
        QuickSort(num, begin, end);
        IEnumerable<int> sort_Array = num;
        int j = 1;
        foreach (int i in sort_Array)
        {
            if (i < 100)
            {
                Console.Write($"0{i}");
            }
            else
            {
                Console.Write($"{i}");
            }
            if (j % 2 == 1)
            {
                Console.Write("\t");
            }
            else
            {
                Console.Write("\n");
            }
            j++;
        }

        return sort_Array;
    }
    
    private static void QuickSort(int[] num, int begin, int end)
    {
        if (begin >= end) return;
        int pivotIndex = QuickSort_Once(num, begin, end);

        QuickSort(num, begin, pivotIndex - 1); //往左排列
        QuickSort(num, pivotIndex + 1, end);    //往右排列
    }
    private static int QuickSort_Once(int[] num, int begin, int end)
    {
        int pivot = num[begin];
        int i = begin, j = end;
        while (i < j)
        {
            while (num[j] >= pivot && i < j)
            {
                j--;
            }
            num[i] = num[j];
            while (num[i] <= pivot && i < j)
            {
                i++;
            }
            num[j] = num[i];
        }
        num[i] = pivot;
        return i;
    }
}