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

            foreach (var item in linkedList.ToArrayLinkedList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
