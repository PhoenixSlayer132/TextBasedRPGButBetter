using TextBasedRPG.BackEnd.Monsters;
using TextBasedRPG.BackEnd.Player;

namespace TextBasedRPG.BackEnd.Stats;

public interface IStatModifier {
    int conMod();

    int strMod();

    int dexMod();

    int intelMod();

    int wisMod();
}