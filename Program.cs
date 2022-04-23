using System;
using rpg_game.src.Entities;

namespace rpg_game
{
	class Program
	{
		static void Main(string[] args)
		{

			Knight hero = new Knight("Arus", 2, "Knight", 100);
			Wizard oponent = new Wizard("Maleficus", 27, "Dark Mage", 700);
			Ninja ninja = new Ninja("Hanzo", 23, "Ninja", 630);

			Console.Write(hero.Attack()+"\n");
			Console.Write(oponent.Attack(4)+"\n");
			Console.Write(ninja.Attack()+"\n");

		}
	}
}
