using Stackup.Api.Service;
namespace Stackup.Api.Test;


public class WeatherServiceTest
{

    IWeatherService serviceToTest;
    [SetUp]

    public void Setup()
    {
        serviceToTest = new WeatherService();
    }

    [Test]
    public void WhenCalled_ReturnWeather()
    {
        var result = serviceToTest.GetWeather();
        int count = result.Count();
        Assert.AreEqual(count,5);
        Assert.Pass();
    }
}