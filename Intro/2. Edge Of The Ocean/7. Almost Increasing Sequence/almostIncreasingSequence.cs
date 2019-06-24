bool almostIncreasingSequence(int[] sequence) { 
    int removals = 0;
    
    for(int i = 0; i < sequence.Length - 1; i++){
        if(sequence[i] >= sequence[i+1]){
            bool firstCheck = CheckList(new List<int>(sequence), i);
            bool secondCheck = CheckList(new List<int>(sequence), i+1);
            
            if(!firstCheck && !secondCheck){
                return false;
            } else if(firstCheck || secondCheck){
                removals++;
            }
        }
    }
    
    return removals > 1 ? false : true;
}

bool CheckList(List<int> list, int removeIndex){
    list.RemoveAt(removeIndex);
    
    for(int i = 0; i < list.Count - 1; i++){
        if(list[i] >= list[i+1]){
            return false;
        }
    }
    
    return true;
}
