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

namespace _169_ListBox_and_a_List_of_Curent_Matches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Dinamo", Team2 = "Steaua", 
                Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match()
            {
                Team1 = "Rapid",
                Team2 = "CFR Cluj",
                Score1 = 0,
                Score2 = 1,
                Completion = 45
            });
            matches.Add(new Match()
            {
                Team1 = "Petrolul Ploiesti",
                Team2 = "Otelul Galati",
                Score1 = 2,
                Score2 = 0,
                Completion = 12
            });
            matches.Add(new Match()
            {
                Team1 = "PSG",
                Team2 = "AS Roma",
                Score1 = 3,
                Score2 = 1,
                Completion = 50
            });
            matches.Add(new Match()
            {
                Team1 = "Real Madrid",
                Team2 = "Barca",
                Score1 = 3,
                Score2 = 1,
                Completion = 73
            }) ;
            matches.Add(new Match()
            {
                Team1 = "Universitatea Craiova",
                Team2 = "Dinamo",
                Score1 = 2,
                Score2 = 1,
                Completion = 60
            });
            lbMatches.ItemsSource = matches;    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show
                    ("Selected Match: "+
                      
                      (lbMatches.SelectedItem as Match).Team1 + " "+
                      (lbMatches.SelectedItem as Match).Score1 + " " +
                      (lbMatches.SelectedItem as Match).Team2 + " " +
                      (lbMatches.SelectedItem as Match).Score2);                
            }
        }
    }
    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }

    }
}
