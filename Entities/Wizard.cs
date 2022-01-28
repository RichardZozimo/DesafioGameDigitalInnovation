namespace DesafioGameDio.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string vocation) : base (name, level, vocation)
        {
            this.Name = name;
            this.Level = level;
            this.Vocation = vocation;
            this.MaxHP = level * 6;
            this.MaxMP = level * 15;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Vocation { get; set; }

        public override string Atack()
        {
            Random rnd = new Random();
            int Damage = 10 + rnd.Next(1, 6);

            return $"{this.Name} causou {Damage} de dano com sua magia.";
        }

    }
}