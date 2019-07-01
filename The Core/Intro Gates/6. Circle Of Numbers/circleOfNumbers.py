def circleOfNumbers(n, firstNumber):
    nums = []
    
    for x in range(n):
        nums.append(x)
    
    if firstNumber < (n/2):
        return nums[int(firstNumber + (n/2))]
    else:
        return nums[int(firstNumber - (n/2))]
