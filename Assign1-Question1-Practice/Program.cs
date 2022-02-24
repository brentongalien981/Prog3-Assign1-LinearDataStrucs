public class Program
{
    public static void Main()
    {
        Program.DemoQuestion1A();
        Program.DemoQuestion1B();
        Program.DemoQuestion1C();
    }



    // Differences between array and linked list.
    private static void DemoQuestion1A()
    {
        Console.WriteLine("Question1A");

        /* Difference: Inserting nodes/items is different. */

        // In an array, inserting item to an index, old reference gets replaced.
        // In order to keep all the references, you'd have to manually shift the
        // indeces of the subsequent items.
        int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.Write("Old array ==> ");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }

        myArray[4] = -87;
        Console.WriteLine();
        Console.Write("New array ==> ");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }



        // In a linked list, inserted node gets squeezed in automatically, and no reference is lost.  
        LinkedList<int> myLinkedList = new LinkedList<int>();
        for (int i = 0; i < 10; i++)
        {
            myLinkedList.AddLast(i);
        }

        Console.WriteLine("\n");
        Console.Write("Old linked list ==> ");

        foreach (var item in myLinkedList)
        {
            Console.Write(item + " ");
        }


        LinkedListNode<int> referenceNode = myLinkedList.Find(4);
        myLinkedList.AddBefore(referenceNode, -87);

        Console.WriteLine();
        Console.Write("New linked list ==> ");

        foreach (var item in myLinkedList)
        {
            Console.Write(item + " ");
        }

    }



    // Features of stack and queue.
    private static void DemoQuestion1B()
    {
        Console.WriteLine("\n\nQuestion1B");

        /* Feature 1: Stack items are retrieved FILO. */
        int[] myIntArray = { 0, 1, 2, 3, 4, 5 };
        Stack<int> myStack = new Stack<int>(myIntArray);

        Console.Write("Retrieved stack values ==> ");

        int retrievedVal = -1;

        while (myStack.Count > 0)
        {
            if (myStack.TryPop(out retrievedVal))
            {
                Console.Write(retrievedVal + " ");
            }
        }



        /* Feature 2: Queue items are retrieved FIFO. */
        Queue<int> myQ = new Queue<int>(myIntArray);

        Console.WriteLine();
        Console.Write("Retrieved queue values ==> ");

        while (myQ.Count > 0)
        {
            if (myQ.TryDequeue(out retrievedVal))
            {
                Console.Write(retrievedVal + " ");
            }
        }
    }



    // Demo type constraint.
    private static void DemoQuestion1C()
    {
        Console.WriteLine("\n\nQuestion1C");

        int[] myIntArray = { 1, 2, 3, 4, 5 };
        string[] myStringArray = { "abc", "bcd", "cde" };

        // Call a method that displays stuct types only and not class types.
        Program.DisplayStructArraysOnly(myIntArray);

        // NOTE: This one will give a compile-error when commented out.
        //Program.DisplayStructArraysOnly(myStringArray);

    }



    // Type-constrained method.
    private static void DisplayStructArraysOnly<T>(T[] structArray) where T : struct
    {
        Console.WriteLine("Calling a type-constrained method ==> ...");

        foreach (var item in structArray)
        {
            Console.Write($"{item} ");
        }
    }

}