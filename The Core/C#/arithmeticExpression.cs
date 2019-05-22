bool arithmeticExpression(int a, int b, int c) {

    bool divInt = false;
    int plus = a + b;
    int sub = a - b;
    int mult = a * b;
    
    divInt = a % b == 0 ? true : false;
    
    if(plus == c || sub == c || mult == c){
        return true;
    } else if(divInt){
       if(a/b == c){
           return true;
       }
    } else {
        return false;
    }   
    return false;
}
