int phoneCall(int min1, int min2_10, int min11, int s) {
    
    int centsLeft = s;
    int minutes = 0;
    
    if(min1 <= centsLeft){
        centsLeft -= min1;
        minutes += 1;
    } else {
        return minutes;
    }
    
    for(int i = 2; i <= 10; i++){
        if(min2_10 < centsLeft){
            centsLeft -= min2_10;
            minutes += 1;
        } else {
            return minutes;
        }
    }
    
    double rem = centsLeft/min11;
    minutes += Convert.ToInt32(Math.Floor(rem));
    
    return minutes;

}
