using System;
using System.Linq.Expressions;
namespace LeetCode.Problems.Medium;

/// <summary>
///   https://leetcode.com/problems/add-two-numbers/
///   2. Add Two Numbers
///   Level : Medium
/// </summary>
public sealed class AddTwoNumbers2 : IProblem
{
    public void Execute()
    {
        var root1 = new ListNode(6, new ListNode(9, new ListNode(9)));
        var root2 = new ListNode(9);
        // 5001
        var node = AddTwoNumbers(root1, root2);
        Print(node);
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbers(l1, l2, false);
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool plusOne)
    {
        if (l1 == null && l2 == null) {
            if (plusOne) {
                return new ListNode(1);
            }
            return null;
        }

        var po = false;
        var val = (l1?.val ?? 0) + (l2?.val??0) + (plusOne ? 1 : 0);
        if (val > 9) {
            po = true;
        }

        return new ListNode(po == true ? val - 10 : val, AddTwoNumbers(l1?.next, l2?.next, po));
    }

    private void Print(ListNode root)
    {
        if (root == null) {
            return;
        }

        Console.WriteLine(root.val);
        Print(root.next);
    }
}

public sealed class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}