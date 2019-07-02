function addTwoDigits(n)
    sum = 0
    str = tostring(n)

    for i = 1, #str do
        local c = str:sub(i, i)
        sum = sum + c
    end
    
    return sum 
end
