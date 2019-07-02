def tennisSet(score1, score2):

    if min(score1, score2) >= 7:
        return False
    
    if min(score1, score2) >= 5:
        return max(score1, score2) == 7
    
    return max(score1, score2) == 6
