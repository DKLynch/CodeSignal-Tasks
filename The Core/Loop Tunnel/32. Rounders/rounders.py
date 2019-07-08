def rounders(n):
    num = str(n)
    chars = list(num)
    carry = False
    result = ""
    
    for x in range(len(chars) - 1, -1, -1):
        c = int(str(chars[x]))
        
        if(carry):
            c += 1
        
        carry = False
    
        if(c >= 5):
            carry = True
        
        if(x != 0):
            result += "0"
        else:
            if(c == 10):
                result += "01"
            else:
                result += str(c);
    
    return int(result[::-1])
