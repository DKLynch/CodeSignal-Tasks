bool validTime(string time) {
    var digits = time.Split(':').Select(x => int.Parse(x)).ToList();
    if(digits[0] >= 24 || digits[1] >= 60) return false;
    return true;
}
