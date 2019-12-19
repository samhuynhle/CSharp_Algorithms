public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> hashmap = new Dictionary<int, int>();
        List<int> ret = new List<int>();

        for(int i = 0; i < nums.Length; i++){
            if(hashmap.ContainsKey(target - nums[i])){
                ret.Add(hashmap[target - nums[i]]);
                ret.Add(i);
            } else {
                if(!hashmap.ContainsKey(nums[i])){
                    hashmap.Add(nums[i], i);
                }
            }
        }
        return ret.ToArray();
    }
}