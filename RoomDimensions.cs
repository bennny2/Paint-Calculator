public class RoomDimensions
{
    //Methods

    public double CalculateFloorArea(double roomWidth, double roomLength) {
        return roomWidth * roomLength;
    }

    public double CalculateRoomVolume(double floorArea, double roomHeight) {
        return floorArea * roomHeight;
    }
}
