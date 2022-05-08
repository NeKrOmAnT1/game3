using System;

namespace game3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("###############################");
            Hero hero = new Hero();
            {
                hero.name = "Любопытный гвардеец";
                hero.heroHealth = 100;
                hero.heroAttack = rnd.Next(1, 30);
                        
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ваш персонаж: " + hero.name);
            Console.WriteLine("Здоровье: " + hero.heroHealth);
            Enemy enemy = new Enemy();
            {
                enemy.name = "Обезумевший зверь";
                enemy.monsterHealth = 100;
                enemy.monsterAttack= rnd.Next(1,30);
            }
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ваш противник:" + enemy.name); 
            Console.WriteLine("Здоровье: " + enemy.monsterHealth);
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Враг наступает!!!");
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1 раунд...");
            Console.WriteLine("###############################");
            int n = 0;
            while (n < 3)
            {
                hero.heroHealth = hero.heroHealth - enemy.monsterAttack;
                enemy.monsterHealth = enemy.monsterHealth - hero.heroAttack;
                n = n + 1;
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Первый раунд завершен");
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Здоровье персонажа: "+hero.heroHealth); 
               Console.WriteLine("Здоровье противника: "+enemy.monsterHealth);
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2 раунд...");
            Console.WriteLine("###############################");
            while (hero.heroHealth * enemy.monsterHealth > 0)
            {
                hero.heroHealth = hero.heroHealth - enemy.monsterAttack;
                enemy.monsterHealth = enemy.monsterHealth - hero.heroAttack;
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Второй раунд завершен");
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Здоровье персонажа" + hero.heroHealth);
            Console.WriteLine("Здоровье противника" + enemy.monsterHealth);
            Console.WriteLine("###############################");
            System.Threading.Thread.Sleep(1000);
            if (hero.heroHealth > 0)
            {
                Console.WriteLine("Герой одержал победу");
            }
            else
            {
                Console.WriteLine("Герой погиб в сражении");
            }
            Console.WriteLine("###############################");





        }
    }
}
