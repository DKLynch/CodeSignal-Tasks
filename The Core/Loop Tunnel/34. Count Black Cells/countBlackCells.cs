int countBlackCells(int n, int m) {
    return n + m + gcd(n,m) - 2;
}

int gcd(int a, int b){
    if(b == 0)
        return a;
    else
        return gcd(b, a%b);
}
