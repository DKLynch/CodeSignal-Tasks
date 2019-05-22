bool checkPalindrome(string inputString) {

    var sArr = inputString.ToCharArray();
    Array.Reverse(sArr);
    var revString = new string(sArr);
    
    if(revString == inputString){
        return true;
    }
	
    return false;
}
