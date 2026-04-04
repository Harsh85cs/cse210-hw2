using System;

public class Comment
{
    private string _commentAuthor;
    private string _textComment;

    public Comment(string commentAuthor, string textComment)
    {
        _commentAuthor = commentAuthor;
        _textComment = textComment;
    }

    public string GetCommnetAuthor()
    {   
        return _commentAuthor;
    }

    public string GetTextCommnent()
    {
        return _textComment;
    }
}