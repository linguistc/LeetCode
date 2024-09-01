public class Solution {
    public bool IsPalindrome(string s) {
        //converting the string to lowercase and removing non-alphanumeric characters

        StringBuilder cleanStr = new StringBuilder();

        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
                cleanStr.Append(char.ToLower(c));
        }

        // Check if the cleaned string is a palindrome

        int left = 0, right = cleanStr.Length - 1;

        while(left < right)
        {
            if(cleanStr[left] != cleanStr[right])
                return false;
        
            ++left;
            --right;
        }

        return true;

    }
}