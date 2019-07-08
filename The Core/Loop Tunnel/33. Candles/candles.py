def candles(candlesNumber, makeNew):
    candles = candlesNumber
    leftovers = 0
    candlesBurned = 0
    
    while candles > 0:
        candles -= 1
        leftovers += 1
        candlesBurned +=1
        
    while leftovers >= makeNew:
        leftovers -= makeNew
        candles += 1
        candlesBurned += 1
        leftovers += 1
    
    return candlesBurned
