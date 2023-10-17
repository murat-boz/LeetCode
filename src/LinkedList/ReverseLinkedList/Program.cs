
internal class Program
{
    static void Main(string[] args)
    {
        ListNode listNode  = new ListNode() { val = 1 };
        listNode.next      = new ListNode() { val = 2 };
        listNode.next.next = new ListNode() { val = 3 };
        listNode.next.next.next = new ListNode() { val = 4 };

        var reverseListNode = new Solution().ReverseList(listNode);

        Console.ReadLine();
    }
}

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        return prev;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}