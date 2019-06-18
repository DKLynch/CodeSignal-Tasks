int magicalWell(int a, int b, int n) {
    int total = 0;
    for(int i = 1; i <= n; i++){
        total += (a * b);
        a++;
        b++;
    }
    return total;
}
