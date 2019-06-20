bool isSentenceCorrect(string sentence)
{
  Regex regex = new Regex("^[A-Z][^.?!]*[.?!]$");
  return regex.IsMatch(sentence);
}
