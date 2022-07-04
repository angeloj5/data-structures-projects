using custom_hash_table;

//HashTable LoHashTable = new HashTable(2);
//LoHashTable.set("HolaMundo", 1);
//LoHashTable.set("Hola Mundo", 2);
//LoHashTable.set("Hola mundo", 100);

//object LoResult = LoHashTable.get("Hola mundo");

//Console.WriteLine(LoHashTable);

customHashTable LoHashTable = new customHashTable(2);
LoHashTable.set("Hola1", "Mundo");
LoHashTable.set("Hola", "!");
LoHashTable.set("hello", "world");
Console.WriteLine("The value of the selected key is: " + LoHashTable.get("Hola"));
string[] LsKeys = LoHashTable.keys();
Console.WriteLine(LsKeys.Length);