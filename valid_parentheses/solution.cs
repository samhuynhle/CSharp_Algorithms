public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++){
            char current = s[i];

            if(current == '(' || current == '[' || current == '{'){
                stack.Push(current);
            } else if(current == ')' || current == ']' || current == '}'){
                if(stack.Count == 0){
                    return false;
                }
                var previous = (char)stack.Pop();
                if((previous == '(' && current == ')') || (previous == '[' && current == ']') || (previous == '{' && current == '}')){
                    continue;
                }
                return false;
            }
        }
        return stack.Count == 0;
    }
}