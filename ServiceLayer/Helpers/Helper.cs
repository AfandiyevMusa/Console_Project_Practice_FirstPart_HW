using System;
namespace ServiceLayer.Helpers
{
	public static class Helper
	{
		public static void WriteConsole(this ConsoleColor color, string text)
		{
            Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ResetColor();
		}
	}
}

