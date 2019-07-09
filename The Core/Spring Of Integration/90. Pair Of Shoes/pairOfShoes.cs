bool pairOfShoes(int[][] shoes) {
    List<int> leftShoes = new List<int>();
    List<int> rightShoes = new List<int>();
    
    for(int i = 0; i < shoes.Length; i++){
        int type = shoes[i][0];
        int size = shoes[i][1];
        
        if(type == 0)
            leftShoes.Add(size);
        else
            rightShoes.Add(size);
    }
    
    leftShoes.Sort();
    rightShoes.Sort();
    
    if(leftShoes.Count() != rightShoes.Count())
        return false;
    
    for(int i = 0; i < leftShoes.Count(); i++){
        if(leftShoes[i] != rightShoes[i])
            return false;
    }
    
    return true;   
}
