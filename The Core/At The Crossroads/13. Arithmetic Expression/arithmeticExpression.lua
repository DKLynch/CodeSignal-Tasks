function arithmeticExpression(a, b, c)
    
    divInt = false
    plus = a + b
    sub = a - b
    mult = a * b
    
    if a % b == 0 then
        divInt = true
    else 
        divInt = false
    end
    
    if plus == c or sub == c or mult == c then
        return true
    elseif divInt == true then
        if a / b == c then
            return true
        else
            return false
        end
    else
        return false
    end
end
