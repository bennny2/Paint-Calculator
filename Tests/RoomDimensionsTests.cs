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
        Assert.Equal(expectedFloorArea, ouputtedArea);
    }

    [Fact]
    public void CalculatorTests_CalculateRoomVolumeWithValidInput_ReturnExpected() {

        //Assign
        double floorArea = 100.0;
        double height = 40.0;
        double expectedRoomVolume = 4000.0;

        //Act
        double ouputtedVolume = calculator.CalculateRoomVolume(floorArea, height); 

        //Assert
        Assert.Equal(expectedRoomVolume, ouputtedVolume);
    }

    [Fact]
    public void CalculatorTests_CalculatePaintNeededWithValidInputCeilingIncluded_ReturnExpected() {

        //Assign
        bool ceilingIncluded = false;
        double width = 20.0;
        double length = 15.0;
        double floorArea = 300.0;
        double height = 40.0;
        double expectedPaintNeeded = 3100.0;

        //Act
        double ouputtedVolume = calculator.CalculatePaintNeeded(floorArea, width, length, height, ceilingIncluded);  

        //Assert
        Assert.Equal(expectedPaintNeeded, ouputtedVolume);
    }

    [Fact]
    public void CalculatorTests_CalculatePaintNeededWithValidInputCeilingNotIncluded_ReturnExpected() {

        //Assign
        bool ceilingIncluded = false;
        double width = 20.0;
        double length = 15.0;
        double floorArea = 300.0;
        double height = 40.0;
        double expectedPaintNeeded = 2800.0;

        //Act
        double ouputtedVolume = calculator.CalculatePaintNeeded(floorArea, width, length, height, ceilingIncluded); 

        //Assert
        Assert.Equal(expectedPaintNeeded, ouputtedVolume);
    }
}
