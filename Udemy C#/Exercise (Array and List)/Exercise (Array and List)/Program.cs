using System;

namespace Exercise__Array_and_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            var post = new Post();
            Console.WriteLine(post);

            while (!stop)
            {
                Console.WriteLine("Input a name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    stop = true;
                }
                else
                {   
                    post.likers.Add(name);
                }
            }
            if (post.likers.Count == 1)
            {
                Console.WriteLine(post.likers[0] + " likes your post");
            }
            else if (post.likers.Count == 2)
            {
                Console.WriteLine(post.likers[0] + " and " + post.likers[1] + " likes your post");
            }
            else if(post.likers.Count > 2)
            {
                var other = post.likers.Count - 2;
                Console.WriteLine(post.likers[0] + ", " + post.likers[1] + " and " + other + " likes your post");
            }
        }
    }
}
