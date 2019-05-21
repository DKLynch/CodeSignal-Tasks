int[] replaceMiddle(int[] arr) {
    int middle = (int)Math.Floor((decimal)arr.Length/2-1);
    int sum = 0;
    bool doubleMiddle = false;
    List<int> res = new List<int>();
    
    if(arr.Length % 2 == 0){
        doubleMiddle = true; 
    }
    
    for(int i = 0; i < middle; i++){
        res.Add(arr[i]);
    }
    
    int resumePoint = 0;
    if(doubleMiddle){
        sum = arr[middle] + arr[middle+1];
        resumePoint = middle + 2;
    } else {
        sum = arr[middle];
        resumePoint = middle + 1;
    }   
    res.Add(sum);

    for(int i = resumePoint; i < arr.Length; i++){
        res.Add(arr[i]);
    }

    var result = res.ToArray();
    return result;
}
