int crossingSum(int[][] matrix, int a, int b) {
    int total = 0;
    
    for(int i = 0; i < matrix.Length; i++){       
        if(i == a){
            foreach(int n in matrix[i]){
                total += n;
            }
        } else {
            for(int j = 0; j < matrix[i].Length; j++){
                if(j == b){
                    total += matrix[i][j];
                }
            }
        }
    }
    
    return total;
}
