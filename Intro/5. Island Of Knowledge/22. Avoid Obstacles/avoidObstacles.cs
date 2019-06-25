int avoidObstacles(int[] inputArray) {
    int jumpLength = 1;
    
    while(true){      
        if(inputArray.Where(x => x % jumpLength == 0).Count() == 0){
            return jumpLength;
        } else {
            jumpLength++;
        }
    }   
}
