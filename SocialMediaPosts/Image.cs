using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    // image post derives from Post and adds a property imageurl and two constructors
    class Image: Post
    {
        public string ImageUrl { get; set; }

        public Image() { }

        public Image(string title, string sendByUsername, string imageUrl, bool isPublic)
        {
            // Properties and the GetNextID method inherited from post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            
            this.IsPublic = isPublic;

            // Member property but not of Post
            this.ImageUrl = imageUrl;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageUrl, this.SendByUsername);
        }


    }
}
