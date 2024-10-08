using Moq;
using MyCrudApp.Models;
using MyCrudApp.Repositories;
using MyCrudApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class EntityServiceTests
{
    private readonly Mock<IEntityRepository> _repositoryMock;
    private readonly EntityService _service;

    public EntityServiceTests()
    {
        _repositoryMock = new Mock<IEntityRepository>();
        _service = new EntityService(_repositoryMock.Object);
    }

    [Fact]
    public async Task GetAllEntitiesAsync_ShouldReturnEntities()
    {
        var entities = new List<Entity> { new Entity { Id = "1", Name = "Test" } };
        _repositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(entities);

        var result = await _service.GetAllEntitiesAsync();

        Assert.Equal(entities, result);
    }
}
