string integerToStringOfFixedWidth(int number, int width) {
    string s = number.ToString();  
    if(width > s.Length){
        do{
            s = new string("0" + s);
        }while(s.Length != width);     
    }else if(width < s.Length){
        s = s.Substring(s.Length - width);
    } 
    return s;
}
