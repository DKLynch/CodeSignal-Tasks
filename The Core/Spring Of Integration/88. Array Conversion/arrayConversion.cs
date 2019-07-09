int arrayConversion(int[] inputArray) {
    int iteration = 1;
    List<int> numList = inputArray.ToList();
    List<int> newNums = new List<int>();
    
    if(inputArray.Length == 1)
        return inputArray[0];
    
    do{
        newNums.Clear();
        
        if(iteration % 2 == 1){
            for(int i = 0; i < numList.Count() - 1; i += 2){
                newNums.Add(numList[i] + numList[i + 1]);
            }
        }
        else if(iteration % 2 == 0){
            for(int i = 0; i < numList.Count() - 1; i += 2){
                newNums.Add(numList[i] * numList[i + 1]);
            }
        }
        
        numList.Clear();
        numList = newNums.ToList();
        iteration += 1;
    }while(newNums.Count > 1);
    
    return newNums[0];
}
