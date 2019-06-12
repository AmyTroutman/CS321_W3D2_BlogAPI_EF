using System;
using Xunit;
using CS321_W3D2_BlogAPI_EF.Controllers;
using CS321_W3D2_BlogAPI_EF.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS321_W3D2_BlogAPI_EF.Tests
{
    public class PostsControllerTests
    {
        [Fact]
        public void Get_ReturnsNotFound()
        {
            // Ensure that Get(id) returns NotFound status code if
            // the requested Post does not exist

            // arrange
            var controller = new PostsController(new PostService());

            // act - id 999 should not exist
            var result = controller.Get(999);

            // assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Get_ReturnsOk()
        {
            // Ensure that Get(id) returns Ok status if Post exists

            // arrange
            var controller = new PostsController(new PostService());

            // act - id 2 is in the seed data, should exist
            var result = controller.Get(2);

            // assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
