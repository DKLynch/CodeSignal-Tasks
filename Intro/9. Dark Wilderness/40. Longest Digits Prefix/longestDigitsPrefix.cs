string longestDigitsPrefix(string inputString) {
    string pattern = @"^(\d+)";
    string numbers = Regex.Match(inputString, pattern).Value;
    return numbers;
}
