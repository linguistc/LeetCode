public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        // Concatenate all elements of word1
        string s1 = string.Join("", word1);

        // Concatenate all elements of word2
        string s2 = string.Join("", word2);

        // Compare the two concatenated strings
        return s1 == s2;

    }
}