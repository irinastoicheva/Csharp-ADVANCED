namespace WorkshopCreateLinkedList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            DoublyLinkedList linkedList = new DoublyLinkedList();
            linkedList.AddHead(1);
            linkedList.AddHead(2);
            linkedList.AddHead(3);
            linkedList.AddHead(4);
            linkedList.AddHead(5);

            
            linkedList.ForEach(n => Console.WriteLine(n));
        }
    }
}
