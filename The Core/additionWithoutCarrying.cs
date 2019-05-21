int additionWithoutCarrying(int param1, int param2) {
    string num1 = param1.ToString();
    string num2 = param2.ToString();
    int sum = 0;
    
    for(int i = 0; i < Math.Max(num1.Length, num2.Length); i++){
        int d1 = 0, d2 = 0;
        
        if(i < num1.Length){
            d1 = int.Parse(num1[(num1.Length - 1) - i].ToString());
        }
        
        if(i < num2.Length){
            d2 = int.Parse(num2[(num2.Length - 1) - i].ToString());
        }
        
        int product = d1+d2;
        
        if(product >= 10){
            product -=10;
        }
        
        sum = sum + product * Convert.ToInt32(Math.Pow(10, i));
    }
    
    return sum;
}
