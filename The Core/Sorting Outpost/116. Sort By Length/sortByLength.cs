string[] sortByLength(string[] inputArray) {
    return inputArray.OrderBy(s => s.Length).ToArray();
}
