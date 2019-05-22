bool isCaseInsensitivePalindrome(string inputString) {
    string s = inputString.ToLower();
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    string rs = new string(chars);
    return s == rs;
}
