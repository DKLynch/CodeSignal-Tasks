function tennisSet(score1, score2)
  
    if math.min(score1, score2) >= 7 then
        return false
    end
    
    if math.min(score1, score2) >= 5 then
        return math.max(score1, score2) == 7
    end
    
    return math.max(score1, score2) == 6
end
