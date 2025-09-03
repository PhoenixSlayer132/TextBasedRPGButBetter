using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace TextBasedRPG.BackEnd.Monsters;

public class MonsterType {
    
    public static MonsterType randomizedTypes() {
        Random random = new Random();
        var types = Enum.GetNames(typeof(MonsterType));
        int randomTypeIndex = random.Next(0, types.Length);
        eMonsterType randomType = (eMonsterType)randomTypeIndex;

        eElement randomElement;
        switch (randomType)
        {
            case 0: {//Humanoid
                string[] elements = ["Fire",  "Water", "Earth", "Wind", "Null"];
                int randomElementIndex = random.Next(0, elements.Length);
                randomElement = (eElement)randomElementIndex;
                break;
            }
            case (eMonsterType)1: {//Feral
                string[] elements = ["Fire",  "Water", "Earth", "Wind", "Null"];
                int randomElementIndex = random.Next(0, elements.Length);
                while (randomElementIndex == 0) 
                    randomElementIndex = random.Next(0, elements.Length);
                randomElement = (eElement)randomElementIndex;
                break;
            }
            case (eMonsterType)2: {//Elemental
                string[] elements = ["Fire",  "Water", "Earth", "Wind", "Null"];
                int randomElementIndex = random.Next(0, elements.Length);
                while (randomElementIndex == 4)
                    randomElementIndex = random.Next(0, elements.Length);
                randomElement = (eElement)randomElementIndex;
                break;
            }
            case (eMonsterType)3: {//Flora
                string[] elements = ["Fire",  "Water", "Earth", "Wind", "Null"];
                int randomElementIndex = random.Next(0, elements.Length);
                while (randomElementIndex == 0 || randomElementIndex == 3 || randomElementIndex == 4)
                    randomElementIndex = random.Next(0, elements.Length);
                randomElement = (eElement)randomElementIndex;
                break;
            }
            case (eMonsterType)4: {//Undead
                string[] elements = ["Fire",  "Water", "Earth", "Wind", "Null"];
                int randomElementIndex = random.Next(0, elements.Length);
                while (randomElementIndex == 1)
                    randomElementIndex = random.Next(0, elements.Length);
                randomElement = (eElement)randomElementIndex;
                break;
            }
            case (eMonsterType)5: {//Draconic
                string[] elements = ["Fire",  "Water", "Earth", "Wind", "Null"];
                int randomElementIndex = random.Next(0, elements.Length);
                while (randomElementIndex == 4)
                    randomElementIndex = random.Next(0, elements.Length);
                randomElement = (eElement)randomElementIndex;
                break;
            }
            default:
                randomElement = (eElement)4;
                break;
        }

        MonsterType randMonster = new MonsterType((eMonsterType)randomTypeIndex, randomElement);
        return randMonster;
    }
    
    public enum eMonsterType {
        Humanoid,
        Feral,
        Elemental,
        Flora,
        Undead,
        Draconic,
        Abomination
    }
    public MonsterType(eMonsterType type, eElement element) {
        
    }
    public enum eElement {
        Fire,
        Water,
        Earth,
        Wind,
        Null
    }

    

    
} 