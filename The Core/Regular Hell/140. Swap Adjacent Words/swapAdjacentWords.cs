string swapAdjacentWords(string s) {
  return Regex.Replace(s, "([a-zA-Z]+) ([a-zA-Z]+)", "$2 $1");
}
