using BookStoreCart;

namespace BookStoreCartTests;

public class CartTests
{
    Cart classUnderTest;
    
    [SetUp]
    public void Setup()
    {
        classUnderTest = new Cart();
    }
    
    [Test]
    public void One_book_one_costs_8()
    {
        var result = classUnderTest.CalculateCost(new []
        {
            1
        });
        
        Assert.AreEqual(8m, result);
    }
    
    
    
    [Test]
    public void One_book_one_costs_16()
    {
        var result = classUnderTest.CalculateCost(new []
        {
            1,
            1
        });
        
        Assert.AreEqual(16m, result);
    }
}