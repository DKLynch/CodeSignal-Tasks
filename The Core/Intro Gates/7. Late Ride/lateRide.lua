function lateRide(n)
    hour = math.floor(n / 60)
    minutes = n % 60
    
    hoursSum = math.floor(hour / 10) + hour % 10
    minutesSum = math.floor(minutes / 10) + minutes % 10

    return hoursSum + minutesSum
end
