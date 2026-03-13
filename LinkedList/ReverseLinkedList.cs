namespace LinkedList
{
    public class ReverseLinkedList : IProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int value)
            {
                val = value;
                next = null;
            }
        }
        public void Run()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            Console.WriteLine("Traversing Linked List:");
            Traverse(head);
            head =ReverseLL(head);

            Console.WriteLine("After Reversing Linked List:");
            Traverse(head);
        }
        public void Traverse(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }
        public ListNode ReverseLL(ListNode head)
        {
            if (head == null) return head;
            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            return prev;
        }
    }
}