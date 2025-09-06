using TextBasedRPG.BackEnd.Stats;

namespace TextBasedRPG.BackEnd.Monsters;

public class Monsters {
    private string Name { get; set; }
    private byte Level { get; set; }
    private MonsterType Type { get; set; }
    
    public Monsters(string name, byte level, MonsterType type, MonsterStats stats) {
        Name = name;
        Level = level;
        Type = type;
    }
    
}