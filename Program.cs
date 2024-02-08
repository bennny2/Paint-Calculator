//Variables
RoomDimensions calculator = new();
bool validWidth;
bool validHeight;
bool validLength;

string? roomWidthInput = "";
string? roomHeightInput = "";
string? roomLengthInput = "";

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


}
