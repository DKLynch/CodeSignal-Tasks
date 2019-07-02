function metroCard(lastNumberOfDays)
    if lastNumberOfDays == 28 then 
        return {31}
    elseif lastNumberOfDays == 30 then 
        return {31}
    elseif lastNumberOfDays == 31 then 
        return {28, 30, 31}
    else 
        return null
    end
end
