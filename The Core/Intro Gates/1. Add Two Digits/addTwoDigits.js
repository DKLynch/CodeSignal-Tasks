function addTwoDigits(n) {
    var sum = 0;
    var c = n.toString().split('');
    
    c.forEach(function(char){
       sum += parseInt(char);       
    });
    
    return sum;
}
