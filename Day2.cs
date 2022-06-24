// See https://aka.ms/new-console-template for more information
// 1st exercise

string heroName = "Batman";
int heroPower = 100;
string villanName = "Joker";
int villanPower = 200;

if (heroPower == villanPower)
{
    Console.WriteLine("Both have same power");
}
else if (heroPower > villanPower)
{
    Console.WriteLine($"{heroName} has more power than {villanName}");
}
else
{
    Console.WriteLine($"{villanName} has more power than {heroName}");
}

// 2nd exercise
float playerSpeed = 3.5f;
void setSpeed(float speed)
{   Console.WriteLine($"Old speed: {playerSpeed}");
    playerSpeed = speed;
    Console.WriteLine($"New speed: {playerSpeed}");
}
setSpeed(2.5f);

// Bonus exercise
void compareSpeed(float oldSpeed, float newSpeed) {
    if (oldSpeed  == newSpeed) {
        Console.WriteLine($"Old Speed: {oldSpeed}, New Speed {newSpeed}");
    }else if (oldSpeed > newSpeed) {
        Console.WriteLine($"{oldSpeed} is faster");
    } else {
        Console.WriteLine($"{newSpeed} is faster");
    }
}
compareSpeed(3.5f, 2.5f);