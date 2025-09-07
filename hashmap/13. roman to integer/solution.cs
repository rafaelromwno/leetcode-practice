public class Solution {
    public int RomanToInt(string s) {

        Dictionary<char, int> map = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        char[] CharVector = s.ToArray();
        int size = CharVector.Length - 1;
        int value = map[CharVector[size]];

        for(int i = 0; i < size; i++)
        {
            
            if (map[CharVector[i + 1]] > map[CharVector[i]])
                value -= map[CharVector[i]];
            else
                value += map[CharVector[i]];
                        
        }

        return value;
    }
}
