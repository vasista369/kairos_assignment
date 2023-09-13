using System;
using ItemsApi.Controllers;
using ItemsApi.Services;
using ItemsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace XUnitTestProject1
{
    public class PassTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
    }

    public class FailTest
    {
        [Fact]
        public void Test1()
        {
            Assert.False(false);
        }
    }
}

//public class ItemsControllerTest
//{

//    private readonly ItemsController _controller;
//    private readonly ItemsService _service;
//    public ItemsControllerTest()
//    {
//        _service = new ItemServiceFake();
//        _controller = new ItemsController(_service);
//    }

//    [Fact]
//    public async void Add_InvalidObjectPassed_ReturnsBadRequest()
//    {
//        // Arrange
//        var nameMissingItem = new Items()
//        {
//            company = "onePlus 9r"
//        };
//        _controller.ModelState.AddModelError("name", "Required");
//        // Act
//        var badResponse = await _controller.Post(nameMissingItem);

//        // Assert
//        Xunit.Assert.IsType<BadRequestObjectResult>(badResponse);
//    }
//}

