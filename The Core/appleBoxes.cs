int appleBoxes(int k) {
    bool isOdd = true;
    int totalRed = 0;
    int totalYellow = 0;
    
    for(int i = 1; i <= k; i++){
        if(isOdd){
            totalYellow = totalYellow + (i * i);
        }
        else{
            totalRed = totalRed + (i * i);
        }
        
        isOdd = !isOdd;
    }    
    return totalRed - totalYellow;
}
