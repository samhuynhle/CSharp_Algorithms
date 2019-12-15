// Strategy: walk through the string with two markers that capture start and ends of the words.

public class Solution {
    public string ReverseWords(string s)
    {
        var start = 0;
        var end = 0;
        var sb = new StringBuilder(s);
        for (var i = 0; i < s.Length; i++) // simply going through each character in the string
        {
            // we only move the start if we reach these three conditions: 1) if we are at the first character, 2) we are not on a white space, 3) the previous character is a white space
            if (i - 1 >= 0 && s[i] != ' ' && s[i - 1] == ' ') 
            {
                start = i; // we reposition the start marker if we are at the start of a word, indicated by the three conditionals
            }
            if (s[i] != ' ' && (i == s.Length - 1 || (i + 1 < s.Length && s[i + 1] == ' '))) // if we reach these two conditions (one condition has an or to account for the end of string), we know we are at an end of a word
            {
                end = i;
                reverse(sb, start, end); // when we find an end of a word, we use this method to reverse the word between start and end
            }

        }

        return sb.ToString();
    }
    
    public void reverse(StringBuilder sb, int start, int end){
        while(start<=end){
            var t = sb[start];
            sb[start] = sb[end];
            sb[end] = t;
            start++;
            end--;
        }
    }
}