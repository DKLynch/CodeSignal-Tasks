function reachNextLevel(experience, threshold, reward)
    if (threshold - reward) > experience then
        return false
    else
        return true
    end
end
