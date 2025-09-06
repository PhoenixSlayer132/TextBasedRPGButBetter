using TextBasedRPG.BackEnd.Stats;

namespace TextBasedRPG.BackEnd.Monsters;

public class MiniBosses(string name, byte level, MonsterStats stats, MonsterType type)
    : Monsters(name, level, type, stats);