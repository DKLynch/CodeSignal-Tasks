function phoneCall(min1, min2_10, min11, s) {
    var centsRemaining = s;
    var minutes = 0;
    
    if(min1 <= centsRemaining){
        centsRemaining -= min1;
        minutes += 1;
    } else {
        return minutes;
    }
    
    for(i = 2; i <= 10; i++){
        if(min2_10 < centsRemaining){
            centsRemaining -= min2_10;
            minutes += 1;
        } else {
            return minutes;
        }
    }
    
    var rem = centsRemaining/min11;
    minutes += parseInt(Math.floor(rem));
    
    return minutes;
}
