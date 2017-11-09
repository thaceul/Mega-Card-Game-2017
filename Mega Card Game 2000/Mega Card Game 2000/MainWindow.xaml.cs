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

namespace Mega_Card_Game_2000
{
    public class Character
    {
        public int currentHealthPoints { get; set; }
        public int maxHealthPoints { get; set; }

        public Character(int health, int maxHealth)
        {
            currentHealthPoints = health;
            maxHealthPoints = maxHealth;
        }
    }

    public class PlayerCharacter
    {
        private char characterName { get; set; }
        private int normalAttack { get; set; }
        private int specialAttack { get; set; }
        private PlayerCharacter(char Name, int NormalAttack, int SpeacialAttack)
        {
            characterName = Name;
            normalAttack = NormalAttack;
            specialAttack = SpeacialAttack;
        }
    }

    public class GameController
    {
        private int enemy { get; set; }
        private int player { get; set; }
        private GameController(int NonPlayerCharacter, int PlayerCharacter)
        {
            enemy = NonPlayerCharacter;
            player = PlayerCharacter;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        frameMainWindow.Navigate(new Battle());
    }


}
    

       


