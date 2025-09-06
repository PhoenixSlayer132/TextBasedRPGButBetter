namespace TextBasedRPG.BackEnd.Leveling;

public class PlayerLevel
{
    private byte Level { get; set;}
    private float Experience { get; set;}
    
    public enum eLifeRank {
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
    public PlayerLevel(byte level, float experience, eLifeRank lifeRank) {
        Level = level;
        Experience = experience;
    }
}