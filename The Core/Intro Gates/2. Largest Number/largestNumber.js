function largestNumber(n) {
    var res = "";
    var num = 9;
    
    for(i = 0; i < n; i++){
        res += num.toString();
    }
    
    return parseInt(res);
}
