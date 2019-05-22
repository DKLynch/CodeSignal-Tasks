int lateRide(int n) {
    
    DateTime time = DateTime.Parse("02/22/2019 00:00:00");
    double conv = Convert.ToDouble(n);
    DateTime newTime = time.AddMinutes(conv);
    
    string timeStr = newTime.ToString("HH:mm");
    Console.Write(timeStr);
    var strArr = timeStr.ToCharArray();
    
    int result = 0;   
    foreach(char c in strArr){
        if(int.TryParse(c.ToString(), out int res)){
            result += res;
        }
    }
    
    return result;
}
