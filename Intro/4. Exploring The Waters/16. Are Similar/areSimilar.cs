bool areSimilar(int[] a, int[] b) {
    var diffElements = a.Select((x, y) => y).Where(x => a[x] != b[x]).ToList();
    
    if(diffElements.Count == 0){
        return true;
    } else if(diffElements.Count == 2 
              && a[diffElements[0]] == b[diffElements[1]] 
              && b[diffElements[0]] == a[diffElements[1]]){
        return true;
    }
    
    return false;
}
