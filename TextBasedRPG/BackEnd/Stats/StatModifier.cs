using TextBasedRPG.BackEnd.Monsters;
using TextBasedRPG.BackEnd.Player;

namespace TextBasedRPG.BackEnd.Stats;

public interface IStatModifier
{
    int ConMod();

    int StrMod();

    int DexMod();

    int IntelMod();

    int WisMod();
}