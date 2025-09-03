namespace TextBasedRPG.BackEnd.Monsters;

public class Bosses(string name, int level, MonsterStats stats, MonsterType type)
    : Monsters(name, level, type, stats);