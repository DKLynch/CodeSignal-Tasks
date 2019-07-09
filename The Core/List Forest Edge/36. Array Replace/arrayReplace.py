def arrayReplace(inputArray, elemToReplace, substitutionElem):
    for x in range(0, len(inputArray)):
        if inputArray[x] == elemToReplace:
            inputArray[x] = substitutionElem
    
    return inputArray
