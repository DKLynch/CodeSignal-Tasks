def magicalWell(a, b, n):
    total = 0
    
    for x in range(1, n+1):
        total += (a * b)
        a += 1
        b += 1
        
    return total
