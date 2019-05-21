int makeArrayConsecutive2(int[] statues) {
    int noStatuesNeeded = 0;
    Array.Sort(statues);

    for(int i = 0; i < statues.Length - 1; i++){
        int num = statues[i + 1] - statues[i];
        noStatuesNeeded += num - 1;
    }
    
    return noStatuesNeeded;
}
