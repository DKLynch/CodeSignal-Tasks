def makeArrayConsecutive2(statues):
    noStatuesNeeded = 0
    statues.sort()
    
    for x in range(0, len(statues) - 1):
        num = statues[x + 1] - statues[x]
        noStatuesNeeded += num - 1
        
    return noStatuesNeeded

#
#def makeArrayConsecutive2(statues):
#	return sum([1 for i in range(min(statues), max(statues)) if i not in statues])
