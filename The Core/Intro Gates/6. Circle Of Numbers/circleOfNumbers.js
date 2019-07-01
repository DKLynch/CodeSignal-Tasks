function circleOfNumbers(n, firstNumber) {
    var numArr = new Array();

    for(i = 0; i < n; i++){
        numArr.push(i);
    }
    
    if(firstNumber < n/2) return numArr[firstNumber + n/2];    
    else return numArr[firstNumber - n/2];     
}
