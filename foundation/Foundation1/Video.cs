using System.Collections.Generic;

public class Video 
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return Comments.Count;
    }

   public string DisplayVideoInfo()
   {
    return _title + " - " + _author + "\nLength: " + _length + " seconds";
    
    }


    public double TimeInSeconds(int option)
    {
        if (option == 1) // horas
        {
            return _length * 3600;
        }
        else if (option == 2) // minutos
        {
            return _length * 60;
        }
        else 
        {
            return _length; // segundos
        }
    }
}
