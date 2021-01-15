using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User1> Instagram = new List<User1>();

            User1 UserName = new User1();
            User1 TotalViews = new User1();
            User1 Likes = new User1();
            User1 Comments = new User1();

            Instagram.Add(UserName);
            Instagram.Add(TotalViews);
            Instagram.Add(Likes);
            Instagram.Add(Comments);



            List<User1> newList = Instagram.Where(User1 => User1.Comments == "List of Comments").ToList();

            foreach (var item in newList)
            {
                Console.WriteLine("User Name: " + "Total Views: " + "Likes: " + "List of Comments: ");
            }


        }
    }
}
public class User1
{
    public string UserName { get; set; } = string.Empty;
    public string TotalViews { get; set; } 
    public string Likes { get; set; }
    public string Comments { get; set; } = string.Empty;
}

