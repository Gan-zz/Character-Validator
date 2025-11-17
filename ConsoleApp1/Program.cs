//Program to validate characters
//Aodhan Sim
//04/11/2025

//variables for each roll and bonus
int strenght = 0;
int intelligence = 0;
int strengthBonus = 0;
int intelligenceBonus = 0;

//welcome the user
Console.WriteLine("Welcome to the Character Validator!");

// get strenght from user and set strenght to input
Console.WriteLine("Please enter the character's strenght:");
strenght = Convert.ToInt32(Console.ReadLine());

// get intelligence from user and set intelligence to input
Console.WriteLine("Please enter the character's intelligence:");
intelligence = Convert.ToInt32(Console.ReadLine());

// set strenght bonus and print to user
strengthBonus = (strenght - 10)/2;
Console.WriteLine("Strenght bonus: " + strengthBonus);

// set intelligence bonus and print to user
intelligenceBonus = (intelligence - 10)/2;
Console.WriteLine("Intelligence bonus: " + intelligenceBonus);

if (strengthBonus < 4)
{
    Console.WriteLine("Your character does not qualify as a Warrior!");
}
else
{
    Console.WriteLine("Your character does qualify as a Warrior!");
}

if (intelligenceBonus < 4)
{
    Console.WriteLine("Your character does not qualify as a Mage!");
}
else
{
    Console.WriteLine("Your character does qualify as a Mage!");
}

