using System.Diagnostics.CodeAnalysis;
using TextBasedRPG.BackEnd.Profession;

namespace TextBasedRPG.BackEnd.Player;

public class Player {
    public enum eProfession {
        Archer,
        Mage,
        Berserker,
        Support
    }
    
    private string Name { get; set; }
    private int Level { get; set; }
    
    public static void createPlayer() {
        Console.WriteLine("Please Enter Your Character's Name: ");
        string playerName = Console.ReadLine();
        
        Boolean boolProf = true;
        @NotNullAttribute: eProfession profession = eProfession.Archer;

        do {
            Console.WriteLine("Please Enter What Profession You Would Prefer? (Mage, Berserker, Archer, Support)");
            string professionChoice = Console.ReadLine();
            switch (professionChoice) {
                case "Archer": {
                    profession = eProfession.Archer;
                    boolProf = false;
                    break;
                }
                case "Mage": {
                    profession = eProfession.Mage;
                    boolProf = false;
                    break;
                }
                case "Berserker": {
                    profession = eProfession.Berserker;
                    boolProf = false;
                    break;
                }
                case "Support": {
                    profession = eProfession.Support;
                    boolProf = false;
                    break;
                }
                default: {
                    Console.WriteLine("Invalid Input.\nPlease Try Again.");
                    break;
                }
            } 
        } while (boolProf);

        Player player = new Player(playerName, profession, 0, 
            new PlayerStats(20, 5, 5, 5, 5, 5, 3));
    }
    
    public Player(string name, eProfession profession, int level, PlayerStats stats) {
        Name = name;
        Level = level;
    }
    
    
    
    
}