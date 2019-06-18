int[] concatenateArrays(int[] a, int[] b) {
    int[] c = new int[a.Length + b.Length];
    
    for(int i = 0; i < a.Length; i++){
        c[i] = a[i];
    }
    
    for(int j = 0; j < b.Length; j++){
        c[a.Length + j] = b[j];
    }
    
    return c;
}

/*int[] concatenateArrays(int[] a, int[] b) {
    return a.Concat(b).ToArray();
}*/
