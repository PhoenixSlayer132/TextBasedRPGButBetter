using TextBasedRPG.BackEnd.Monsters.MonsterTypes;

namespace TextBasedRPG.BackEnd.Monsters;

public class MonsterType<T> where T : Monsters, new() {

    public enum eMonsterType {
        Humanoid,
        Feral,
        Elemental,
        Flora,
        Undead,
        Draconic,
        Abomination
    }
    public MonsterType() {
        
    }
    

    
} 