using Moq;
using MyCrudApp.Controllers;
using MyCrudApp.Models;
using MyCrudApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class EntitiesControllerTests
{
    private readonly Mock<EntityService> _serviceMock;
    private readonly EntitiesController _controller;

    public EntitiesControllerTests()
    {
        _serviceMock = new Mock<EntityService>();
       
    }
}