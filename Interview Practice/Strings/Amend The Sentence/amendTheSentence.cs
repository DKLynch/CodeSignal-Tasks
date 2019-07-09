string amendTheSentence(string s) {
    string pattern = @"([A-Z])";
    return Regex.Replace(s, pattern, " $1").TrimStart(' ').ToLower();
}
