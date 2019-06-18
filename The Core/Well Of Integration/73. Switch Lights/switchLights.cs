int[] switchLights(int[] a) {
    
    for(int i = 0; i < a.Length; i++){
        if(a[i] != 0){
            for(int j = 0; j <= i; j++){
                a[j] = (a[j] != 0) ? 0 : 1;
            }
        }
    }    
    return a;
}


