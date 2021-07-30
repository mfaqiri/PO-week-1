using System;

namespace LLStack
{
    public class LLStack
    {

        private ListNode head = null;

        public void push(int val)
        {
            if(head == null)
                head = new ListNode(val);

            else
            {
                ListNode cur = head;
                while(cur.next != null)
                {
                    cur = cur.next;
                }
                cur.next = new ListNode(val);
            }
        }

        public int pop()
        {
            if(head == null)
            {
                return -1;
            }
            else if(head.next == null){
                return head.val;
                head = null;
            }else{
                ListNode cur = head;
                while(cur.next.next != null){
                    cur = cur.next;
                }
                int result = cur.next.val;
                cur.next = null;
                return result;
            }
        }

    
        private class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int input)
                {
                    val = input;
                }
            }

    }

    
}
