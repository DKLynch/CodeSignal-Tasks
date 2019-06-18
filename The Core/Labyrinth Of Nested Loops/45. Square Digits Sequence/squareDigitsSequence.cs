int squareDigitsSequence(int a0) {
    int num = a0;
    List<int> seenNums = new List<int>();
    seenNums.Add(a0);
    
    do{
        int total = 0;
        var chars = num.ToString().ToCharArray();
        
        foreach(char c in chars){
            var n = int.Parse(c.ToString());
            total += n * n;
            //Console.Write(n + "^2 = " + n*n + "\n");
        }
        
        num = total;      
        //Console.Write(num + "-\n");
        seenNums.Add(num);
        
        for(int i = 0; i < seenNums.Count - 1; i++){
            if(seenNums[i] == num){
                return seenNums.Count;
            }
        }

    } while (true);   
}
