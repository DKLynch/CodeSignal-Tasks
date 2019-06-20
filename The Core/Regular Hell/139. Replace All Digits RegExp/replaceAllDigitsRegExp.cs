string replaceAllDigitsRegExp(string input)
{
  return Regex.Replace(input, "[0-9]", "#");
}
