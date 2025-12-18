using System;

namespace TASK2;

public class Post
{

private string Title;
private string Description;
private int LikeCount=1;
private string Comments;
public bool IsPublished=false;


public string TITLE
    {
        get;
        set;
    }

public string DESCRIPTION
    {
        get;
        set;
    }


public string COMMENTS
    {
        get;
        set;
    }

public void Publish()
    {
        IsPublished=true;
        System.Console.WriteLine("The post is published!");
    }
public void Like()
    {
        LikeCount++;
    }    
public int LIKECOUNT
    {
        get;
    }    

List<string> messages = new List<string>();

public void AddComment(string message)
    {
        messages.Add(message);
    }


}
