using System;

class MainClass
{
	public static void Main(string[] args)
	{
		DaysOfWeek MyFavoriteDay;

		MyFavoriteDay = DaysOfWeek.Friday;

		Console.WriteLine(MyFavoriteDay);
	}
}

enum DaysOfWeek : byte
{
	Tuesday,
	Monday,
	Wednesday,
	Friday
}

enum Semaphore : int
{
	Red = 100,
	Yellow = 200,
	Green = 300
}