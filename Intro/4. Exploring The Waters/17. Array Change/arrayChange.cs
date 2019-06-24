int arrayChange(int[] inputArray) {
    int totalMoves = 0;
    
    for(int i = 0; i < inputArray.Length - 1; i++){
        if(inputArray[i] >= inputArray[i+1]){
            totalMoves += inputArray[i] + 1 - inputArray[i+1];
            inputArray[i + 1] = inputArray[i] + 1;
        }
    }
    
    return totalMoves;
}
