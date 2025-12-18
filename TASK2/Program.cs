
using TASK2;

Post post=new Post();
System.Console.WriteLine("Nash post : ");
string post1="SMM";
post.TITLE=post1;
string desc1="is method for optimeze";
post.DESCRIPTION=desc1;
post.Like();
post.Like();
post.Like();
post.Like();
post.Like();
post.Like();


string com1="Good";
string com2="Vpered!!";
post.AddComment(com1);
post.AddComment(com2);
post.Publish();

System.Console.WriteLine($"{post1} - {desc1} - Number of Likes: {post.LIKECOUNT}");
