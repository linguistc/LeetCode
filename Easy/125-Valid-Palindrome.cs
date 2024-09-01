public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            // Move pointers to the next alphanumeric character
            while(left < right && !char.IsLetterOrDigit(s[left]))
                ++left;

            while(left < right && !char.IsLetterOrDigit(s[right]))
                --right;

            
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            ++left;
            --right;
        }

        return true;

    }
}