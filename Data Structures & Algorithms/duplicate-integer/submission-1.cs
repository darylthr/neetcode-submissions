public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        int l = 0, r = n - 1;

        while (l < n && r >= l && n > 1) {
            if(r == l) {
                l++;
                r = n - 1;
            }
            
            if (l != r && nums[l] == nums[r]) {
                return true;
            }

            r--;
        }

        return false;
    }
}