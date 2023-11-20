internal class Program
{
    static void Main(string[] args)
    {
        ListNode listNode1            = new ListNode() { val = 1 };
        listNode1.next                = new ListNode() { val = 2 };
        listNode1.next.next           = new ListNode() { val = 3 };
        listNode1.next.next.next      = new ListNode() { val = 4 };
        listNode1.next.next.next.next = new ListNode() { val = 5 };

        var reverseListNode = new Solution().RemoveNthFromEnd(listNode1, 3);

        Console.ReadLine();
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummyNode = new ListNode(0 ,head);

        var leftPointer = dummyNode;
        var rightPointer = dummyNode.next;

        while (n != 0)
        {
            rightPointer = rightPointer.next;
            n--;
        }

        while (rightPointer != null)
        {
            rightPointer = rightPointer.next;
            leftPointer  = leftPointer.next;
        }

        leftPointer.next = leftPointer.next.next;

        return dummyNode.next;
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