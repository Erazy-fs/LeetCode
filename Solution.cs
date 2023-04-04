// Beginner's Guide
// 876. Middle of the Linked List
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        byte iter = 1;
        ListNode result = head;
        while (head.next != null)
        {
            if (iter % 2 != 0)
            {
                result = result.next;
            }
            head = head.next;
            iter++;
        }

        return result;
    }
}