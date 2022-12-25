using System;
using NBACourse.Context;
using NBACourse.Models;
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
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace NBACourse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NbaContext _db;
        public string SelectedLeague = null;
        public MainWindow()
        {
            InitializeComponent();
            _db = new NbaContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SelectedLeague = "NBA";
        }

        private void SelectG_Click(object sender, RoutedEventArgs e)
        {
            SelectedLeague = "G LEAGUE";
        }


        private void RefreshConf_Click(object sender, RoutedEventArgs e)
        {
            var query = (from conference in _db.Conferences
                         where conference.LeagueName == SelectedLeague
                         select conference).ToList();
            ConferenceList.ItemsSource = query;
            query = null;
        }

        private void RefreshDiv_Click(object sender, RoutedEventArgs e)
        {
            var query = (from division in _db.Divisions
                    where division.Conf.LeagueName == SelectedLeague
                    select division).ToList();
            DivionsList.ItemsSource = query;
            query = null;
        }

        private void RefreshTeam_Click(object sender, RoutedEventArgs e)
        {
            var query = (from team in _db.Teams
                         where team.Div.Conf.LeagueName == SelectedLeague
                         orderby team.PlaceInConf,team.Div.DivName
                         select new {team.TeamName,team.PlaceInConf,team.WinsNumber,team.LossesNumber,team.Div.DivName,team.Points,team.ConPoints}).ToList();
            TeamList.ItemsSource = query;
            query = null;
        }
    }
}
