namespace TextBasedRPG.BackEnd.Monsters;

public class Monsters {
    private string Name { get; set; }
    private int Level { get; set; }
    private MonsterType Type { get; set; }
    
    public Monsters(string name, int level, MonsterType type, MonsterStats stats) {
        Name = name;
        Level = level;
        Type = type;
    }
    
}