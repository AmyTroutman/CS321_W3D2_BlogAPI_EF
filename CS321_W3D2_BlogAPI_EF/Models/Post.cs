using System;
using System.Collections.Generic;

namespace CS321_W3D2_BlogAPI_EF.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
