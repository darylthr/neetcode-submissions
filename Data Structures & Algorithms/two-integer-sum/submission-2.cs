public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> set = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if(set.ContainsKey(complement)) {
                return new int[] { set[complement], i };
            }

            set[nums[i]] = i;
        }

        return new int[] {};
    }
}
