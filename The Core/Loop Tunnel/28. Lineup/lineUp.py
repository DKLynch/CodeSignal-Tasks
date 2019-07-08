def lineUp(commands):
    matching = True
    counter = 0
    
    for x in list(commands):
        if (x == 'L' or x == 'R') and matching == True:
            matching = False
        elif (x == 'L' or x == 'R') and matching == False:
            matching = True
            counter += 1
        elif (x == 'A'):
            if matching == True:
                counter += 1
    
    return counter
