string[] lrc2subRip(string[] lrcLyrics, string songLength) {
    List<string> subRipLyrics = new List<string>();
    
    for(int i = 0; i < lrcLyrics.Length; i++){
        string time1 = "";
        string time2 = "";
        
        var splitStr1 = lrcLyrics[i].Split(']');
        time1 = splitStr1[0].TrimStart('[');
        
        if(i == lrcLyrics.Length - 1){
            time2 = new string(songLength + ",00");
        } else {
            var splitStr2 = lrcLyrics[i+1].Split(']');
            time2 = ("00:" + splitStr2[0].TrimStart('['));        
        }
      
        subRipLyrics.Add((i+1).ToString());
        subRipLyrics.Add(FormatTime(new string("00:" + time1.Replace('.', ',') + "0")) + " --> " + FormatTime(new string(time2.Replace('.', ',') + "0")));
        subRipLyrics.Add(splitStr1[1].TrimStart(' '));
        
        if(i != lrcLyrics.Length - 1){
            subRipLyrics.Add("");
        }
    }
    
    return subRipLyrics.ToArray();
}

string FormatTime(string input){
    var split = input.Split(',');
    var nums = split[0].Split(':').Select(x => int.Parse(x)).ToList();

    for(int i = 1; i < nums.Count(); i++){
        if(nums[i] > 59){
            nums[i] -= 60;
            nums[i - 1] += 1;
        }
    }
    
    string newString = "";
    for(int i = 0; i < nums.Count(); i++){
        string temp = "";
        if(nums[i] < 10) temp = ("0" + nums[i].ToString());
        else temp = nums[i].ToString();
        newString += (temp + ":");
    }
       
    return newString.TrimEnd(':') + "," + split[1];
}
