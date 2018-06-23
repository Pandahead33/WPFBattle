using puskaric.RoleplayingGameInterfaces;
using puskaric.RoleplayingGameLibrary;
using puskaric.RPGTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ICombat encounter;

        public MainWindow()
        {
            InitializeComponent();

            TextBoxStreamWriter consoleWriter = new TextBoxStreamWriter(textBox);
            Console.SetOut(consoleWriter);

            //Initalize variables
            IList<ICharacter> playerParty = new List<ICharacter>();
            IList<ICharacter> enemyParty = new List<ICharacter>();
            string playerPartyName = "Heroes";
            string enemyPartyName = "Villains";

            //Create player characters
            ICharacter player1 = new ImageMage("Harry Potter", 41, characterImage);
            ICharacter player2 = new ImageWarrior("Carl Sagan", 110, characterImage1);

            //Create enemy characters
            ICharacter enemy1 = new ImageArcher("Voldemort", 90, characterImage2);
            ICharacter enemy2 = new ImageComputerWizard("Neil deGrasse Tyson", 41, characterImage3);

            //Add players to party
            playerParty.Add(player1);
            playerParty.Add(player2);

            //Add enemys to party
            enemyParty.Add(enemy1);
            enemyParty.Add(enemy2);

            //Initalize combat 
            encounter = new Combat(playerParty, enemyParty, playerPartyName, enemyPartyName);

            CombatThread combatThread = new CombatThread(encounter);
            combatThread.Start();
        }
    }
}
