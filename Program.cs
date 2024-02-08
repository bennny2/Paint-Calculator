//Variables
RoomDimensions calculator = new();
bool validWidth;
bool validHeight;
bool validLength;
bool validCeiling;

string? roomWidthInput = "";
string? roomHeightInput = "";
string? roomLengthInput = "";
string? ceilingInput;

double roomWidth;
double roomHeight;
double roomLength;
bool ceilingIncluded = true;

double floorArea;
double roomVolume;
double paintNeeded;

//App Loop
while (true)
{

//Ensure valid input
validWidth = false;
while (validWidth == false)
{
    Console.WriteLine("Please enter the width of the room: ");
    roomWidthInput = Console.ReadLine();
    validWidth = calculator.ValidateUserInput(roomWidthInput);
}
double.TryParse(roomWidthInput, out roomWidth);

//Ensure valid input
validHeight = false;
while (validHeight == false)
{
    Console.WriteLine("Please enter the height of the room: ");
    roomHeightInput = Console.ReadLine();
    validHeight = calculator.ValidateUserInput(roomHeightInput);
}
double.TryParse(roomHeightInput, out roomHeight);

//Ensure valid input
validLength = false;
while (validLength == false)
{
    Console.WriteLine("Please enter the width of the room: ");
    roomLengthInput = Console.ReadLine();
    validLength = calculator.ValidateUserInput(roomLengthInput);
}
double.TryParse(roomLengthInput, out roomLength);

//Ensure valid input
validCeiling = false;
while (validCeiling == false)
{
    Console.WriteLine("Do you want the ceiling painted? (Y/N) ");
    ceilingInput = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(ceilingInput)) {
        Console.WriteLine("We didn't recieve an input, please try again ");

    } else if (ceilingInput == "Y") {
        ceilingIncluded = true;
        validCeiling = true;

    } else if (ceilingInput == "N") {
        ceilingIncluded = false;
        validCeiling = true;

    } else {
        Console.WriteLine("Invalid input, please only input 'Y' or 'N' ");
    }
}

//Complete calculations needed for outputs using calculator instance of RoomDimensions Class
floorArea = calculator.CalculateFloorArea(roomWidth, roomLength);
paintNeeded = calculator.CalculatePaintNeeded(floorArea, roomWidth, roomLength, roomHeight, ceilingIncluded);
roomVolume = calculator.CalculateRoomVolume(floorArea, roomHeight);

Console.WriteLine("The area of the floor of this room in units squared is: " + floorArea);
Console.WriteLine("The surface area to be painted in units squared is: " + paintNeeded);
Console.WriteLine("The volume of this room in units cubed is: " + roomVolume);
}
