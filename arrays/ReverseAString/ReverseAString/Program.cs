Console.WriteLine("Please, enter a string");
string LsInput = Console.ReadLine().ToString();

if (LsInput == null)
    throw new Exception("You have to enter a text.");

//Reversing the entered string
char[] LsChars = LsInput.ToArray();
string LsReversedString = string.Empty;
for (int LiX = LsChars.Length - 1; LiX > -1; LiX--)
{
    LsReversedString += LsChars[LiX];
}
Console.WriteLine("Reversed string: " + LsReversedString);