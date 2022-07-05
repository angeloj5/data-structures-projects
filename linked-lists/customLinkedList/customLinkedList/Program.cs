void printLinkedList(customLinkedList.Node PoStartingNode)
{
    customLinkedList.Node LoCurrentNode = PoStartingNode;

    while (LoCurrentNode != null)
    {
        Console.Write(LoCurrentNode.value + " -> ");
        LoCurrentNode = LoCurrentNode.next;
    }
    if (LoCurrentNode == null)
        Console.WriteLine("[end]");
}

void printLinkedListRecursively(customLinkedList.Node PoStartingNode)
{
    if (PoStartingNode != null)
    {
        Console.Write(PoStartingNode.value + " -> ");
        printLinkedListRecursively(PoStartingNode.next);
    }
    else
        Console.WriteLine("[end]");
}

//object[] ToArray(customLinkedList.Node PoStartingNode)
//{
//    customLinkedList.Node LoCurrentNode = PoStartingNode;
//    int LiCounter = 1;
//    while (LoCurrentNode.next != null)
//    {
//        LoCurrentNode = LoCurrentNode.next;
//        LiCounter++;
//    }

//    object[] LoArray= new object[LiCounter];
//    LiCounter = 0;
//    LoCurrentNode = PoStartingNode;

//    while (LoCurrentNode != null)
//    {
//        LoArray[LiCounter] = LoCurrentNode;
//        LoCurrentNode = LoCurrentNode.next;
//        LiCounter++;
//    }

//    return LoArray;
//}

customLinkedList.Node[] ToArray(customLinkedList.Node PoStartingNode)
{
    customLinkedList.Node[] LoArray = { };
    customLinkedList.Node LoCurrentNode = PoStartingNode;
    int LiCounter = 0;
    while (LoCurrentNode != null)
    {
        LiCounter++;
        Array.Resize(ref LoArray, LiCounter);
        LoArray[LiCounter - 1] = LoCurrentNode;
        LoCurrentNode = LoCurrentNode.next;
    }

    return LoArray;
}

long SumNodesValues(customLinkedList.Node PoStartingNode)
{
    long LlGrandTotal = 0;
    while (PoStartingNode != null)
    {
        if (PoStartingNode.value is int || PoStartingNode.value is long)
            LlGrandTotal += Convert.ToInt64(PoStartingNode.value);
        PoStartingNode = PoStartingNode.next;
    }
    return LlGrandTotal;
}

//creating the nodes
customLinkedList.Node LoEspanol = new customLinkedList.Node("Hola Mundo!");
customLinkedList.Node LoEnglish = new customLinkedList.Node("Hello World!");
customLinkedList.Node LoFrancais = new customLinkedList.Node("Bonjour Monde!");
customLinkedList.Node LoNihongo = new customLinkedList.Node("Konichiha Sekai!");
customLinkedList.Node LoDiez = new customLinkedList.Node(10);
customLinkedList.Node LoVeinte = new customLinkedList.Node(20);
customLinkedList.Node LoTreinta = new customLinkedList.Node(30);

//Creating the relation in the linked list
LoEspanol.next = LoEnglish;
LoEnglish.next = LoFrancais;
LoFrancais.next = LoNihongo;
LoNihongo.next = LoDiez;
LoDiez.next = LoVeinte;
LoVeinte.next = LoTreinta;

printLinkedList(LoEspanol);
printLinkedListRecursively(LoEspanol);
object[] LoResult = ToArray(LoEspanol);

foreach (customLinkedList.Node LoResultItem in LoResult)
    Console.Write(LoResultItem.value.ToString() + " -> ");
Console.WriteLine("[end]");

//Console.WriteLine("The Grand total is: " + SumNodesValues(LoEspanol));
//customLinkedList.LinkedList LoLinkedListTest = new customLinkedList.LinkedList();
//LoLinkedListTest.AddAtBegining("Hola mundo x2!");
//LoLinkedListTest.AddAtBegining("Hola mundo x3!");
//LoLinkedListTest.AddAtEnd("Hola mundo x4!");
//LoLinkedListTest.AddAtPosition("Hola at order...", 2);

customLinkedList.Node LoNewNode = new customLinkedList.Node("New Node");
LoNewNode.AddToEnd("New last Node");
LoNewNode.Print();

customLinkedList.LinkedList LoLinkedList = new customLinkedList.LinkedList();
LoLinkedList.AddToEnd("hl");
LoLinkedList.AddToEnd("he");
LoLinkedList.AddToEnd("ew");
LoLinkedList.AddAtBeginning("NewHeadNode");
LoLinkedList.AddAtBeginning("NewHeadNode2");
LoLinkedList.Print();
LoLinkedList.Remove(new customLinkedList.Node("NewHeadNode"));
LoLinkedList.Print();