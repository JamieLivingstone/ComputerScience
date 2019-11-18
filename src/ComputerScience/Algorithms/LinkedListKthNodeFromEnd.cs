using System;
using ComputerScience.DataStructures;

namespace ComputerScience.Algorithms
{
    public class LinkedListKthNodeFromEnd
    {
        public static int Get(Node root, int k)
        {
            Node a = root;
            Node b = root;
            
            // Set pointers K apart
            for (var i = 0; i < k - 1; i++)
            {
                b = b.Next ?? throw new ArgumentOutOfRangeException();
            }

            // Traverse and increment pointers
            while (b.Next != null)
            {
                b = b.Next;
                a = a.Next;
            }

            return a.Value;
        }
    }
}