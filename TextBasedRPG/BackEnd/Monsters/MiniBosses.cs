namespace TextBasedRPG.BackEnd.Monsters;

public class MiniBosses(string name, int level, MonsterStats stats, MonsterType type)
    : Monsters(name, level, type, stats);