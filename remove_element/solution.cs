public class Solution {
    public int RemoveElement(int[] nums, int val){
        int index = -1;
        foreach (int num in nums){
            if(num != val){
                nums[++index] = num;
            }
        }
        return index + 1;
    }
}
