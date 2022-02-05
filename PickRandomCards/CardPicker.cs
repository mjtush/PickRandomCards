﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
	class CardPicker
	{
		//random number generator
		static Random random = new Random();
		public static string[] PickSomeCards(int numberOfCards)
		{
			// string array declaration and initialization
			string[] pickedCards = new string[numberOfCards];

			//loop for asigning random cards value + suite 
			for (int i = 0; i < numberOfCards; i++)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}
			return pickedCards;
		}

		/// <summary>
		/// Methodod chooses random plaing card suit
		/// </summary>
		/// <returns></returns>
		private static string RandomSuit()
		{
			//get a random number from 1 to 4 
			int value = random.Next(1, 5);
			//IF it is 1 then return the string Spades
			if (value == 1) return "Spades";
			//if it is 2 then return the string Hearts
			if (value == 2) return "Hearts";
			//if it is 3 then return the string Clubs
			if (value == 3) return "Clubs";
			//if we have not retured yet, return the string Dimonds
			//it is obvious there will be 4, code with reduced space
			return "Dimonds"; 
		}

		//method generates random number
		private static string RandomValue()
		{
			int value = random.Next(1, 44);
			if (value == 1) return "Ace";
			if (value == 11) return "Jack";
			if (value == 12) return "Queen";
			if (value == 13) return "King";
			return value.ToString();

		}
	}
}
