int digitDegree(int n) {
    var digits = n.ToString().ToCharArray();
    int sum = 0;
    int degree = 0;
    
    if(digits.Length == 1) return 0;
    
    do{
        sum = 0;
        for(int i = 0; i < digits.Length; i++){
            sum += (int)char.GetNumericValue(digits[i]);
        }
        digits = sum.ToString().ToCharArray();
        degree += 1;
    }while(sum >= 10);
    
    return degree;
}
