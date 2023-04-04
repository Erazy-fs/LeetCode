// Beginner's Guide
// 876. Middle of the Linked List
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode result = head;
        while (head != null && head.next != null)
        {
            result = result.next;
            head = head.next.next;
        }

        return result;
    }
}