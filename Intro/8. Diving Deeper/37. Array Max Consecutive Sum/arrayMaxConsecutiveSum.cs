int arrayMaxConsecutiveSum(int[] inputArray, int k) {
    int max = 0;
    
    for(int i = 0; i <= inputArray.Length - k; i++){
        int sum = 0;
        for(int j = i; j < (i + k); j++){
            sum += inputArray[j];
        }
        if(sum > max) max = sum;
    }
    
    return max;
}
