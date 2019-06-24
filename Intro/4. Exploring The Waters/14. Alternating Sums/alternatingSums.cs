int[] alternatingSums(int[] a) {
    int team1Weight = 0;
    int team2Weight = 0;
    
    for(int i = 0; i < a.Length; i++){
        if(i % 2 == 0){
            team1Weight += a[i];
        } else {
            team2Weight += a[i];
        }
    }
    
    return new int[]{team1Weight, team2Weight};
}
