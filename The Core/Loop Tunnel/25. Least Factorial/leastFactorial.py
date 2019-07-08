def leastFactorial(n):
    res = 1
    
    for x in range(2, n):
        res *= x
        if res >= n:
            return res
        
    return res
