def countSumOfTwoRepresentations2(n, l, r):
    noWays = 0
    
    for x in range(l, r + 1):
        if (n - x >= x) and (n - x <= r):
            noWays += 1
        
    return noWays
