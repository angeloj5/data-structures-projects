using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customLinkedList
{
    public class LinkedList
    {
        private customLinkedList.Node MoHeadNode = null;
        public LinkedList()
        {

        }
        public void AddToEnd(object PoValue)
        {
            if (MoHeadNode == null)
                MoHeadNode = new Node(PoValue);
            else
                MoHeadNode.AddToEnd(PoValue);
        }
        public void Print()
        {
            if (MoHeadNode != null)
                MoHeadNode.Print();
        }
        public void AddAtBeginning(object PoValue)
        {
            if (MoHeadNode == null)
                MoHeadNode = new Node(PoValue);
            else
            {
                Node LoTempNode = new Node(PoValue);
                LoTempNode.next = MoHeadNode;
                MoHeadNode = LoTempNode;
            }
        }
        public void Remove(int PiIndex)
        {
            //Node LoTempNode = null;
            //int LiCounter = 2;
            //if (PiIndex == 1)
            //{
            //    LoTempNode = MoHeadNode.next;
            //    MoHeadNode = LoTempNode;
            //    LoTempNode = null;
            //}
            //else if (PiIndex > 1)
            //{
            //    if(LiCounter==PiIndex-1)

            //}


        }
        public void Remove(Node PoNode)
        {
            if (MoHeadNode == null)
                return;

            if (MoHeadNode.value == PoNode.value)
                MoHeadNode = MoHeadNode.next;
            else
                this.Remove(MoHeadNode.next);
        }

        //void printLinkedList(customLinkedList.Node PoStartingNode)
        //{
        //    customLinkedList.Node LoCurrentNode = PoStartingNode;
        //    while (LoCurrentNode != null)
        //    {
        //        Console.Write(LoCurrentNode.value + " -> ");
        //        LoCurrentNode = LoCurrentNode.next;
        //    }
        //    if (LoCurrentNode == null)
        //        Console.WriteLine("[end]");
        //}
        //void printLinkedListRecursively(customLinkedList.Node PoStartingNode)
        //{
        //    if (PoStartingNode != null)
        //    {
        //        Console.Write(PoStartingNode.value + " -> ");
        //        printLinkedListRecursively(PoStartingNode.next);
        //    }
        //    else
        //        Console.WriteLine("[end]");
        //}
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
        //customLinkedList.Node[] ToArray(customLinkedList.Node PoStartingNode)
        //{
        //    customLinkedList.Node[] LoArray = { };
        //    customLinkedList.Node LoCurrentNode = PoStartingNode;
        //    int LiCounter = 0;
        //    while (LoCurrentNode != null)
        //    {
        //        LiCounter++;
        //        Array.Resize(ref LoArray, LiCounter);
        //        LoArray[LiCounter - 1] = LoCurrentNode;
        //        LoCurrentNode = LoCurrentNode.next;
        //    }

        //    return LoArray;
        //}
        //long SumNodesValues(customLinkedList.Node PoStartingNode)
        //{
        //    long LlGrandTotal = 0;
        //    while (PoStartingNode != null)
        //    {
        //        if (PoStartingNode.value is int || PoStartingNode.value is long)
        //            LlGrandTotal += Convert.ToInt64(PoStartingNode.value);
        //        PoStartingNode = PoStartingNode.next;
        //    }
        //    return LlGrandTotal;
        //}
        //public void AddAtBegining(object PoValue)
        //{
        //    //customLinkedList.Node LoNewNode = new Node(PoValue);
        //    //LoNewNode.order = 1;
        //    //foreach (customLinkedList.Node LoNodeItem in MoNodes)
        //    //{
        //    //    if (LoNodeItem.order == 1)
        //    //        LoNewNode.next = LoNodeItem;

        //    //    LoNodeItem.order++;
        //    //}

        //    //Array.Resize(ref MoNodes, MoNodes.Length + 1);
        //    //MoNodes[MoNodes.Length - 1] = LoNewNode;
        //}
        //public void AddAtEnd(object PoValue)
        //{
        //    //if()
        //    //customLinkedList.Node LoNewNode = new Node(PoValue);
        //    //foreach (customLinkedList.Node LoNodeItem in MoNodes)
        //    //{
        //    //    if (LoNodeItem.order == MoNodes.Length)
        //    //        LoNodeItem.next = LoNewNode;
        //    //}

        //    //Array.Resize(ref MoNodes, MoNodes.Length + 1);
        //    //LoNewNode.order = MoNodes.Length;
        //    //MoNodes[MoNodes.Length - 1] = LoNewNode;
        //}
        //public void AddAtPosition(object PoValue, int PiPosition)
        //{
        //    //customLinkedList.Node LoNewNode = new Node(PoValue);
        //    //LoNewNode.order = PiPosition;
        //    //foreach (customLinkedList.Node LoNodeItem in MoNodes)
        //    //{
        //    //    if (LoNodeItem.order == (PiPosition-1))
        //    //        LoNodeItem.next = LoNewNode;

        //    //    if (LoNodeItem.order >= PiPosition)
        //    //    {
        //    //        if (LoNodeItem.order == PiPosition)
        //    //            LoNewNode.next = LoNodeItem;

        //    //        LoNodeItem.order++;
        //    //    }
        //    //}

        //    //Array.Resize(ref MoNodes, MoNodes.Length + 1);
        //    //MoNodes[MoNodes.Length - 1] = LoNewNode;
        //}
    }
}