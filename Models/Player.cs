using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {

        private string _characterClass;
        private int _hitPoints;
        private string _name;
        private int _level;
        private int _gold;
        private int _experiencePoints;

        public Player()
        {
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass
        {
            get
            {
                return _characterClass;
            }

            set
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }

            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int Level
        {
            get
            {
                return _level;

            }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


