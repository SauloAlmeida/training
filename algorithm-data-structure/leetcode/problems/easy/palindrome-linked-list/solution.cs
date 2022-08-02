/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
  public bool IsPalindrome(ListNode head)
  {
    List<int> values = new();

    bool getValues = true;

    do
    {
      values.Add(head.val);

      if (head.next is null) getValues = false;

      head = head.next;

    } while (getValues);


    string numbers = string.Join(string.Empty, values);

    var numberArray = numbers.ToCharArray();

    Array.Reverse(numberArray);

    string reverseString = new(numberArray);

    return numbers == reverseString;
  }
}

// Runtime: 293 ms, faster than 77.32% of C# online submissions for Palindrome Linked List.
// Memory Usage: 58.1 MB, less than 11.18% of C# online submissions for Palindrome Linked List.