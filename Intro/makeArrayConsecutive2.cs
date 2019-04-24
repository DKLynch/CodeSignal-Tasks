int makeArrayConsecutive2(int[] statues) {     
    Array.Sort(statues);
    
    int startNo = statues[0];
    int endNo = statues[statues.Length - 1];
    int index = 0;
    int neededStatues = 0;
    
    for(int i = startNo; i < endNo; i++){           
        if(i == statues[index]) index ++;       //Move onto the next number in the array if we have a match
        else neededStatues++;                   //Else increment the number of statues needed
    }
    
    return neededStatues;
}
