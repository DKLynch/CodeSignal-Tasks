bool isPower(int n) {
    int power = 2;
    int num = 2;
    
    if(n == 1) return true;
    
    while(power < 400){
        num = power;
        while(num < n){
            num *= power;
            if(num == n) return true;
        }
        power += 1;
    }
    
    return false;
}
