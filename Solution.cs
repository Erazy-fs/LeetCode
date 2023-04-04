// Beginner's Guide
// 876. Middle of the Linked List
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        byte count = 0;
        ListNode result = head;
        while (head.next != null)
        {
            head = head.next;
            count++;
        }

        for (byte i = 0; i < (count + 1) / 2; i++)
        {
            result = result.next;
        }

        return result;
    }
}