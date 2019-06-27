int electionsWinners(int[] votes, int k) {
    int numToBeat = votes.Max();
    
    if(k == 0){
        return votes.Count(x => x == numToBeat) > 1 ? 0 : 1;
    }
    
    return votes.Count(x => x + k > numToBeat);
}
