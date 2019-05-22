int isSumOfConsecutive2(int n) {
    int numWays = 0;
    
    for(int i = 1; i < n; i++){
        int sum = 0;
        int counter = i;
        
        while(sum < n){
            sum += counter;
            if(sum == n) numWays += 1;
            if(sum > n) break;
            counter += 1;
        }        
    }       
    return numWays;   
}
