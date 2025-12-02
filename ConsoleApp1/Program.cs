//Program to validate characters
//Aodhan Sim
//04/11/2025

//variables for each roll and bonus
int strength = 0;
int intelligence = 0;
int strengthBonus = 0;
int intelligenceBonus = 0;
bool intelligenceValid = false;
bool strengthValid = false;

//welcome the user
Console.WriteLine("Welcome to the Character Validator!");

// get strenght from user and set strength to input
Console.WriteLine("Please enter the character's strength:");
strength = Convert.ToInt32(Console.ReadLine());
strengthValid = strength >= 1 && strength <= 20;
while (strengthValid == false)
{
    Console.WriteLine("Strength score invalid. It must be between 1 and 20. Please try again:");
    strength = Convert.ToInt32(Console.ReadLine());
    strengthValid = strength >= 1 && strength <= 20;
}

// get intelligence from user and set intelligence to input
Console.WriteLine("Please enter the character's intelligence:");
intelligence = Convert.ToInt32(Console.ReadLine());
intelligenceValid = intelligence >= 1 && intelligence <= 20;

while (intelligenceValid == false)
{
    Console.WriteLine("Intelligence score invalid. It must be between 1 and 20. Please try again:");
    intelligence = Convert.ToInt32(Console.ReadLine());
    intelligenceValid = intelligence >= 1 && intelligence <= 20;
}

// set strenght bonus and print to user
strengthBonus = (strength - 10) / 2;
Console.WriteLine("Strength bonus: " + strengthBonus);

// set intelligence bonus and print to user
intelligenceBonus = (intelligence - 10) / 2;
Console.WriteLine("Intelligence bonus: " + intelligenceBonus);


if (strengthBonus >= 1)
{
    Console.WriteLine("Your character does qualify as a Warrior!");
}

if (intelligenceBonus >= 1)
{
    Console.WriteLine("Your character does qualify as a Mage!");
}


if (strengthBonus < 1 && intelligenceBonus < 1)
{
    Console.WriteLine("Your character does not qualify for any class");
}
