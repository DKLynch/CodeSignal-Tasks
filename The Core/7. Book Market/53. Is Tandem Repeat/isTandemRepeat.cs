bool isTandemRepeat(string inputString) {    
    if(inputString.Length % 2 != 0){
        return false;
    } else {           
    int middle = inputString.Length / 2;
    return inputString.Substring(0, middle) == inputString.Substring(middle);
    }
}
