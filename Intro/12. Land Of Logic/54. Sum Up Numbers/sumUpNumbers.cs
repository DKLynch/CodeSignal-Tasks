int sumUpNumbers(string inputString) {
    string pattern = @"[0-9]+";
    var numbers = Regex.Matches(inputString, pattern).Select(x => int.Parse(x.ToString())).ToList();
    return numbers.Sum();
}
