using System;
using LinkedListLibrary;
namespace LL_ziplists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Zip two linked lists together
        /// </summary>
        /// <param name="listA">listA list</param>
        /// <param name="listB">listB list</param>
        /// <returns>New Linked List with alternating values from supplied lists</returns>
        public static Node Zip(LinkedList listA, LinkedList listB)
        {
            LinkedList result = new LinkedList();
            Node CurrentA = listA.Head;
            Node CurrentB = listB.Head;
            result.Current = result.Head;
            if (CurrentA == null)
            {
                return listB.Head;
            } else if (CurrentB == null)
            {
                return listA.Head;
            }
            while (CurrentA != null || CurrentB != null)
            {
                if (CurrentA != null && CurrentB != null)
                {
                    result.Append(CurrentA.Value);
                    result.Append(CurrentB.Value);
                    CurrentB = CurrentB.Next;
                    CurrentA = CurrentA.Next;
                }
                else if (CurrentA != null && CurrentB == null)
                {
                    result.Append(CurrentA.Value);
                    CurrentA = CurrentA.Next;
                }
                else if (CurrentA == null && CurrentB != null)
                {
                    result.Append(CurrentB.Value);
                    CurrentB = CurrentB.Next;
                }
                else
                {
                    CurrentA = CurrentA.Next;
                    CurrentB = CurrentB.Next;
                }
            }
            return result.Head;
        }
    }
}
