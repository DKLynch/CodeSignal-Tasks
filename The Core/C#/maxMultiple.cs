int maxMultiple(int divisor, int bound) {  
    double d = bound/divisor;
    int r = Convert.ToInt32(Math.Round(d));    
    return divisor * r;   
}
