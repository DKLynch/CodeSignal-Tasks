//NOTE: This solution passes 23/27 of the test cases on CodeSignal, failing only due to timeout on larger inputs.
//However, this passes 74/74 test cases on LeetCode.
//Further optimization is needed to beat the last few tests on CodeSignal, 
//currently looking into the Knuth-Morris-Pratt algorithm that a few google searches have turned up as a possible solution.

int strstr(string s, string x) {
    
    //If the strings match, or the string to match is empty, return 0
    if(s == x || x == "")
        return 0;
    
    //If the string to match is longer than the checked string, return -1
    if(x.Length > s.Length)
        return -1;
    
    for(int i = 0; i <= s.Length - x.Length; i++){  
        
        //if the current character matches the first character of the string to match
        //and the character x.Length positions from now also matches, loop through the
        //intermediate characters and break if any characters don't match.
        if(s[i] == x[0] && s[i + x.Length - 1] == x[x.Length -1]){
            for(int j = 0; j < x.Length; j++){
                
                if(s[i+j] != x[j])
                    break;
                                
                if(j == x.Length - 1)
                    return i;
            }
        }
    }
    
    return -1;
}

//int strstr(string s, string x){
//    return s.IndexOf(x);
//}