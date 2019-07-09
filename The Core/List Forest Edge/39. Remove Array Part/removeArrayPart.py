def removeArrayPart(inputArray, l, r):
    output = list()

    for x in range(0, min(l, r)):
        output.append(inputArray[x])
        
    for x in range(max(l, r) + 1, len(inputArray)):
        output.append(inputArray[x])
    
    return output
