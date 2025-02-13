public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string _getTitle()
    {
        return _title;
    }
    public string _getAuthor()
    {
        return _author;
    }
    public int _getLength()
    {
        return _length;
    }
    public List<Comment> _getComments()
    {
        return _comments;
    }
}