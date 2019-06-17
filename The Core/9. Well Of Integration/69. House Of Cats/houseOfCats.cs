int[] houseOfCats(int legs) {
    List<int> possiblePeople = new List<int>();

    for(int i = 0; i <= legs/2; i++){
        if((legs - i*2) % 4 == 0) possiblePeople.Add(i);
    }
    
    return possiblePeople.ToArray();
}
