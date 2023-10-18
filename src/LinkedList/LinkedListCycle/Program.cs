internal class Program
{
    static void Main(string[] args)
    {
        ListNode listNode            = new ListNode() { val = 3 };
        listNode.next                = new ListNode() { val = 2 };
        listNode.next.next           = new ListNode() { val = 0 };
        listNode.next.next.next      = new ListNode() { val = -4 };
        listNode.next.next.next.next = listNode.next;

        Console.WriteLine(new Solution().HasCycle(listNode));
        Console.ReadLine();
    }
}

public class Solution
{
    public bool HasCycleWithHashSet(ListNode head)
    {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        ListNode ptr = head;

        while (ptr != null)
        {
            if (!visited.Add(ptr))
            {
                return true;
            }

            ptr = ptr.next;
        }

        return false;
    }

    /// <summary>
    /// O(1) space
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool HasCycle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (slow.Equals(fast))
            {
                return true;
            }
        }

        return false;
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