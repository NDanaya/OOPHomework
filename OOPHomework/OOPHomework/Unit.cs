namespace OOPHomework;

public abstract class Unit
{
    public abstract void Attack();
    public abstract int UnitDamage { set; get; }
    public abstract string UnitSkills { set; get; }
    public string UnitName { set; get; }
}