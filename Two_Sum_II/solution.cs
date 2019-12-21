// using two pointers and while loop to find the two numbers that add up to target in numbers array

public class Solution {
    public int[] TwoSum(int[] numbers, int target){
        HashSet<int> set = new HashSet<int>();
        int right = numbers.Length - 1;
        int left = 0;

        while(left < right){
            if(numbers[left] + numbers[right] == target){
                break;
            }
            if(numbers[left] + numbers[right] < target){
                left++;
            } else {
                right--;
            }
        }
        int[] ret = new int[] {left + 1, right + 1};
        return ret;
    }
}