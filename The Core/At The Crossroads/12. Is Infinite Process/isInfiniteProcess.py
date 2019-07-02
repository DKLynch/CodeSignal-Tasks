def isInfiniteProcess(a, b):

    if a > b:
        return True
    
    if a == b:
        return False
    
    if a < b:
        if(b-a) % 2 == 0:
            return False
        else:
            return True
        
    return False
