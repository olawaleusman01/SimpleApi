namespace SimpleApi.Test;
using SimpleApi.Controllers;
public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetWeatherForecastCountMustBe5()
    {
        var returnValue = controller.Get();

        Assert.Equal(returnValue.Count(), 4);
    }
    [Fact]
    public void Test1()
    {

    }
}