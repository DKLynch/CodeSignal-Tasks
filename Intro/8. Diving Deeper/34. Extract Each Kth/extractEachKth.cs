int[] extractEachKth(int[] inputArray, int k) {
    List<int> nums = new List<int>();
    int factor = 1;

    if(k == 1) return new int[]{};
    
    for(int i = 0; i < inputArray.Length; i++){
        if(i != ((factor*k) - 1)){
            nums.Add(inputArray[i]);
        } else {
            factor++;
        }
    }    
    return nums.ToArray();
}
