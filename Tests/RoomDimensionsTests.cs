using Xunit;

namespace RoomDimensionsCalculator.Tests;

public class RoomDimensionsTests
{
    [Fact]
    public void CalculatorTests_CalculateFloorAreaWithValidInput_ReturnExpected() {

        //Assign
        double width = 10.0;
        double length = 18.0;
        double expectedFloorArea = 180.0;
        RoomDimensions calculator = new();

        //Act
        double ouputtedArea = calculator.CalculateFloorArea(width, length); 

        //Assert
        Assert.Equal(ouputtedArea, expectedFloorArea);
    }
}
