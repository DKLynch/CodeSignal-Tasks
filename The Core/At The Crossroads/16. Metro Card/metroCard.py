def metroCard(lastNumberOfDays):
    
    if lastNumberOfDays == 28 or lastNumberOfDays == 30:
        return [31]
    elif lastNumberOfDays == 31:
        return [28, 30, 31]
    else:
        return null	
