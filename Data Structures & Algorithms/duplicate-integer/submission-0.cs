public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        bool hasDuplicateValue = false;
        int offset = 0;
        while (!hasDuplicateValue && offset < nums.Length)
        {
            int value = nums[offset];
            for (int i = 0; i < nums.Length; i++)
            {
                if (offset != i) hasDuplicateValue = nums[i] == value;
                if (hasDuplicateValue) break;
            }
            offset++;
        }
        return hasDuplicateValue;
    }
}