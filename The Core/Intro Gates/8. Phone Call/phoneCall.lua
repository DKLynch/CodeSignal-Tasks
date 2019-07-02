function phoneCall(min1, min2_10, min11, s)
    centsRemaining = s
    minutes = 0
    
    if min1 <= centsRemaining then
        centsRemaining = centsRemaining - min1
        minutes = minutes + 1
    else
        return minutes;
    end 
    
    for x = 3, 11 do
        if min2_10 < centsRemaining then
            centsRemaining = centsRemaining - min2_10
            minutes = minutes + 1
        else
            return minutes
        end
    end
    
    rem = centsRemaining / min11
    minutes = minutes + math.floor(rem)
    
    return minutes
end
