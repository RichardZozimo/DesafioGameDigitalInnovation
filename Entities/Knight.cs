namespace DesafioGameDio.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string vocation) : base (name, level, vocation)
        {
            this.Name = name;
            this.Level = level;
            this.Vocation = vocation;
            this.MaxHP = level * 15;
            this.MaxMP = level * 8;
        }

        public override string Atack()
        {
            Random rnd = new Random();
            int Damage = 10 + rnd.Next(4, 8);

            return $"{this.Name} causou {Damage} de dano com sua espada.";
        }

    }
}