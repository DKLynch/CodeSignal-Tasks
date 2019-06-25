string alphabeticShift(string inputString) {
    var chars = inputString.ToCharArray();
    
    for(int i = 0; i < chars.Length; i++){
        if(chars[i] == 'z'){
            chars[i] = 'a';
        } else {
            chars[i] = (char)(Convert.ToUInt16(chars[i]) + 1);
        }
    }
    
    return new string(chars);
}
