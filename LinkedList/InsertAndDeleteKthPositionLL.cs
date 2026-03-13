using System.Globalization;

namespace LinkedList
{
    public class InsertAndDeleteKthPositionLL : IProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int value)
            {
                val=value;
                next=null;
            }
        }
        public void Run()
        {
            int[] values={1,2,3,4};
            ListNode head=new ListNode(values[0]);
            ListNode current=head;
            for(int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current=current.next;
            }
           head= InsertAtKPosition(head,7,2);
        }
        public ListNode InsertAtKPosition(ListNode head,int value,int k)
        {
            if (k == 0)
            {
                ListNode newNode=new ListNode(value);
                newNode.next=head;
                return newNode;
            }
            ListNode current= head;
            for(int i = 0; i < k - 1; i++)
            {
                if (current == null)
                {
                    return head;
                }
                current=current.next;
            }
            ListNode node=new ListNode(value);
            node.next=current.next;
            current.next=node;
            return head;
        }
    }
}