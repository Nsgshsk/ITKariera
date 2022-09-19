using Family_Ex;

string[] commands;
Family family = new Family();
do
{
    commands = Console.ReadLine().Split(' ').ToArray();
    switch (commands[0])
    {
        case "Add": family.AddPerson(commands); break;
        case "Remove": family.RemovePerson(commands); break;
        case "List": Console.WriteLine(family.ToString()); break;
    }
} while (commands[0] != "Exit" && commands[0] != "exit");