string findEmailDomain(string address) {
    var stringSplits = address.Split('@');
    return stringSplits[stringSplits.Length - 1];
}
