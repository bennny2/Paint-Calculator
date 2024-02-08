//Variables
RoomDimensions calculator = new();
bool validWidth;
bool validHeight;
bool validLength;
bool validCeiling;

string? roomWidthInput = "";
string? roomHeightInput = "";
string? roomLengthInput = "";
string? ceilingInput = "";

double roomWidth;
double roomHeight;
double roomLength;
bool ceilingIncluded;

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
double.TryParse(roomWidthInput, out roomHeight);

//Ensure valid input
validLength = false;
while (validLength == false)
{
    Console.WriteLine("Please enter the width of the room: ");
    roomLengthInput = Console.ReadLine();
    validLength = calculator.ValidateUserInput(roomLengthInput);
}
double.TryParse(roomWidthInput, out roomLength);

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

    } else if (ceilingInput == "N") {
        ceilingIncluded = false;

    } else {
        Console.WriteLine("Invalid input, please only input 'Y' or 'N' ");
    }
}
}
