public class Solution {
    public string Convert(string s, int numRows){
        if(numRows == 1){
            return s;
        }
        List<char>[] zigZags = buildZigZags(s, numRows);
        StringBuilder result = new StringBuilder(s.Length);

        for(int i = 0; i < zigZags.Length; i++){
            foreach(var c in zigZags[i]){
                result.Append(c);
            }
        }
        return result.ToString();
    }
    
    public List<char>[] buildZigZags(string s, int numRows){
        List<char>[] zigZags = new List<char>[numRows];
        for (int j = 0; j < numRows; j++){
            zigZags[j] = new List<char>(s.Length);
        }

        int row = -100;
        bool traversing = false;
        foreach(char character in s.ToCharArray()){
            if(row == -100){
                row = 0;
            } else {
                if(traversing == false){
                    row += 1;
                    if(row == numRows -1){
                        traversing = true;
                    }
                } else {
                    row -= 1;
                    if(row == 0){
                        traversing = false;
                    }
                }
            }
            zigZags[row].Add(character)
        }
        return zigZagGrid;
    }
}

