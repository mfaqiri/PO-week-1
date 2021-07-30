using System;

namespace ArraySolver
{
    public class ContiguousArray
    {

        public static void Main()
        {
            Console.WriteLine("Hello");
        }


        public int[] ContiguousSum(ListNode head, int sum)
        {

            ListNode cur = head;

            int[] result = new int[3];

            do{
                if(cur.val + cur.next.val + cur.next.next.val == sum)
                {
                    result[0] = cur.val;
                    result[1] = cur.next.val;
                    result[2] = cur.next.next.val;
                    break;
                }
                cur = cur.next;
            }while(cur != head);

            return result;
        }

        public ListNode CreateList(int[] input)
        {
            ListNode head = new ListNode(input[0]); 
            ListNode cur = head;
            for(int i = 1; i < input.Length; i++)
            {
                cur.next = new ListNode(input[i]);
                cur = cur.next;
            }
            cur.next = head;

            return head;
        }

        public class ListNode
        {
            public int val{get;set;}
            public ListNode next{get;set;}



            public ListNode(int nodeVal)
            {
                val = nodeVal;
            }
        }
    }
}
