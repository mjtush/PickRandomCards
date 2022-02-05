using System;
using static System.Console;

namespace PickRandomCards
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Enter a number of cartds to pick: ");
			string line = Console.ReadLine();

			if (int.TryParse(line, out int numberOfCards))
			{
				string[] chosenCards = CardPicker.PickSomeCards(numberOfCards);
				WriteLine("\nThe cards are:");
				foreach (string card in chosenCards)
				{
					WriteLine(card);
				}
				ReadKey();
			}
			else
			{
				WriteLine("Number was not valid! Run again");
				ReadKey();
			}
		}
	}
}
