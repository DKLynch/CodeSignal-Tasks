int circleOfNumbers(int n, int firstNumber) {
    List<int> numbers = new List<int>();

    for(int i = 0; i < n; i++){
        numbers.Add(i);
    }
    
    if(firstNumber < n/2) return numbers[firstNumber + n/2];    
    else return numbers[firstNumber - n/2];
        
}
