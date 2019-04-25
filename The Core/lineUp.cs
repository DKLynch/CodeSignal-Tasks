int lineUp(string commands) {
    bool matching = true;
    int counter = 0;
    
    foreach(char c in commands){
        
        if((c == 'L' || c == 'R') && matching){
            matching = false;
        }
        else if ((c == 'L' || c == 'R') && !matching){
            matching = true;
            counter++;
        }    
        else if (c == 'A'){
            if(matching) counter++;
        }      
    }
    
    return counter;
}
