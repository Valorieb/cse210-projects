public class Reference{
// Keeps track of the book, chapter, and verse information.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayTextSingle(){
            return($"{_book} {_chapter}:{_verse}");
        }
    public string GetDisplayTextMultiple(){
        return($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }
    public string GetDisplayText(){
        if(_endVerse == 0){
            return($"\n{_book} {_chapter}:{_verse}");
        }else{
            return($"\n{_book} {_chapter}:{_verse}-{_endVerse}");
        }
    }
}
