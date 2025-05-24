using TextBasedRPG.BackEnd.Profession;

namespace TextBasedRPG.BackEnd.Player;

public class Player
{
    public enum eProfession
    {
        Archer,
        Mage,
        Berserker,
        Support
    }
    
    private string Name { get; set; }
    private int Level { get; set; }
    
    public Player(string name, eProfession profession, int level, PlayerStats stats)
    {
        Name = name;
        Level = level;
    }
    
    
    
    
}