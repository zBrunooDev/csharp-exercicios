using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStringBuilder
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Post> Posts { get; set; }

        public void AddPost(Post post)
        {
            Posts.Add(post);
        }
        public void RemovePost(Post post) 
        { 
            Posts.Remove(post); 
        }

    }
}
