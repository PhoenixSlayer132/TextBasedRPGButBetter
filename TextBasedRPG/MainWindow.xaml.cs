using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextBasedRPG.BackEnd.Monsters;
using TextBasedRPG.BackEnd.Player;

namespace TextBasedRPG;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        Player player = new Player("Phoenix", Player.eProfession.Mage, 0, 
            new PlayerStats(20, 5, 5, 5, 5, 5, 3));
        
        Monsters monster = new Monsters("Wolf", 0,
            new MonsterStats(MonsterStats.eSkillLevel.Tutorial, 20, 5, 5, 5, 5, 5, 3), 
            MonsterType.randomizedTypes());
        
        InitializeComponent();
    }
}