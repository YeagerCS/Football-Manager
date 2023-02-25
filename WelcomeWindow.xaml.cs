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
using System.Windows.Shapes;

namespace Football_Manager
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        Reference reference = new Reference();
        Team team = new Team();
        public WelcomeWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            reference.manager = new Manager(firstnameTbx.Text, lastnameTbx.Text);
            reference.manager.Money = 1000;
            reference.manager.Rating = 5;
            team = new Team(teamnameTbx.Text, 0, 1);

            reference.manager.TeamAssigned = team;
            new Persistence().SaveManagers(reference.manager);
            new Persistence().SaveTeam(team);
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
