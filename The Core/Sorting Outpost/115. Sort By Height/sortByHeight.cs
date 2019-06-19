int[] sortByHeight(int[] a) {
    List<int> treeIndexes = new List<int>();
    List<int> heights = new List<int>();
    
    for(int i = 0; i < a.Length; i++){
        if(a[i] == -1) treeIndexes.Add(i);
        else heights.Add(a[i]);
    }
    
    heights.Sort();
    foreach(int i in treeIndexes){
        heights.Insert(i, -1);
    }
    
    return heights.ToArray();
}
