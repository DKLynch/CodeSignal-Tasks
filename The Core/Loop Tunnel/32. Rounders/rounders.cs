int rounders(int n) {
    string num = n.ToString();
    var chars = num.ToCharArray();
    bool carry = false;
    string result = "";
    
    for(int i = chars.Length - 1; i >= 0; i--){
        var c = int.Parse(chars[i].ToString());
        
        if(carry){
            c += 1;
        }
        
        carry = false;
        
        if(c >= 5){
            carry = true;
        }
        
        if(i != 0){
            result += "0";
        } else {
            if(c == 10){
                result += "01";
            }         
            else{
                result += c.ToString();
            }
        }
    }
    
    var s = result.ToCharArray();
    Array.Reverse(s);
    result = new string(s);
    return int.Parse(result);
}
