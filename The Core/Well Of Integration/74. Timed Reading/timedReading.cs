int timedReading(int maxLength, string text) { 
    var words = Regex.Matches(text, @"(\b[^\s]+\b)");
    int total = words.Count;
    
    foreach(var word in words){
        if(word.ToString().Length > maxLength) total -= 1;
    }

    return total;
}
