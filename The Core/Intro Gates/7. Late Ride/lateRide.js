function lateRide(n) {
    var hour = Math.floor(n / 60);
    var minutes = n % 60;
    
    var hoursSum = Math.floor(hour / 10) + hour % 10;
    var minutesSum = Math.floor(minutes / 10) + minutes % 10;
    
    return hoursSum + minutesSum;    
}
