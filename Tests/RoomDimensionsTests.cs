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

    [Fact]
    public void CalculatorTests_CalculateRoomVolumeWithValidInput_ReturnExpected() {

        //Assign
        double floorArea = 100.0;
        double height = 40.0;
        double expectedRoomVolume = 400.0;
        RoomDimensions calculator = new();

        //Act
        double ouputtedVolume = calculator.CalculateRoomVolume(floorArea, height); 

        //Assert
        Assert.Equal(ouputtedVolume, expectedRoomVolume);
    }
}
