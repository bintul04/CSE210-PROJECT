public class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }
}
