def phoneCall(min1, min2_10, min11, s):
    centsRemaining = s
    minutes = 0
    
    if min1 <= centsRemaining:
        centsRemaining -= min1
        minutes += 1
    else:
        return minutes;

    for x in range(1, 10):
        if min2_10 < centsRemaining:
            centsRemaining -= min2_10
            minutes += 1
        else:
            return minutes
        
    rem = centsRemaining / min11
    minutes += int(math.floor(rem))
    
    return minutes
