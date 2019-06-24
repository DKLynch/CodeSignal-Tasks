bool palindromeRearranging(string inputString) {
    return inputString.GroupBy(c => c).Where(g => g.Count() % 2 == 1).Count() <= 1;
}
