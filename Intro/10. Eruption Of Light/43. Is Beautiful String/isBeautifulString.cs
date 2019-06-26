bool isBeautifulString(string inputString) {
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    var appearances = alphabet.Select(x => inputString.Count(s => s == x));
    var orderedAppearances = appearances.OrderByDescending(x => x);
    return Enumerable.SequenceEqual(appearances, orderedAppearances);
}
