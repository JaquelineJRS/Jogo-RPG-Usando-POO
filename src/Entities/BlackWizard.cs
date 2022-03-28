namespace Jogo_RPG_Usando_POO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou a sua Magia Negra";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return this.Name + $" Lançou a sua Magia Negra um bonus elevado de {Bonus}.";
            }
            else
            {
                return this.Name + " Lançou a sua Magia Negra com baixa força.";
            }
        }
    }
}