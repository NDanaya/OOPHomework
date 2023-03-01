namespace OOPHomework;

public class Knight : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Knight stabs!");
    }

    public override int UnitDamage { set; get; } = 13;
    public override string UnitSkills { set; get; } = "Shield of Atonement";
    
}