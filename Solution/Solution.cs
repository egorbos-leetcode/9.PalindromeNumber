namespace Solution;

public class Solution
{
    public static bool IsPalindrome(int x) {
        var temp = x;
        int remainder, sum = 0;
        while (temp > 0) {
            remainder = temp % 10;
            temp /= 10;
            sum = sum * 10 + remainder;
        }
        return x == sum;
    }
}
