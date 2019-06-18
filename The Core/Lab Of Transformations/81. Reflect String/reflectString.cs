string reflectString(string inputString) {
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    var alphaChars = alphabet.ToCharArray();
    string newString = "";
    
    foreach(char c in inputString){
        newString += alphaChars[(alphaChars.Length-1) - Array.IndexOf(alphaChars, c)];
    }
    
    return newString;
}
