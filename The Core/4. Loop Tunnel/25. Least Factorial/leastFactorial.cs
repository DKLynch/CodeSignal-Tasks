int leastFactorial(int n) {
    int res = 1; 
    for(int i = 2; i<=n; i++){
        res *= i;
        if(res >= n) return res;
    }
    return res;
}
