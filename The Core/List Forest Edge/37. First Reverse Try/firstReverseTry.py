def firstReverseTry(arr):
    if len(arr) >= 2:
        first = arr[0];
        last = arr[len(arr) - 1]
        arr[len(arr) - 1] = first
        arr[0] = last
    
    return arr
