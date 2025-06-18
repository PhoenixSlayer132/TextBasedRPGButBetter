namespace TextBasedRPG.BackEnd.Monsters;

public class MonsterType {

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
    public class MonsterElement {
        public enum eElement {
            Fire,
            Water,
            Earth,
            Wind,
            Null
        }
    
        public MonsterElement(eElement element) {
        
        }

    
    }

    
} 