using System;
using System.Collections.Generic;
using CS321_W3D2_BlogAPI_EF.Models;

namespace CS321_W3D2_BlogAPI_EF.Services
{
    public interface IPostService
    {
        IEnumerable<Post> GetAll();
        Post Get(int id);
        Post Add(Post post);
        Post Update(Post post);
        void Remove(Post post);
    }
}
