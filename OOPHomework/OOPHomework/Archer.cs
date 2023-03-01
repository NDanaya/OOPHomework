namespace OOPHomework;

public class Archer : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Archer shoots!");
    }
    
    public override int UnitDamage { set; get; } = 48;
    public override string UnitSkills { set; get; } = "Blazing Arrow";
    
    public int ArrowDistance { set; get; }
    
}