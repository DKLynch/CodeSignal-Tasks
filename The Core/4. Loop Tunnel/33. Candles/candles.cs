int candles(int candlesNumber, int makeNew) {
    int candles = candlesNumber;
    int leftovers = 0;
    int totalCandlesBurned = 0;
    
    while (candles > 0){
        candles -= 1;
        leftovers += 1;
        totalCandlesBurned += 1;
    }

    while (leftovers >= makeNew){
        leftovers -= makeNew;
        candles += 1;
        totalCandlesBurned += 1;
        leftovers += 1;
    }
   
    return totalCandlesBurned;
}
