using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public enum LotteryLevel
    {
        SpecialLevel =3,
        FirstLevel = 2,
        SecondLevel = 1,
        ThirdLevel = 0,
        AdditionalLevel = 20,
        Unknown = 99
    }
    public class Employee
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private bool _gender;

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private string _translatedName;

        public string TranslatedName
        {
            get { return _translatedName; }
            set { _translatedName = value; }
        }

        private LotteryLevel _level;

        public LotteryLevel Level
        {
            get { return _level; }
            set { _level = value; }
        }

        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

    }
}
