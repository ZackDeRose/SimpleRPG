using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleRPG.Models
{
    public class Unit : INotifyPropertyChanged, IDataErrorInfo
    {

        #region Unit Properties

        private String _name;
        /// <summary>
        /// Gets or sets the unit's name
        /// </summary>
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = "";
                char[] temp = value.ToCharArray();
                for(int i = 0; i < 10 && i < temp.Length; i++)
                {
                    if(((temp[i] >= 'a' && temp[i] <= 'z') || (temp[i] >= 'A' && temp[i] <= 'Z')))
                    {
                        _name += temp[i];
                    }
                }
                _name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_name.ToLower());

                OnPropertyChanged("Name");
                OnPropertyChanged("ClassError");
                //OnPropertyChanged(this["Name"]);
            }
        }

        private int _health;
        /// <summary>
        /// Gets or sets the unit's maxHealth
        /// </summary>
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                OnPropertyChanged("Health");
                OnPropertyChanged("ClassError");
                //OnPropertyChanged(this["Health"]);
            }
        }

        private int _speed;
        /// <summary>
        /// Gets or sets the unit's currentHealth
        /// </summary>
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
                OnPropertyChanged("Speed");
                OnPropertyChanged("ClassError");
                //OnPropertyChanged(this["Speed"]);
            }
        }

        private int _attack;
        /// <summary>
        /// Gets or sets the unit's attack
        /// </summary>
        public int Attack
        {
            get
            {
                return _attack;
            }
            set
            {
                _attack = value;
                OnPropertyChanged("Attack");
                OnPropertyChanged("ClassError");
                //OnPropertyChanged(this["Attack"]);
            }
        }


        private int _defense;
        /// <summary>
        /// Gets or sets the unit's defense
        /// </summary>
        public int Defense
        {
            get
            {
                return _defense;
            }
            set
            {
                _defense = value;
                OnPropertyChanged("Defense");
                OnPropertyChanged("ClassError");
                OnPropertyChanged(this["Defense"]);
            }
        }

        #endregion

        /// <summary>
        /// Intializes an instance of the Unit class
        /// </summary>
        /// <param name="unitName"> Name </param>
        /// <param name="health"> Health </param>
        /// <param name="speed"> Speed </param>
        /// <param name="attack"> Attack </param>
        /// <param name="defense"> Defense </param>
        public Unit(String unitName, int health, int speed, int attack, int defense)
        {
            Name = unitName;
            Health = health;
            Speed = speed;
            Attack = attack;
            Defense = defense;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region IDataErrorInfo Members

        public string Error
        {
            get;
            private set;
        }

        private string _classError;
        public String ClassError
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                //if (String.IsNullOrWhiteSpace(Name) || Name.Length > 10 || Name.Length < 4)
                //{
                //    sb.AppendLine("Invalid Name Length.");
                //}
                //if (!Regex.IsMatch(Name, @"^[a-zA-Z]+$"))
                //{
                //    sb.AppendLine("Invalid Name Format.");
                //}
                //if (Health < 10 || Health > 100)
                //{
                //    sb.AppendLine("Health outside of acceptable range.");
                //}
                //if (Speed <= 0 || Attack > 50)
                //{
                //    sb.AppendLine("Attack outside of acceptable range.");
                //}
                //if (Attack <= 0 || Attack > 50)
                //{
                //    sb.AppendLine("Attack outside of acceptable range.");
                //}
                //if (Defense <= 0 || Defense > 50)
                //{
                //    sb.AppendLine("Health outside of acceptable range.");
                //}
                String[] properties = { "Name", "Health", "Attack", "Defense", "Speed" };
                foreach (String s in properties)
                {
                    if (!String.IsNullOrEmpty(this[s]))
                    {
                        sb.AppendLine(this[s]);
                    }
                }
                _classError = sb.ToString();
                return _classError;
            }
            private set
            {
                _classError = value;
                OnPropertyChanged("ClassError");
            }
        }

        public string this[string propertyName]
        {
            get
            {
                Error = "";
                if (propertyName == "Name")
                {
                    if (String.IsNullOrWhiteSpace(Name)){
                        Error = "Name is Empty";
                    }
                    else if(Name.Length > 10 || Name.Length < 4)
                    {
                        Error = "Invalid Name Length.";
                    }
                    else if (!Regex.IsMatch(Name, @"^[a-zA-Z]+$"))
                    {
                        Error = "Invalid Name Format.";
                    }
                }
                else if (propertyName == "Health")
                {
                    if (Health < 10 || Health > 100)
                    {
                        Error = "Health outside of acceptable range.";
                    }
                }
                else if (propertyName == "Speed")
                {
                    if (Speed <= 0 || Speed > 50)
                    {
                        Error = "Speed outside of acceptable range.";
                    }
                }
                else if (propertyName == "Attack")
                {
                    if (Attack <= 0 || Attack > 50)
                    {
                        Error = "Attack outside of acceptable range.";
                    }
                }
                else if (propertyName == "Defense")
                {
                    if (Defense <= 0 || Defense > 50)
                    {
                        Error = "Defense outside of acceptable range.";
                    }
                }
                else
                {
                   //
                }
                return Error;
            }
        }

        #endregion
    }
}
