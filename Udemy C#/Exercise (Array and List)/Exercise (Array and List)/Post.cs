using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__Array_and_List_
{
    public class Post
    {
        public List<string> likers = new List<string>();

        bool stop = false;
        public void Write()
        {
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
                    likers.Add(name);
                }
            }
            if (likers.Count == 1)
            {
                Console.WriteLine(likers[0] + " likes your post");
            }
            else if (likers.Count == 2)
            {
                Console.WriteLine(likers[0] + " and " + likers[1] + " likes your post");
            }
            else if (likers.Count > 2)
            {
                var other = likers.Count - 2;
                Console.WriteLine(likers[0] + ", " + likers[1] + " and " + other + " likes your post");
            }

        }
    }
}
