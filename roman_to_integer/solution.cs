/*

Use a dictionary to store the key value paris of Roman Numberals to Integers.
We will loop through the string going backwards, as we need to account for the single digits and upwards.
We need to account for when we have IV, LC, etc. Lower numbers. We will need to subtract from the integer the lower-predecessor.


*/

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romans = new Dictionary<char, int>() {{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500 }, {'M', 1000}};
        
        int ret = 0;
        for(int i = s.Length - 1; i >= 0; i--) {
            if (i < (s.Length - 1) && romans[s[i]] < romans[s[i + 1]]){
                ret -= map[s[i]];
            } else {
                ret += romans[s[i]];
            }
        }
        
        return ret;
    }
}