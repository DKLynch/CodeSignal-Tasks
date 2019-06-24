bool isLucky(int n) {
    string num = n.ToString();
    int mid = num.Length/2;
    string[] halves = {num.Substring(0, mid), num.Substring(mid)};
    int[] sums = {0,0};
    
    for(int i = 0; i < halves.Length; i++){
        int sum = 0;
        var arr = halves[i].ToCharArray();
            foreach(char c in arr){
                sum += (int)char.GetNumericValue(c);
            }
        sums[i] = sum;
    }
    
    return (sums[0] == sums[1]);
}
