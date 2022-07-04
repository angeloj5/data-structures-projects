//Merging two arrays
Console.WriteLine("Merging two sorted arrays. 1st way.");
int[] LiSorted1 = { 0, 3, 4, 31 };
int[] LiSorted2 = { 4, 6, 30 };

int[] LiSorted3 = LiSorted1.Concat(LiSorted2).OrderBy(x => x).ToArray();

Console.Write(String.Join(", ", LiSorted3));

Console.WriteLine();
Console.WriteLine("Merging two sorted arrays. 2nd way.");

int[] LiSortedFinal = new int[LiSorted1.Length + LiSorted2.Length];

int LiCount1 = LiSorted1.Length, LiCount2 = LiSorted2.Length;

int LiA = 0, LiB = 0; //Index for the sorted arrays.
int LiIndex = 0; //Index for the final sorted array.

while (LiA < LiCount1 && LiB < LiCount2)
{
    if (LiSorted1[LiA] <= LiSorted2[LiB])
    {
        LiSortedFinal[LiIndex++] = LiSorted1[LiA++];
    }
    else
    {
        LiSortedFinal[LiIndex++] = LiSorted2[LiB++];
    }
}

if (LiA < LiCount1)
{
    LiSortedFinal[LiSortedFinal.Length - 1] = LiSorted1[LiCount1 - 1];
}
else
{
    LiSortedFinal[LiSortedFinal.Length - 1] = LiSorted2[LiCount2 - 1];
}

Console.Write(String.Join(", ", LiSortedFinal));