using System.Diagnostics.CodeAnalysis;
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
    public MainWindow() {
        Player.createPlayer();
        
        
        Monsters monster = new Monsters("Wolf", 0, MonsterType.randomizedTypes(),
            MonsterStats.randomizedStats());
        
        InitializeComponent();
    }
    
}