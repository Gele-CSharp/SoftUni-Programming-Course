using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList testList = new DoublyLinkedList();

            testList.AddFirstElement(1);
            testList.AddFirstElement(2);
            testList.AddFirstElement(3);
            testList.AddLast(0);
            testList.AddLast(1);
            testList.AddLast(2);
            var test = testList.ToArry();

            testList.ForEach(n=> Console.WriteLine(n));

            testList.RemoveLast();
            testList.RemoveLast();
            testList.RemoveLast();
            testList.RemoveLast();
            testList.RemoveLast();
            testList.RemoveLast();
            testList.RemoveLast();

            
        }
    }
}
