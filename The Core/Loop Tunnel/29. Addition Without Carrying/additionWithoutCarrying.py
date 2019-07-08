def additionWithoutCarrying(param1, param2):
    num1 = str(param1)
    num2 = str(param2)
    sum = 0
    
    for x in range(0, max(len(num1), len(num2))):
        d1 = 0
        d2 = 0
        
        if(x < len(num1)):
            d1 = str(int(num1[(len(num1) - 1) - x]))
            
        if(x < len(num2)):
            d2 = str(int(num2[(len(num2) - 1) - x]))

        product = int(d1) + int(d2)  
        if(product >= 10):
            product -= 10
        
        sum = sum + product * int(pow(10, x))
        
    return sum
