string[] allLongestStrings(string[] inputArray) {
    int maxLength = 0;
    
    foreach(string s in inputArray){
        if(s.Length > maxLength) maxLength = s.Length;
    }
    
    return inputArray.Where(x => x.Length == maxLength).ToArray();
}
