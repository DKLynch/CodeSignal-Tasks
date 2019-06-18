string htmlEndTagByStartTag(string startTag) {
    string tag = "";
    
    if(startTag.Contains(' ')){
        var splits = startTag.Split(' ');
        tag = splits[0].TrimStart('<');
    } else {
        tag = startTag.TrimStart('<').TrimEnd('>');
    }
        
    return new string("</" + tag +">");
}
