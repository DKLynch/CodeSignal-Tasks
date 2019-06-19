int[] shuffledArray(int[] shuffled) {
    //In hindsight, I totally overthought this, simpler solution is below
    int sum = 0;
    
    for(int i = 0; i < shuffled.Length; i++){
        var otherNums = shuffled.Where((x, j) => j != i);
      
        int total = 0;       
        foreach(int num in otherNums){
            total += num;
        }
        
        if(total == shuffled[i]){
            sum = shuffled[i];
            var arr = otherNums.ToArray();
            Array.Sort(arr);
            return arr;
        }        
    }    
    return null;
}

int[] shuffledArray(int[] shuffled){
    int total = shuffled.Sum() / 2;
    List<int> nums = shuffled.ToList();
    nums.Remove(total);
    nums.Sort();
    
    return nums.ToArray();
}
