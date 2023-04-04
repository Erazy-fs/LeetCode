// Beginner's Guide
// 876. Middle of the Linked List
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        List<ListNode> result = new();
        while (head.next != null)
        {
            result.Add(head);
            head = head.next;
        }
        result.Add(head);

        return result[result.Count / 2];
    }
}