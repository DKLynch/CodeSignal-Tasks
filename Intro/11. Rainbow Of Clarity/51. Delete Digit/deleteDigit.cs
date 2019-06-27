int deleteDigit(int n) {
    if(n < 10) return n;
    
    var len = n.ToString().Length;
    int counter = 0;
    int maxNum = Int32.MinValue;
    
    while(counter < len){
        var chars = n.ToString().ToCharArray().ToList();
        for(int i = 0; i < chars.Count; i++){
            chars.RemoveAt(i);
            int num = int.Parse(new string(chars.ToArray()));
            if(num > maxNum) maxNum = num;
            chars = n.ToString().ToCharArray().ToList();
        }
        counter++;
    }

    return maxNum;
}
