namespace rpg_game.src.Entities {
	public class Ninja: Hero {

		public Ninja (string name, int level, string heroType, int hp): base (name, level, heroType, hp){
		}

		public override string Attack() {

			return $"{this.Name} throwed a shuriken";

		}

	}
}