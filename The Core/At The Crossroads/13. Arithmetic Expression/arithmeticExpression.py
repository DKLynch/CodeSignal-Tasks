def arithmeticExpression(a, b, c):

    divInt = False
    plus = a + b
    sub = a - b
    mult = a * b
    
    if a % b == 0:
        divInt = True
    else: 
        divInt = False
        
    if plus == c or sub == c or mult == c:
        return True
    elif divInt == True:
        if a / b == c:
            return True
        else:
            return False
        
    return False
