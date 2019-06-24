int commonCharacterCount(string s1, string s2) {
    int commonChars = 0;
    var list1 = s1.ToCharArray().ToList();
    var list2 = s2.ToCharArray().ToList();

    foreach(char c in list1){
        if(list2.Contains(c)){
            list2.Remove(c);
            commonChars++;
        }
    }
    
    return commonChars;
}
