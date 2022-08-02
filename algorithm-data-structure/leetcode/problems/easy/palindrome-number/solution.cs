public class Solution
{
  public bool IsPalindrome(int x)
  {
    if (x < 0) return false;

    string numberString = x.ToString();
    var numberArray = numberString.ToCharArray();
    Array.Reverse(numberArray);
    string reverseString = new string(numberArray);

    return numberString == reverseString;
  }
}

// Runtime: 48 ms, faster than 91.69% of C# online submissions for Palindrome Number.
// Memory Usage: 28.9 MB, less than 43.71% of C# online submissions for Palindrome Number.