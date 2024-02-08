using Xunit;

namespace RoomDimensionsCalculator.Tests;

public class RoomDimensionsTests
{
    RoomDimensions calculator = new();

    [Fact]
    public void CalculatorTests_CalculateFloorAreaWithValidInput_ReturnExpected() {

        //Assign
        double width = 10.0;
        double length = 18.0;
        double expectedFloorArea = 180.0;

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

        //Act
        double ouputtedVolume = calculator.CalculateRoomVolume(floorArea, height); 

        //Assert
        Assert.Equal(ouputtedVolume, expectedRoomVolume);
    }

    [Fact]
    public void CalculatorTests_CalculatePaintNeededWithValidInputCeilingIncluded_ReturnExpected() {

        //Assign
        bool ceilingIncluded = false;
        double width = 20.0;
        double length = 15.0;
        double height = 40.0;
        double expectedPaintNeeded = 3100.0;

        //Act
        double ouputtedVolume = calculator.CalculatePaintNeeded(width, length, height, ceilingIncluded);  

        //Assert
        Assert.Equal(ouputtedVolume, expectedPaintNeeded);
    }

    [Fact]
    public void CalculatorTests_CalculatePaintNeededWithValidInputCeilingNotIncluded_ReturnExpected() {

        //Assign
        bool ceilingIncluded = false;
        double width = 20.0;
        double length = 15.0;
        double height = 40.0;
        double expectedPaintNeeded = 2800.0;

        //Act
        double ouputtedVolume = calculator.CalculatePaintNeeded(width, length, height, ceilingIncluded); 

        //Assert
        Assert.Equal(ouputtedVolume, expectedPaintNeeded);
    }
}
