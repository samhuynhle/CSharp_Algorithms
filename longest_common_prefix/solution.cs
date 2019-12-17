public class Solution{
    public string LongestCommonPrefix(string[] strs){
        if(strs == null || strs.Length < 1){ // if we have no strings or the array of strings is empty
            return ""; // we return none
        }

        int i = 0; // establish i for our loops
        string prefix = strs[0]; // we assume the prefix will be the first string in the array

        while(++i < strs.Length && prefix.Length > 0){ // loop through the array of strings, also if our prefix length reaches 0, break
            while(strs[i].IndexOf(prefix) != 0){ // we will search if the prefix is in the current string, if not, then we shorten the prefix until found(i.e, the substring is in the string or the substring is empty)
                prefix = prefix.Substring(0, prefix.Length - 1); // 
            }
        }

        return prefix;
    }
}