def isSmooth(arr):
    result = False
    
    if(arr[0] == arr[len(arr) - 1]):
        if(len(arr) % 2 == 0):
            if(arr[int(len(arr) / 2 - 1)] + arr[int(len(arr) / 2)] == arr[0]):
                result = True
        else:
            if(arr[int(math.floor(len(arr)) / 2)] == arr[0]):
                result = True
                
    return result
