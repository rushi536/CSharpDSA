namespace LinkedList
{
    public class TraversalInLL : IProblem
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
            // Create Linked List
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            Console.WriteLine("Traversing Linked List:");
            Traverse(head);
            
           head= InsertHead(head, 0);

          Console.WriteLine("\nAfter Inserting new Node at Head 0:");
            Traverse(head);

            head=InsertTail(head,5);

            Console.WriteLine("\nAfter Inserting new Node at Tail 5:");
            Traverse(head);


            
           head= DeleteNodeAtHead(head);

            Console.WriteLine("\nAfter deleting node :");
            Traverse(head);

            head=DeleteNodeAtTail(head);
            Console.WriteLine("\nAfter deleting Tail Node:");
            Traverse(head);

        }
        // Traversal Method
        public void Traverse(ListNode head)
        {
            ListNode current=head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current=current.next;
            }
        }

        public ListNode InsertHead(ListNode head, int value)
        {
           ListNode newNode= new ListNode(value);
          newNode.next=head;
          head=newNode;
          return head;
        }
        public ListNode InsertTail(ListNode head,int value)
        {
           ListNode newNode=new ListNode(value);
           if(head==null) return newNode;
           ListNode current=head;
            while (current.next != null)
            {
                current=current.next;
            }
           
            current.next=newNode;
            return head;
        }

        public ListNode DeleteNodeAtHead(ListNode head)
        {
            if(head ==null) return null;
            head=head.next;
            return head;

        }

         public ListNode DeleteNodeAtTail(ListNode head)
        {
            if(head ==null || head.next==null) return null;
          ListNode current =head;
            while (current.next.next != null)
            {
                current=current.next;
            }
            current.next=null;
            return head;

        }

    }
}