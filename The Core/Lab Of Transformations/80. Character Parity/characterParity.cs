string characterParity(char symbol) {
    if(Char.IsDigit(symbol)){
        if(symbol%2 == 0){
            return "even";
        } else {
            return "odd";
        }
    } else {
        return "not a digit";
    }
}
