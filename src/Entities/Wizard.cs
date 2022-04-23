namespace rpg_game.src.Entities {
	public class Wizard: Hero {

		public Wizard (string name, int level, string heroType, int hp): base(name, level, heroType, hp) {
		}

		public override string Attack () {

			return $"{this.Name} casted a spell";

		}

        public string Attack (int damage) {

			if (damage > 6)
				return $"{this.Name} casted a great fire ball";

			else
				return $"{this.Name} casted a regular fire ball";

        }


	}
}
