using TextBasedRPG.BackEnd.Stats;

namespace TextBasedRPG.BackEnd.Monsters;

public class MonsterStats : IStatModifier
{
    public enum eSkillLevel
    {
        Tutorial,
        Beginner,
        Intermediate,
        Advanced,
        Expert,
        Master,
        GrandMaster
    }
    
    #region enum
    private eSkillLevel SkillLevel { get; set; }
    private int Hp { get; set; }
    private int Con { get; set; }
    private int Str { get; set; }
    private int Dex { get; set; }
    private int Intel { get; set; }
    private int Wis { get; set; }
    private int Spd { get; set; }
    #endregion
    
    public MonsterStats(eSkillLevel skillLevel, int health, int constitution, int strength, int dexterity, int intelligence, int wisdom, int speed)
    {
        SkillLevel = skillLevel;
        Hp = health;
        Con = constitution;
        Str = strength;
        Dex = dexterity;
        Intel = intelligence;
        Wis = wisdom;
        Spd = speed;
    }
    
    public int ConMod()
    {
        return (int) (Con * 0.5);
    }

    public int StrMod()
    {
        return (int) (Str * 0.5);
    }

    public int DexMod()
    {
        return (int) (Dex * 0.5);
    }

    public int IntelMod()
    {
        return (int) (Intel * 0.5);
    }

    public int WisMod()
    {
        return (int) (Wis * 0.5);
    }
}