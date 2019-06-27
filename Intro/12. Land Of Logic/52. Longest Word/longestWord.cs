string longestWord(string text) {
    string pattern = @"(\b[a-zA-Z]+\b)";
    var matches = Regex.Matches(text, pattern);
    return matches.OrderByDescending(x => x.Length).First().ToString();
}
