Console.WriteLine("Enter the number of values you will enter: ");
string? LsNumberOfInputs = Console.ReadLine();

int LiInputs = Convert.ToInt32(LsNumberOfInputs);
int[] LiArrayOfValues = new int[LiInputs];


for (int i = 0; i < LiInputs; i++)
{
    Console.WriteLine("Enter value number: " + i.ToString());
    string? LsValue = Console.ReadLine();
    LiArrayOfValues.SetValue(Convert.ToInt32(LsValue), i);
}

Console.WriteLine("Enter the target number: ");
int LiTargetNumber = Convert.ToInt32(Console.ReadLine());


for (int LiX = 0; LiX < LiArrayOfValues.Length; LiX++)
{
    for (int LiY = LiX + 1; LiY < LiArrayOfValues.Length; LiY++)
    {
        if (LiArrayOfValues[LiX] + LiArrayOfValues[LiY] == LiTargetNumber)
        {
            Console.WriteLine("The result is [" + LiX + ", " + LiY + "]");
        }
    }
}