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

Console.WriteLine("Enter the number of rotations: ");
int LiTargetNumber = Convert.ToInt32(Console.ReadLine());

for (int LiRotations = 1; LiRotations <= LiTargetNumber; LiRotations++)
{
    int LiPassBy = LiArrayOfValues[LiArrayOfValues.Length - 1];
    for (int LiIndex = (LiInputs - 2); LiIndex >= 0; LiIndex--)
    {
        LiArrayOfValues[LiIndex + 1] = LiArrayOfValues[LiIndex];
    }
    LiArrayOfValues[0] = LiPassBy;
    Console.WriteLine(String.Join(", ", LiArrayOfValues));
}