int[] videoPart(string part, string total) {   
    int watchedTime = timeToSeconds(part);
    int totalTime = timeToSeconds(total);
    int div = gcd(watchedTime, totalTime);
    
    return new int[]{watchedTime / div, totalTime / div};
}

int gcd(int a, int b){
    if(b == 0)
        return a;
    else
        return gcd(b, a%b);
}

int timeToSeconds(string time){
    var split = time.Split(':');
    int hoursInSeconds = int.Parse(split[0]) * 60 * 60;
    int minutesInSeconds = int.Parse(split[1]) * 60;
    int seconds = int.Parse(split[2]);
    
    return hoursInSeconds + minutesInSeconds + seconds;    
}
