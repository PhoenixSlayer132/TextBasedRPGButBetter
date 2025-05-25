namespace TextBasedRPG.BackEnd.Monsters;

public class Monsters {
    private string Name { get; set; }
    private int Level { get; set; }
    
    public Monsters(string name, int level, MonsterStats stats, MonsterType type) {
        Name = name;
        Level = level;
    }
}