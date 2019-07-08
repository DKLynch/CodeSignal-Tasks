def appleBoxes(k):
    isOdd = True
    totalRed = 0
    totalYellow = 0
    
    for x in range(1, k+1):
        if(isOdd):
            totalYellow = totalYellow + (x * x)
        else:
            totalRed = totalRed + (x * x)
        
        isOdd = not isOdd

    return totalRed - totalYellow
