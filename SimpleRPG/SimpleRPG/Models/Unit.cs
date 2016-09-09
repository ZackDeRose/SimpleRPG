﻿using System;
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

        #region UnitProperties

        private String _Name;
        /// <summary>
        /// Gets or sets the unit's name
        /// </summary>
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
            }
        }

        private int _MaxHealth;
        /// <summary>
        /// Gets or sets the unit's maxHealth
        /// </summary>
        public int MaxHealth
        {
            get
            {
                return _MaxHealth;
            }
            set
            {
                _MaxHealth = value;
                OnPropertyChanged("MaxHealth");
            }
        }

        private int _CurrentHealth;
        /// <summary>
        /// Gets or sets the unit's currentHealth
        /// </summary>
        public int CurrentHealth
        {
            get
            {
                return _CurrentHealth;
            }
            set
            {
                _CurrentHealth = value;
                OnPropertyChanged("CurrentHealth");
            }
        }

        private int _Attack;
        /// <summary>
        /// Gets or sets the unit's attack
        /// </summary>
        public int Attack
        {
            get
            {
                return _Attack;
            }
            set
            {
                _Attack = value;
                OnPropertyChanged("Attack");
            }
        }


        private int _Defense;
        /// <summary>
        /// Gets or sets the unit's defense
        /// </summary>
        public int Defense
        {
            get
            {
                return _Defense;
            }
            set
            {
                _Defense = value;
                OnPropertyChanged("Defense");
            }
        }

        #endregion

        /// <summary>
        /// Intializes an instance of the Unit class
        /// </summary>
        /// <param name="unitName"> Name </param>
        /// <param name="health"> Health </param>
        /// <param name="attack"> Attack </param>
        /// <param name="defense"> Defense </param>
        public Unit(String unitName, int health, int attack, int defense)
        {
            Name = unitName;
            MaxHealth = health;
            CurrentHealth = MaxHealth;
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

        public string this[string columnName]
        {
            get
            {
                Error = "";
                if (columnName == "Name")
                {
                    if(String.IsNullOrWhiteSpace(Name) || Name.Length > 10 || Name.Length < 4)
                    {
                        Error += "Invalid Name Length.";
                    }
                    if (!Regex.IsMatch(Name, @"^[a-zA-Z]+$"))
                    {
                        Error += "Invalid Name Format.";
                    }
                }
                else if (columnName == "MaxHealth")
                {
                    if (MaxHealth < 10 || MaxHealth > 100)
                    {
                        Error += "Health outside of acceptable range.";
                    }
                }
                else if (columnName == "Attack")
                {
                    if (Attack <= 0 || Attack > 50)
                    {
                        Error += "Attack outside of acceptable range.";
                    }
                }
                else if (columnName == "Defense")
                {
                    if (Defense <= 0 || Defense > 50)
                    {
                        Error += "Health outside of acceptable range.";
                    }
                }
                return Error;
            }
        }

        #endregion
    }
}
