bool isIPv4Address(string inputString) {
    string pattern = @"^((?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
    return Regex.Match(inputString, pattern).Success;
}
