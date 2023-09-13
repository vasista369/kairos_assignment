using ItemsApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

//[Fact]
public void Add_InvalidObjectPassed_ReturnsBadRequest()
{
    // Arrangeß
    var nameMissingItem = new Item()
    {
        name = "onePlus  ",
        company = "onePlus 9r"
    };
    ItemsController.ModelState.AddModelError("Name", "Required");
    // Act
    var badResponse = ItemsController.Post(nameMissingItem);
    // Assert
    Assert.IsType<BadRequestObjectResult>(badResponse);
}

