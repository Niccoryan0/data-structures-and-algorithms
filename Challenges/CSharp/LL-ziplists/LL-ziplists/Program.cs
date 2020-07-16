using System;
using LinkedListLibrary;
namespace LL_ziplists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Zip two linked lists together
        /// </summary>
        /// <param name="listA">First list</param>
        /// <param name="listB">Second list</param>
        /// <returns>New Linked List with alternating values from supplied lists</returns>
        public static LinkedList Zip(LinkedList listA, LinkedList listB)
        {
            LinkedList result = new LinkedList();
            result.Current = result.Head;
            Node CurrentA = listA.Head;
            Node CurrentB = listB.Head;

            while (CurrentA != null || CurrentB != null)
            {
                if (CurrentA != null && CurrentB != null)
                {
                    result.Insert(CurrentB.Value);
                    result.Insert(CurrentA.Value);
                    CurrentB = CurrentB.Next;
                    CurrentA = CurrentA.Next;
                }
                else if (CurrentA != null && CurrentB == null)
                {
                    result.Insert(CurrentA.Value);
                    CurrentA = CurrentA.Next;
                }
                else if (CurrentA == null && CurrentB != null)
                {
                    result.Insert(CurrentB.Value);
                    CurrentB = CurrentB.Next;
                }
                else
                {
                    CurrentA = CurrentA.Next;
                    CurrentB = CurrentB.Next;
                }
            }
            return result;
        }
    }
}
