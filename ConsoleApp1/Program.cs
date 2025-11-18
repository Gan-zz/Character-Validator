//Program to validate characters
//Aodhan Sim
//04/11/2025

//variables for each roll and bonus
int strenght = 0;
int intelligence = 0;
int charisma = 0;
int constitution = 0;
int wisdom = 0;
int dexterity = 0;

int strengthBonus = 0;
int intelligenceBonus = 0;
int charismaBonus = 0;
int constitutionBonus = 0;
int wisdomBonus = 0;
int dexterityBonus = 0;

string may = "";
bool mayhaps = true;


//welcome the user

Console.WriteLine("Welcome to the Character Validator!");
while (mayhaps != false)
{
    // get strenght from user and set strenght to input
    Console.WriteLine("Please enter the character's strenght:");
    strenght = Convert.ToInt32(Console.ReadLine());
    while (strenght > 20 || strenght < 1)
    {
        Console.WriteLine("Strength score invalid. It must be between 1 and 20. Please try again:");
        strenght = Convert.ToInt32(Console.ReadLine());
    }

    // get intelligence from user and set intelligence to input
    Console.WriteLine("Please enter the character's intelligence:");
    intelligence = Convert.ToInt32(Console.ReadLine());
    while (intelligence > 20 || intelligence < 1)
    {
        Console.WriteLine("Intelligence score invalid. It must be between 1 and 20. Please try again:");
        intelligence = Convert.ToInt32(Console.ReadLine());
    }

    // get charisma from user and set charisma to input
    Console.WriteLine("Please enter the character's charisma:");
    charisma = Convert.ToInt32(Console.ReadLine());
    while (charisma > 20 || charisma < 1)
    {
        Console.WriteLine("Charisma score invalid. It must be between 1 and 20. Please try again:");
        charisma = Convert.ToInt32(Console.ReadLine());
    }

    // get constitution from user and set constitution to input
    Console.WriteLine("Please enter the character's constitution:");
    constitution = Convert.ToInt32(Console.ReadLine());
    while (constitution > 20 || constitution < 1)
    {
        Console.WriteLine("Constitution score invalid. It must be between 1 and 20. Please try again:");
        constitution = Convert.ToInt32(Console.ReadLine());
    }

    // get wisdom from user and set wisdom to input
    Console.WriteLine("Please enter the character's wisdom:");
    wisdom = Convert.ToInt32(Console.ReadLine());
    while (wisdom > 20 || wisdom < 1)
    {
        Console.WriteLine("Wisdom score invalid. It must be between 1 and 20. Please try again:");
        wisdom = Convert.ToInt32(Console.ReadLine());
    }

    // get dexterity from user and set dexterity to input
    Console.WriteLine("Please enter the character's dexterity:");
    dexterity = Convert.ToInt32(Console.ReadLine());
    while (dexterity > 20 || dexterity < 1)
    {
        Console.WriteLine("Dexterity score invalid. It must be between 1 and 20. Please try again:");
        dexterity = Convert.ToInt32(Console.ReadLine());
    }


    // set strenght bonus and print to user
    strengthBonus = (strenght - 10) / 2;
    Console.WriteLine("Strenght bonus: " + strengthBonus);

    // set intelligence bonus and print to user
    intelligenceBonus = (intelligence - 10) / 2;
    Console.WriteLine("Intelligence bonus: " + intelligenceBonus);

    // set charisma bonus and print to user
    charismaBonus = (charisma - 10) / 2;
    Console.WriteLine("Charisma bonus: " + charismaBonus);

    // set constitution bonus and print to user
    constitutionBonus = (constitution - 10) / 2;
    Console.WriteLine("Constitution bonus: " + constitutionBonus);

    // set wisdom bonus and print to user
    wisdomBonus = (wisdom - 10) / 2;
    Console.WriteLine("Wisdom bonus: " + wisdomBonus);

    // set dexterity bonus and print to user
    dexterityBonus = (dexterity - 10) / 2;
    Console.WriteLine("Dexterity bonus: " + dexterityBonus);

    if (strengthBonus >= 1)
    {
        Console.WriteLine("Your character does qualify as a Warrior!");
    }

    if (intelligenceBonus >= 1)
    {
        Console.WriteLine("Your character does qualify as a Mage!");
    }

    if (charismaBonus >= 1)
    {
        Console.WriteLine("Your character does qualify as a Bard!");
    }

    if (constitutionBonus >= 1)
    {
        Console.WriteLine("Your character does qualify as a Cleric!");
    }

    if (wisdomBonus >= 1)
    {
        Console.WriteLine("Your character does qualify as a Druid!");
    }

    if (dexterityBonus >= 1)
    {
        Console.WriteLine("Your character does qualify as a Rogue!");
    }

    if (strengthBonus < 1 && intelligenceBonus < 1 && charismaBonus < 1 && constitutionBonus < 1 && wisdomBonus < 1 && dexterityBonus < 1)
    {
        Console.WriteLine("Your character does not qualify for any class");
    }

    Console.WriteLine("\nWould you like to start again(y/n)?");
    may = Console.ReadLine();
    if (may == "y")
    {
        mayhaps = true;
    }
    else
    {
        mayhaps = false;
    }
}