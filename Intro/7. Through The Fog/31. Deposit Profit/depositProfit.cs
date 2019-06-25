int depositProfit(int deposit, int rate, int threshold) {
    float balance = deposit;
    int years = 0;

    while(balance < threshold){
        float interest = (float)((balance / 100) * rate);
        balance = balance + interest;
        years += 1;
    }

    return years;
}
