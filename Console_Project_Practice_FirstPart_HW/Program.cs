

using Console_Project_Practice_FirstPart_HW.Controllers;
using ServiceLayer.Helpers;

while (true)
{
    try
    {
        LibraryController library = new();
        ConsoleColor.Yellow.WriteConsole("Select one option: ");
        ConsoleColor.Yellow.WriteConsole("Library options: 1 - Creat, 2 - Get By ID, 3- Delete");

        Option: string option = Console.ReadLine();

        int newOption;

        bool isParseOption = int.TryParse(option, out newOption);

        if (isParseOption)
        {
            switch (newOption)
            {
                case 1:
                    library.Create();
                    break;
                case 2:
                    library.GetById();
                    break;
                case 3:
                    ConsoleColor.Yellow.WriteConsole("3"); ;
                    break;
                default:
                    break;
            }
        }
        else
        {
            ConsoleColor.Red.WriteConsole("Select again true option: ");
            goto Option;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}