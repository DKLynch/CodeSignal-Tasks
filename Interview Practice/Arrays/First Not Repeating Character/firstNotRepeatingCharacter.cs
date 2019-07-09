char firstNotRepeatingCharacter(string s) {
    for(int i = 0; i < s.Length; i++)
    {
        if(s.LastIndexOf(s[i]) == s.IndexOf(s[i])){
            return s[i];
        }
    }
    
    return '_';
}
