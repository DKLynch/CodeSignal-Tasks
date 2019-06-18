int stringsConstruction(string a, string b) {
    var aChars = a.ToCharArray();
    var bChars = b.ToCharArray();    
    var sharedChars = aChars.Intersect(bChars);
    List<int> noTimes = new List<int>();

    foreach(char c in aChars){
        bool match = false;
        foreach (char m in bChars){
            if(m == c) match = true;
        }
        
        if(!match) return 0;
    }
    
    foreach(char c in sharedChars){
        int needed = aChars.Count(aC => aC == c);
        int have = bChars.Count(aB => aB == c);
        int times = (int)Math.Floor((double)have/needed);
        noTimes.Add(times);
    }
    
    if(noTimes.Count != 0){
        return noTimes.Min();
    } else {
        return 0;
    }
}
