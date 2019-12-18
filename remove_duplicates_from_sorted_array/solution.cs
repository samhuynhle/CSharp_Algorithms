public class Solution {
    public int RemoveDuplicates(int[] nums){
        int n = nums.Length;
        if(n == 0) return 0;

        var resultIndex = 0; // this is our return value
        for(int i = 1; i < n; i ++){ // we will loop through the array of nums
            if(nums[i-1] == nums[i]) continue; // if we have matching integers, we move on with the loop

            resultIndex += 1; // if we have another interger, we increment our resultIndex by 1
            nums[resultIndex] = nums[i];
        }

        return resultIndex + 1;
    }
}