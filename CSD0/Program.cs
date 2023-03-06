using System;
IEnumerable<int> ArrAy = new[]{ 652, 726, 563, 456, 132, 94, 531, 391, 96, 74, 84, 54, 55, 32, 43 };

int[] array =ArrAy.ToArray();   //轉成一般陣列取長度
int Len = (array.Length)-1;     

toSort n = new toSort();
IEnumerable<int>sort_Array = n.ToSort(ArrAy, 0, Len);//丟進去快排回傳一個排完的IEnumerable
int j = 1;
foreach(int i in sort_Array)
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


