using System.Runtime.InteropServices;

namespace RPG_Game
{
    public class Weapon : Item, IEquippable
    {
        public int Damage { get; protected set; }

        public Weapon(string name, string description, int damage) : base(name, description)
        {
            Damage = damage;
        }

        public void Equip(Player player)
        {
            Console.WriteLine($"{Name} екіпіровано! (+{Damage} до атаки)");
        }

        public void Unequip(Player player)
        {
            throw new NotImplementedException();
        }

        public override void Use(Player player)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}