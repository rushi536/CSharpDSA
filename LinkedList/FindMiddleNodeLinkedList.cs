namespace LinkedList
{
    public class FindMiddleNodeLinkedList : IProblem
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
            int[] values = { 10, 20, 30, 40, 50 };

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine($"slow={slow.val}, fast={(fast != null ? fast.val : -1)}");
        }
    }
}