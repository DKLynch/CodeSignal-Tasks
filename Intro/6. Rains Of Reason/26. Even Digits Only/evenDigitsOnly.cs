bool evenDigitsOnly(int n) {
    var chars = n.ToString().ToCharArray();
    
    foreach(char c in chars){
        if(char.GetNumericValue(c) % 2 != 0) return false;
    }
    
    return true;
}
