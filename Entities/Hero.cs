namespace DesafioGameDio.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Vocation { get; set; }
        public int MaxHP;
        public int MaxMP;
        public Hero(string name, int level, string vocation)
        {
            this.Name = name;
            this.Level = level;
            this.Vocation = vocation;
        }

        public virtual string Atack() => "Atacou";


        public override string ToString()
        {
            return $"==================================\n Name: {this.Name}\n Level: {this.Level}\n Vocation: {this.Vocation}\n Vida: {this.MaxHP}\n Mana: {this.MaxMP}\n==================================";
        }

    }
}