function knapsackLight(value1, weight1, value2, weight2, maxW)
    
    if maxW >= weight1 + weight2 then
        return value1 + value2
    end
    
    if value1 >= value2 then
        if weight1 <= maxW then
            return value1
        elseif weight2 <= maxW then
            return value2
        end
    end
    
    if value2 >= value1 then
        if weight2 <= maxW then
            return value2
        elseif weight1 <= maxW then
            return value1
        end
    end
    
    return 0           
end