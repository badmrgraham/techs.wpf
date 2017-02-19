using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
using Techs;

namespace HeroBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Hero> Heroes { get; set; }
        private Hero selectedHero;
        public Hero SelectedHero { 
            get { return selectedHero; } 
            set { selectedHero = value; NotifyPropertyChanged("SelectedHero"); } 
        }

        public MainWindow()
        {
            Heroes = new ObservableCollection<Hero>();
            InitializeComponent();
        }

        private void AddHeroButton_Click(object sender, RoutedEventArgs e)
        {
            var hero = new Hero(){Name = "basic " + DateTime.Now.Millisecond};
            Heroes.Add(hero);
            CharacterSelectionList.SelectedItem = hero;
        }

        private void CharacterSelectionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion
    }
}
