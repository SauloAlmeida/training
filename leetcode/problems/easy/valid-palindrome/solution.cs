public class Solution
{
  public bool IsPalindrome(string phrase)
  {
    string regexGetAlphanumeric = @"[^a-zA-Z0-9]+";

    var phraseDistill = System.Text.RegularExpressions.Regex.Replace(phrase.ToLower(), regexGetAlphanumeric, "");

    var phraseCharArray = phraseDistill.ToCharArray();

    Array.Reverse(phraseCharArray);

    var reversePhrase = new string(phraseCharArray);

    return phraseDistill == reversePhrase;
  }
}

// Runtime: 106 ms, faster than 61.44% of C# online submissions for Valid Palindrome.
// Memory Usage: 42.9 MB, less than 7.85% of C# online submissions for Valid Palindrome.