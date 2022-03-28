namespace Jogo_RPG_Usando_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + $" Lançou seu Ataque das sombras ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + $" Lançou seu Ataque das Sombras com uma força elevada de {Bonus}.";
            }
            else
            {
                return this.Name + $" Lançou seu Ataque das Sombras com pouca força.";
            }
        }
    }
}