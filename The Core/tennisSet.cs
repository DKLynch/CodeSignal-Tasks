bool tennisSet(int score1, int score2) 
{
    if ( Math.Min(score1, score2) >= 7 )
    {
        return false;
    }
    
    if ( Math.Min(score1, score2) >= 5 )
    {
        return Math.Max(score1, score2) == 7;
    }
    
    return Math.Max(score1, score2) == 6;
}
