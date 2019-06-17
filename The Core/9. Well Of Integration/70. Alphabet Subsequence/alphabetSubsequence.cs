bool alphabetSubsequence(string s) {
    for(int i = 0; i < s.Length - 1; i++){
        if(s[i] >= s[i+1]) return false;
    }
    return true;
}
