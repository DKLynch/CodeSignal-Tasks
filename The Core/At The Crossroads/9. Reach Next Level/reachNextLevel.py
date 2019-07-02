def reachNextLevel(experience, threshold, reward):  
    if (threshold - reward) > experience:
        return False
    else:
        return True
