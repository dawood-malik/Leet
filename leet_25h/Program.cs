using System;
namespace kuuu
{
    class Node 
    {
        public int data;
        public Node next;
        public Node(int data=0, Node next=null)
        {
            this.data = data;
            this.next = next;
        }
    }

    class ReversekNode
    {
        public Node ReverseNode(Node lists,int k)
        {
           
            IList<int> reverse= new List<int>();
            while (lists != null)
            {
                reverse.Add(lists.data);
                lists = lists.next;
            }
            for(int i = 0; i < reverse.Count; i+=k)
            {
                int start = i;
                int end = Math.Min(i+k-1,reverse.Count-1);

                if ((end + 1) % k == 0)
                {

                    while (start <= end)
                    {
                        int temp = reverse[start];
                        reverse[start] = reverse[end];
                        reverse[end] = temp;
                        start++;
                        end--;
                    }
                }        
                
            }
            Node dummy=new Node();
            Node carry = dummy;
            foreach(var val in reverse)
            {
                carry.next = new Node(val);
                carry = carry.next;
            }
            return dummy.next;
        }
    }
    class Program 
    { 
        static void Main(string[] args)
        {
            Node head = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5)))));

            ReversekNode reverse =new ReversekNode();
            Node current=reverse.ReverseNode(head, 3);
            while (current != null)
            {
                Console.Write(current.data + "-->");
                current = current.next;
            }
            
        }
    }



}
