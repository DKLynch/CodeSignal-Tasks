int minimalNumberOfCoins(int[] coins, int price) {
    int noCoins = 0;
    int newPrice = price;
    for(int i = coins.Length - 1; i >= 0; i--){
        noCoins += newPrice/coins[i];
        newPrice %= coins[i];
    }
    return noCoins;
}
