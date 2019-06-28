//Note: This passes 12/14 of the tests, currently struggling to debug why it's tripping up on the hidden ones.
//      Will hopefully return to this at a later date and iron out the kinks.

string htmlTable(string table, int row, int column) {
    string pattern = @"<\s*td[^>]*>(.*?)</\s*td>";
    string pattern2 = @"<\s*th[^>]*>(.*?</\s*th)";
    
    var rows = Regex.Matches(table, "<tr>").ToList();
    int noRows = rows.Count();
    var columns = Regex.Matches(table, "<td>").ToList();
    int noColumns = columns.Count() / noRows;
   
    var raw = Regex.Matches(table, pattern).Select(x => x.ToString()).ToList();
    var raw2 = Regex.Matches(table, pattern2).Select(x => x.ToString()).ToList();
    List<string> cells = new List<string>();
    
    foreach(string s in raw2){
        cells.Add(s);
    }
    
    foreach(string s in raw){
        cells.Add(s);
    }
    
    int index = (row * noColumns) + column;
    
    if(index >= cells.Count() || cells[index].Contains("<th>")){
        return "No such cell";
    }
    else {
        return cells[index].Replace("<td>", "").Replace("</td>", "");
    }
}
