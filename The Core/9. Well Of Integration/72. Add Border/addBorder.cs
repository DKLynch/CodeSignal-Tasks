string[] addBorder(string[] picture) {
    List<string> borderedMatrix = new List<string>();
    int width = picture[0].Length + 1;
    string verticalBorder = "";
    
    for(int i = 0; i <= width; i++){
        verticalBorder += "*";
    }
    
    borderedMatrix.Add(verticalBorder); 
    for(int i = 0; i < picture.Length; i++){
        borderedMatrix.Add(new string("*" + picture[i] + "*"));
    }
    borderedMatrix.Add(verticalBorder);
    
    return borderedMatrix.ToArray();
}
