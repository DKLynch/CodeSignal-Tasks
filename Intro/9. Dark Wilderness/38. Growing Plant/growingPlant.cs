int growingPlant(int upSpeed, int downSpeed, int desiredHeight) {
    int days = 0;
    int height = 0;
    
    while(true){
        days += 1;
        height += upSpeed;
        if(height >= desiredHeight) return days;
        height -= downSpeed;
    }  
}
