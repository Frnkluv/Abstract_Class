Player soilder = new Player();

Weapon[] inventory = { new Pistol(), new AR(), new LaserGun() };

foreach (var item in inventory)
{
    soilder.CheckInfo(item);
    soilder.Fire(item);
    Console.WriteLine();
}

class Player
{
    public void Fire(Weapon weapon)
    {
        weapon.Fire();
    }

    public void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}


abstract class Weapon
{
    public abstract int Damage { get; }

    public abstract void Fire();

    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} | Damage: {Damage}");
    }
}

class Pistol : Weapon
{
    public override int Damage { get { return 10; } }

    public override void Fire()
    {
        Console.WriteLine("Пиу, пиу");
    }
}

class LaserGun : Weapon
{
    public override int Damage => 12;       /* Это лямбда выражение. Функциональность как у свойства выше в Pistol */

    public override void Fire()
    {
        Console.WriteLine("ХитCкан");
    }
}

class AR : Weapon
{
    public override int Damage => 15;

    public override void Fire()
    {
        Console.WriteLine("Тррррр");
    }
}