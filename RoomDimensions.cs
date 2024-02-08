public class RoomDimensions
{
    //Fields

    private double floorArea;
    private double roomVolume;
   

    //Methods

    private static double CalculateFloorArea(double roomWidth, double roomLength) {
        return roomWidth * roomLength;
    }
}
