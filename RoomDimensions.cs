public class RoomDimensions
{
    //Methods

    public double CalculateFloorArea(double roomWidth, double roomLength) {
        return roomWidth * roomLength;
    }

    public double CalculateRoomVolume(double floorArea, double roomHeight) {
        return floorArea * roomHeight;
    }

    public double CalculatePaintNeeded(double floorArea, double roomWidth, double roomLength, double roomHeight, bool ceilingIncluded) {

        //Equation to find the surface area of a cuboid
        double paintNeeded = 2 * ((roomWidth * roomLength) + (roomWidth * roomHeight) + (roomLength * roomHeight));

        //Remove one floorArea worth as the floor likely wont be painted
        paintNeeded -= floorArea;

        //Check whether the Ceiling is being painted
        if (!ceilingIncluded) {
            paintNeeded -= floorArea;
        }
        
        return paintNeeded;
    }
}
