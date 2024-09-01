public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        // Initialize indices for word1 and word2 arrays
        short w1 = 0 , w2 = 0;
       // Initialize indices for characters within the current words
        short i = 0, j = 0;

        // Loop until we've exhausted either word1 or word2 arrays
        while(w1 < word1.Length && w2 < word2.Length)
        {
            // If characters don't match, return false immediately
            if(word1[w1][i] != word2[w2][j])
                return false;
            
            // Move to the next character in both current words
            ++i;
            ++j;

            // Move to the next word if you've reached the end of the current word 
            if(i == word1[w1].Length)
            {
                ++w1;
                i = 0;
            }

            if(j == word2[w2].Length)
            {
                ++w2;
                j = 0;
            }
        }

        // After exiting the loop, check if both arrays are fully traversed
        // If either array hasn't been fully traversed, return false
        if(w1 != word1.Length || w2 != word2.Length)
            return false;

        // If both arrays are fully traversed and matched, return true
        return true;

    }
}