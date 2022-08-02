public class Solution
{
  public int LengthOfLastWord(string phrase)
  {
    string[] words = phrase.Split(" ");

    var wordsWithCaracteres = words.Where(w => string.IsNullOrEmpty(w) is false)
                                   .ToArray();

    string lastWord = wordsWithCaracteres[^1];

    return lastWord.Length;
  }
}

// Runtime: 69 ms, faster than 84.18% of C# online submissions for Length of Last Word.
// Memory Usage: 36.4 MB, less than 18.54% of C# online submissions for Length of Last Word.