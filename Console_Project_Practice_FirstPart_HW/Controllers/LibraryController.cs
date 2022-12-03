using System;
using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services;

namespace Console_Project_Practice_FirstPart_HW.Controllers
{
	public class LibraryController
	{
		private readonly LibraryService _libraryService;

		public LibraryController()
		{
			_libraryService = new LibraryService();
		}

		public void Create()
		{
			ConsoleColor.DarkCyan.WriteConsole("Add library name: ");
			NameChoice: string name = Console.ReadLine();

			ConsoleColor.DarkCyan.WriteConsole("Add library seat counts: ");
			string seatCount = Console.ReadLine();
			int newSeatCount;
			bool isParse = int.TryParse(seatCount, out newSeatCount);

			if (isParse)
			{
                Library library = new()
                {
                    Name = name,
                    SeatCount = newSeatCount
                };
				var res = _libraryService.Create(library);

				ConsoleColor.Green.WriteConsole($"{res.Id} {res.Name} {res.SeatCount}");
			}
			else
			{
                ConsoleColor.Red.WriteConsole("Please, enter correct number: ") ;
				goto NameChoice;
            }
		}

		public void GetById()
		{
			try
			{
                ConsoleColor.DarkCyan.WriteConsole("Add library id: ");
                idChoice:  string libID = Console.ReadLine();
                int newLibID;
                bool isParse = int.TryParse(libID, out newLibID);

				if (isParse)
				{
					var result = _libraryService.GetById(newLibID);
					if(result is null)
					{
                        ConsoleColor.Red.WriteConsole("Library can't be found: ");
                        goto idChoice;
                    }
                    ConsoleColor.Green.WriteConsole($"{result.Id} {result.Name} {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please, enter correct id: ");
					goto idChoice;
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
        }
	}
}

