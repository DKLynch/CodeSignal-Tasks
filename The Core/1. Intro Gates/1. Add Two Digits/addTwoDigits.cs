int addTwoDigits(int n) {
    string num = n.ToString();
    var digits = num.ToCharArray();

    int result = int.Parse(digits[0].ToString()) + int.Parse(digits[1].ToString());
    return result;
}
