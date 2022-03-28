namespace Jogo_RPG_Usando_POO.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {

        }
        public string Name;
        public int Level;
        public string HeroType;

        //ToString é herdada da classe object, no método abaixo estamos sobescrevendo a função de ToString.
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + ";";
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}