int houseNumbersSum(int[] inputArray) {
    int total = 0;
    
    foreach(int i in inputArray){
        total += i;
        if (i==0) break;
    }
    
    return total;
}
