def replaceMiddle(arr):
    middle = int(math.floor(len(arr) / 2 - 1))
    sum = 0
    doubleMiddle = False
    res = list()
    
    if(len(arr) % 2 == 0):
        doubleMiddle = True
        
    for x in range(0, middle):
        res.append(arr[x])
        
    resumePoint = 0
    if(doubleMiddle):
        sum = arr[middle] + arr[middle+1]
        resumePoint = middle + 2
    else:
        sum = arr[middle]
        resumePoint = middle + 1    

    res.append(sum)
    
    for x in range(resumePoint, len(arr)):
        res.append(arr[x])
        
    return res
