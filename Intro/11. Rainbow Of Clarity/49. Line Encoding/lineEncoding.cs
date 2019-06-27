string lineEncoding(string s) {
    List<char> characters = new List<char>();
    List<int> appearances = new List<int>();
    char currentChar = s[0];
    int count = 1;
    string output = "";
    
    characters.Add(currentChar);    
    for(int i = 1; i < s.Length; i++){        
        if(currentChar != s[i]){          
            currentChar = s[i];
            characters.Add(currentChar);
            appearances.Add(count);
            count = 1;
        } else {
            count += 1;
        }       
    }    
    appearances.Add(count);
    
    for(int j = 0; j < characters.Count; j++){
        if(appearances[j] == 1){
            output += characters[j];
        } else {
            output += (appearances[j].ToString() + characters[j]);
        }
    }
    
    return output;
}
