int[] removeArrayPart(int[] inputArray, int l, int r) {
    List<int> output = new List<int>();
    
    for(int i = 0; i < Math.Min(l, r); i++){
        output.Add(inputArray[i]);
    }
    
    for(int i = Math.Max(l,r) + 1; i < inputArray.Length; i++){
        output.Add(inputArray[i]);
    }
    
    return output.ToArray();
}
