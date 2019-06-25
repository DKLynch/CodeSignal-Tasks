bool chessBoardCellColor(string cell1, string cell2) {
    var a = Convert.ToUInt32(cell1[0]) + Convert.ToUInt32(cell1[1]);
    var b = Convert.ToUInt32(cell2[0]) + Convert.ToUInt32(cell2[1]);
    return a % 2 == b % 2;
}
