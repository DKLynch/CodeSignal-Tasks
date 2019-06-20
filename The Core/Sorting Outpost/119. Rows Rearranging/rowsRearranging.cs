bool rowsRearranging(int[][] matrix) {

    //Sort the matrix by first column of each subarray
    var sortedMatrix = matrix.OrderBy(x => x[0]).ToList();
    
    for(int i = 0; i < matrix.Length - 1; i++){
        for(int j = 0; j < sortedMatrix[i].Length; j++){
            if(sortedMatrix[i][j] >= sortedMatrix[i+1][j]) 
                return false;
        }        
    }
    
    return true;
}
