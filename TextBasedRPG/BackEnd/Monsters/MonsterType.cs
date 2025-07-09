namespace TextBasedRPG.BackEnd.Monsters;

public class MonsterType {

    protected enum eBodyType {
        Humanoid,
        Feral,
        Elemental,
        Flora,
        Undead,
        Draconic,
        Abomination
    }
    private MonsterType(eBodyType eBodyType) {
        
    }
    
    public class MonsterElement {
        protected enum eElement {
            Fire,
            Water,
            Earth,
            Wind,
            Null
        }
    
        private MonsterElement(eElement element) {
        
        }

    
    }

    
} 