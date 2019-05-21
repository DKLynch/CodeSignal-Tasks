int[] firstReverseTry(int[] arr) {
    
    if(arr.Length >= 2){
        int first = arr[0];
        int last = arr[arr.Length-1];
        arr[arr.Length-1] = first;
        arr[0] = last;
    }
    
    return arr;
}
