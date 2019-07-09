bool validTime(string time) {
    var split = time.Split(':');
    
    if(int.Parse(split[0]) >= 24 || int.Parse(split[1]) >= 60) 
        return false;
    
    return true;
}
