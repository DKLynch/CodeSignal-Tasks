string[] allLongestStrings(string[] inputArray) {
    int maxLength = inputArray.OrderByDescending(s => s.Length).First().Length;
    var newStrings = inputArray.Where(s => s.Length == maxLength);
    return newStrings.ToArray();
}
