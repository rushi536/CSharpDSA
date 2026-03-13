namespace LinkedList
{
    public class DetectCycleLinkedList : IProblem
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
            int[] values = { 1, 2, 3, 4, 5 };
            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            ListNode cycleNode=null;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
                if (values[i] == 2)
                {
                    cycleNode=current;
                }
               
            }
             current.next=cycleNode;
           head= HasCycle(head);
            Console.Write(head.val);
        }
        public ListNode HasCycle(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode slow = head;
            ListNode fast = head;
            //Pahse 1: Detect cycle
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    //Find the start
                  slow=head;
                    while (slow != fast)
                    {
                        slow=slow.next;
                        fast=fast.next;
                    }
                    return slow;
                }

            }
            return null;
        }
    }
}