int arrayMaximalAdjacentDifference(int[] inputArray) {
    int max = 0;
    
    for(int i = 0; i < inputArray.Length - 1; i++){
        int higherNo = Math.Max(inputArray[i], inputArray[i+1]);
        int lowerNo = Math.Min(inputArray[i], inputArray[i+1]);
        
        if(higherNo - lowerNo > max) max = higherNo - lowerNo;
    }
    
    return max;
}
