int firstDuplicate(int[] a) {
    List<int> prevNums = new List<int>();
    
    for(int i = 0; i < a.Length; i++){        
        if(prevNums.Contains(a[i]))
            return a[i];
        else
            prevNums.Add(a[i]);
    }
    
    return -1;
}
