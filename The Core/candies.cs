int candies(int n, int m) {
    double result = m/n;
    return Convert.ToInt32(Math.Floor(result)) * n;
}
