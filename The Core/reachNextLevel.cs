bool reachNextLevel(int experience, int threshold, int reward) {
    if(threshold - reward > experience){
        return false;
    } else { 
        return true;
    }
}
