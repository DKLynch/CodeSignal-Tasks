double companyBotStrategy(int[][] trainingData) {
    List<int> answerTimes = new List<int>();
    
    foreach(int[] answer in trainingData){
        if(answer[1] == 1){
            answerTimes.Add(answer[0]);
        }
    }
    
    if(answerTimes.Count() == 0)
        return 0;
    else
        return (double)answerTimes.Sum() / answerTimes.Count();
}
