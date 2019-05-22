int pagesNumberingWithInk(int current, int numberOfDigits) {
    int numPages = current;
    int numDigits = numberOfDigits;
    int len = 0;
    int page = current;
    
    do{
        len = page.ToString().Length;
        if(numDigits >= len){
            numPages += 1;
            page += 1;
            numDigits -= len;
        } else {
            return numPages - 1;
        }
    }while(numDigits > 0);
    
    return numPages - 1;
}
