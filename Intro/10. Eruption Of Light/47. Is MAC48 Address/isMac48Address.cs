bool isMAC48Address(string inputString) {
    string pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
    return Regex.Match(inputString, pattern).Success;
}
