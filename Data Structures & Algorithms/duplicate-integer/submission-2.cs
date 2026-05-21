public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0) return false;

        List<int> l = new List<int>();

        for(int i = 0; i < nums.Length; i++) {
            if(l.Contains(nums[i])) return true;
            else l.Add(nums[i]);
        }

        return false;
    }
}