/*

This function takes in an intger, can be negative/positive, and returns boolean if it is a palindrome.
For all negatives, we return false, because the "-" makes it a non-palindrome.
For 0, it is a palindrome.

We use a StringBuilder object to store the individual numbers in the interger x.
Our while loop will be reducing the number one ten place.
We add each one place to our StringBuilder by using mod 10 of the integer, then decrement the integer by dividing by 10.

Example: 1001

Temp Variable: 1001 -> 100 -> 10 -> 1 -> 0 (we are dividing by 10 every loop)
String Builder: [''] -> [1] -> 10 -> 100 -> 1001 (we are appending temp % 10 evenry loop)

Then we use .ToString for both the integer and StringBuilder and compare.

*/

public class Solution  {
    public bool IsPalindrome(int x){
        if(x < 0){
            return false;
        }
        if(x==0){
            return true;
        }

        var temp = x;
        var reversed = new StringBuilder();

        while(temp != 0){
            reversed.Append(temp % 10);
            temp = temp / 10;
        }

        return x.ToString() == reversed.ToString();
    }
}