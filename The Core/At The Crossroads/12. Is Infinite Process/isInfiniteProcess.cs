bool isInfiniteProcess(int a, int b) {
    
    if(a>b){
        return true;
    }
    
    if(a==b){
        return false;
    }
    
    if(a < b){
        if((b-a)%2==0){
            return false;
        } else {
            return true;
        }
    }
    
    return false;
}
