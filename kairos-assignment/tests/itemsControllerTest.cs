using ItemsApi.Controllers;
using ItemsApi.Services;
using ItemsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

public class ItemsControllerTest
{

    private readonly ItemsController _controller;
    private readonly ItemsService _service;
    public ItemsControllerTest()
    {
        _service = new ItemServiceFake();
        _controller = new ItemsController(_service);
    }

    [Fact]
    public void Add_InvalidObjectPassed_ReturnsBadRequest()
    {
        // Arrange
        var nameMissingItem = new Items()
        {
            company = "onePlus 9r"
        };
        _controller.ModelState.AddModelError("name", "Required");
        // Act
        var badResponse = _controller.Post(nameMissingItem);
        // Assert
        Xunit.Assert.IsType<BadRequestObjectResult>(badResponse);
    }


    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}

