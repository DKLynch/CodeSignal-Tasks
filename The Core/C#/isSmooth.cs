bool isSmooth(int[] arr) {
    bool result = false;
    
    if(arr[0] == arr[arr.Length - 1]){
        if(arr.Length % 2 == 0){
            if(arr[arr.Length/2 - 1] + arr[arr.Length/2] == arr[0]){
                result = true;
            }
        } else {
            if(arr[(int)Math.Floor((decimal)arr.Length/2)] == arr[0]){
                result = true;
            }
        }
    }
    
    return result;
}
