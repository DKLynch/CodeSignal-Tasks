function isInfiniteProcess(a, b)
    
    if a > b then
        return true
    end
    
    if a == b then 
        return false
    end
    
    if a < b then
        if (b-a) % 2 == 0 then
            return false
        else
            return true
        end
    end       
end
