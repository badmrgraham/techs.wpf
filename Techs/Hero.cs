using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Techs
{
    public class Hero : IHasStats, IEquipTech, INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged("Name"); }
        }
        public HeroClass Class { get; set; }

        #region Implementation of IHasStats

        public int Tech { get; set; }
        public int Faith { get; set; }
        public int Strength { get; set; }
        public int Body { get; set; }
        public int Speed { get; set; }

        #endregion

        #region Implementation of IEquipTech

        public TechItem Offensive { get; set; }
        public TechItem Defensive { get; set; }

        #endregion

        #region constructors

        public Hero()
        {
            Name = string.Empty;
        }

        #endregion

        #region public methods

        public List<Ability> GetAllAbilities()
        {
            var abilities = new List<Ability>();
            if (Offensive != null)
            {
                abilities.AddRange(Offensive.Abilities);
            }
            else
            {
                abilities.Add(new Ability(Abilities.Fight));
            }
            if (Defensive != null)
            {
                abilities.AddRange(Defensive.Abilities);
            }
            if (Class != null)
            {
                abilities.AddRange(Class.Abilities);
            }
            return abilities;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Class != null ? Class.Name : string.Empty);
        }

        #endregion

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
