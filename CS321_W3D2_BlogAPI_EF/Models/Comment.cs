using System;
namespace CS321_W3D2_BlogAPI_EF.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int PostId { get; set; }
    }
}
