using TextBasedRPG.BackEnd.Stats;

namespace TextBasedRPG.BackEnd.Stats;

public class MonsterStats : IStatModifier {
    public enum eLifeRank {
        Tutorial,
        NewBlood,
        Beginner,
        Advanced,
        Elite,
        SpecialElite,
        StandardChieftain,
        HighChieftain,
        Lord,
        HighLord
    }
    
    #region enum
    private eLifeRank LifeRank { get; set; }
    private int Hp { get; set; }
    private int Con { get; set; }
    private int Str { get; set; }
    private int Dex { get; set; }
    private int Intel { get; set; }
    private int Wis { get; set; }
    private int Spd { get; set; }
    #endregion
    
    public MonsterStats(eLifeRank lifeRank, int health, int constitution, int strength, int dexterity, int intelligence, int wisdom, int speed) {
        LifeRank = lifeRank;
        Hp = health;
        Con = constitution;
        Str = strength;
        Dex = dexterity;
        Intel = intelligence;
        Wis = wisdom;
        Spd = speed;
    }
    
    public int conMod() { return (int) (Con * 0.5); }

    public int strMod() { return (int) (Str * 0.5); }

    public int dexMod() { return (int) (Dex * 0.5); }

    public int intelMod() { return (int) (Intel * 0.5); }

    public int wisMod() { return (int) (Wis * 0.5); }
}