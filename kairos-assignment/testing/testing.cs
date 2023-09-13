using ItemsApi.Controllers;
using ItemsApi.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;


public class ShoppingCartControllerTest
{

    private readonly ItemsController _controller;
    private readonly ItemsService _service;
    public ShoppingCartControllerTest()
    {
        _service = new ItemCartServiceFake();
        _controller = new ItemsController(_service);
    }

    [Fact]
    public void Add_InvalidObjectPassed_ReturnsBadRequest()
    {
        // Arrange
        var nameMissingItem = new Item()
        {
            name = "onePlus  ",
            company = "onePlus 9r"
        };
        _controller.ModelState.AddModelError("Name", "Required");
        // Act
        var badResponse = _controller.Post(nameMissingItem);
        // Assert
        Assert.IsType<BadRequestObjectResult>(badResponse);
    }
}

