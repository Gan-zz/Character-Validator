//Program to validate characters
//Aodhan Sim
//04/11/2025

//variables for each roll and bonus

using System.ComponentModel.Design;

int strenght = 0;
int intelligence = 0;
int strengthBonus = 0;
int intelligenceBonus = 0;

//welcome the user
Console.WriteLine("Welcome to the Character Validator!");

// get strenght from user and set strenght to input
Console.WriteLine("Please enter the character's strenght from (1,20):");
strenght = Convert.ToInt32(Console.ReadLine());
while (strenght > 20 || strenght < 1)
{
    Console.WriteLine("Roll is out of range, please enter again:");
    strenght = Convert.ToInt32(Console.ReadLine());
}

// get intelligence from user and set intelligence to input
Console.WriteLine("Please enter the character's intelligence (1,20):");
intelligence = Convert.ToInt32(Console.ReadLine());
while (intelligence > 20 || intelligence < 1)
{
    Console.WriteLine("Roll is out of range, please enter again:");
    intelligence = Convert.ToInt32(Console.ReadLine());
}

// set strenght bonus and print to user
strengthBonus = (strenght - 10)/2;
Console.WriteLine("Strenght bonus: " + strengthBonus);

// set intelligence bonus and print to user
intelligenceBonus = (intelligence - 10)/2;
Console.WriteLine("Intelligence bonus: " + intelligenceBonus);

if (strengthBonus >= 1) 
{
    Console.WriteLine("Your character does qualify as a Warrior!");
}


if (intelligenceBonus >= 1) 
{
    Console.WriteLine("Your character does qualify as a Mage!");
}


if (strengthBonus < 1 || intelligenceBonus < 1) 
{
    Console.WriteLine("Your character does not qualify for any class");
}
