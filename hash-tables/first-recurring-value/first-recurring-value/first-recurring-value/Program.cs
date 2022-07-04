using custom_hash_table;

int[] LoValues = new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 };
customHashTable LoHashTable = new customHashTable(LoValues.Length);

foreach (int LiX in LoValues)
{
    Console.WriteLine(LoHashTable.set(LiX.ToString(), LiX));
}

//for (int LiX = 0; LiX < LoValues.Length; LiX++)
//{
//    for (int LiY = 0; LiY < LoValues.Length; LiY++)
//    {
//        if (LiFirstRecurrentValue == null)
//        {
//            if (LiX != LiY)
//                if (LoValues[LiX] == LoValues[LiY])
//                {
//                    LiFirstRecurrentValue = LoValues[LiX];
//                    //break;
//                }
//        }
//    }
//    //if (LiFirstRecurrentValue != null)
//    //    break;
//}

//Console.WriteLine("The first recurrent value is: " + LiFirstRecurrentValue.ToString());