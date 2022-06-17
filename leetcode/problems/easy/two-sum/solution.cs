public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    int[] resultIndexes = new int[2];
    bool gotIndexes = false;

    for (int indexNumber = 0; indexNumber < nums.Length - 1; indexNumber++)
    {
      if (gotIndexes) break;

      int number = nums[indexNumber];

      for (int indexToSum = indexNumber + 1; indexToSum < nums.Length; indexToSum++)
      {
        int secondNumber = nums[indexToSum];

        if (number + secondNumber == target)
        {
          resultIndexes[0] = indexNumber;
          resultIndexes[1] = indexToSum;

          gotIndexes = true;
          break;
        }
      }
    }

    return resultIndexes;
  }
}
// Result
// Runtime: 311 ms, faster than 12.51% of C# online submissions for Two Sum.
// Memory Usage: 42.8 MB, less than 74.06% of C# online submissions for Two Sum.