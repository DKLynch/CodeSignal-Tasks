char firstDigit(string inputString) {
    return inputString.Where(x => char.IsDigit(x)).First();
}
