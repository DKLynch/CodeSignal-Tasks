int adjacentElementsProduct(int[] inputArray) {
    double max = double.NegativeInfinity;
	
    for (int i = 0; i < inputArray.Length - 1; i++ ) {       
        max = Math.Max(max, inputArray[i] * inputArray[i+1]);
    }  
	
    return Convert.ToInt32(max);
}
