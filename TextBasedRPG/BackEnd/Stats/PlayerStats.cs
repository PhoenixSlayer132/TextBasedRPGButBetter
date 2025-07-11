﻿using TextBasedRPG.BackEnd.Stats;

namespace TextBasedRPG.BackEnd.Player;

public class PlayerStats : IStatModifier {
    private int Hp { get; set; }
    private int Con { get; set; }
    private int Str { get; set; }
    private int Dex { get; set; }
    private int Intel { get; set; }
    private int Wis { get; set; }
    private int Spd { get; set; }
    
    public PlayerStats(int health, int constitution, int strength, int dexterity, int intelligence, int wisdom, int speed) {
        Hp = health;
        Con = constitution;
        Str = strength;
        Dex = dexterity;
        Intel = intelligence;
        Wis = wisdom;
        Spd = speed;
    }

    public int conMod() { return (int) (Con * 0.2); }

    public int strMod() { return (int) (Str * 0.2); }

    public int dexMod() { return (int) (Dex * 0.2); }

    public int intelMod() { return (int) (Intel * 0.2); }

    public int wisMod() { return (int) (Wis * 0.2); }
}