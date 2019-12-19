// Using two pointers method
public class Solution{
    public int StrStr(string haystack, string needle){
        // base case: if the needle is 0, return 0
        if(needle.Length == 0){
            return 0;
        }
        
        // base case: if the needle length is longer than haystack, then it's not a substring of haystack
        if(needle.Length > haystack.Length){
            return -1;
        }

        // initialize the first pointer
        int needleIndex = 0;

        // looping through, we have our second pointer
        // we are expecting to return a the index the needle starts at, food and ood, ood starts at 1
        for(int i = 0; i < haystack.Length; i++){
            // if the char at the current position is equal to the needle at needleIndex, then we increment needleIndex
            if(haystack[i] == needle[needleIndex]){
                needleIndex++;

                // if needleIndex is equal to the length of needle, we return the position we are at within haystack
                if(needleIndex == needle.Length){
                    // return index in haystack
                    return i - needleIndex + 1;
                }
            // if we don't have a match, we move back in the haystack
            // to check for a mtach starting from the next character
            } else {
                i -= needleIndex;
                needleIndex = 0;
            }
        }
        // if we make it through without matches, return -1, 'false'
        return -1;
    }
}