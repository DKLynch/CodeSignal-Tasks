int[] extractMatrixColumn(int[][] matrix, int column) {
    List<int> extractedColumn = new List<int>();
    
    foreach(int[] row in matrix){
        extractedColumn.Add(row[column]);
    }
    
    return extractedColumn.ToArray();
}
