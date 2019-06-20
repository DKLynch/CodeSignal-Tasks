int uniqueDigitProducts(int[] a) {
    List<int> products = new List<int>();
    
    for(int i = 0; i < a.Length; i++){
        var s = a[i].ToString().ToCharArray();
        int product = 1;
        
        foreach(char c in s){
            product *= (int)Char.GetNumericValue(c);
        }
        
        products.Add(product);
    }
    
    var distinct = products.Distinct().ToList();
    return distinct.Count();
}
