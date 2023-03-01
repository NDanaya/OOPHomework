namespace OOPHomework;

public class Mage : Unit
{
    private string _name;

    public override void Attack()
    {
        Console.WriteLine("Mage conjures!");
    }
    
    public override int UnitDamage { set; get; } = 97;
    public override string UnitSkills { set; get; } = "Energy Influx";

}