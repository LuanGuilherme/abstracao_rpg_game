namespace rpg_game.src.Entities {
	public abstract class Hero {

		public string Name;
		public int Level;
		public string HeroType;
		public int HP;

		public Hero (string name, int level, string heroType, int hp) {

			this.Name = name;
			this.Level = level;
			this.HeroType = heroType;
			this.HP = hp;

		}

		public override string ToString () {

			return $"His name is {this.Name}, he's a {this.HeroType} of level {this.Level}.";

		}

		public virtual string Attack () {

			return $"{this.Name} attacked with his sword";

		}
	}
}
