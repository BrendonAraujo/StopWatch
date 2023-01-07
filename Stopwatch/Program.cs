using System;
using System.Threading;

namespace Stopwatch;

class Program
{
	static void Main(string[] args)
	{
		Menu();
	}
	
	static void Menu()
	{
		Console.Clear();
		Console.WriteLine("S = Second => 10s = 10 seconds");
		Console.WriteLine("M = Minute => 10m = 10 minutes");
		Console.WriteLine("0 = Exit");
		Console.WriteLine("How much time?");
		string data = Console.ReadLine()??"0".ToLower();
		
		int lastCaracterPosition = data.Length < 0 ? 0 : data.Length-1;	
		char type = char.Parse(data.Substring(lastCaracterPosition,1));

		int time = 0;
		int multiplier = 1;
		if (lastCaracterPosition != 0)
		{
			time = int.Parse(data.Substring(0, lastCaracterPosition));   
		}
		
		if(time == 0)
		{
			Environment.Exit(0);
		}
		
		multiplier = (type == 'm') ? multiplier * 60 : multiplier;
		PrintWath();
		// Start(time * multiplier);
	}
	
	static void Start(int time)
	{
		int currentTime = 0;
		
		while(currentTime != time)
		{
			currentTime++;
			Console.Clear();
			Console.WriteLine(currentTime);
			Thread.Sleep(1000);
		}
		Console.WriteLine("Stopwatch finalized!");
		Thread.Sleep(2500);
	}
}