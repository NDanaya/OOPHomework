namespace OOPHomework;

public class Mage : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Mage conjures!");
    }
    
    public override int UnitDamage { set; get; } = 97;
    public override string UnitSkills { set; get; } = "Energy Influx";

    public int MagicAmount { set; get; }
    
}