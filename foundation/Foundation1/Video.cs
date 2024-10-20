public class Video 
{
    public string _title;
    public string _author;
    public double _lenght;
    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        int comments = 0;

        foreach(Comment comment in _comments)
        {
            comments++;
        }

        return comments;

    }

    public Video(string title, string author, double lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public string DisplayVideoInfo()
    {
        return $"{_title} - {_author} \n Lenght: {_lenght} seconds";

    }

    public double TimeInSeconds (int option)
    {

        if (option == 1) // hours
        {
            return  (double)_lenght * (double)3600;
        }

        else if (option == 2) // minutes
        {
            return (double) _lenght * (double) 60;

        }

        else 
        {
            return _lenght;
        }
        
    }

}

