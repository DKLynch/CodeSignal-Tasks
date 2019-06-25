bool variableName(string name) {
    var chars = name.ToCharArray();
    
    if(char.IsDigit(chars[0])) return false;  
    
    var outliers = chars.Where(x => !(char.IsLetterOrDigit(x)) && x != '_');

    return outliers.Count() > 0 ? false : true;
}
