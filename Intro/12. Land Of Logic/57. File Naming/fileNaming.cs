string[] fileNaming(string[] names) {
    List<string> usedNames = new List<string>();
    
    foreach(string n in names){
        if(usedNames.Contains(n)){
            int counter = 1;
            while(counter <= 20){
                if(!usedNames.Contains(n + "(" + counter.ToString() + ")")){
                    usedNames.Add(n + "(" + counter.ToString() + ")");
                    break;
                } else {
                    counter++;
                }
            }
        } else {
            usedNames.Add(n);
        }
    }
    
    return usedNames.ToArray();
}
