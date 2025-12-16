using System.Runtime.InteropServices;

namespace RPG_Game
{
    public class WoodenSword : Weapon
    {
        public WoodenSword() : base("Дерев'яний меч", "+5 до атаки", 5)
        {
        }
    }

    public class HealthPotion : Item
    {
        private int _healthAmount;

        public HealthPotion() : base("Зілля здоров'я", "Відновлює 40 HP")
        {
            _healthAmount = 40;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} використовує {Name}");
            player.Heal(_healthAmount);
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