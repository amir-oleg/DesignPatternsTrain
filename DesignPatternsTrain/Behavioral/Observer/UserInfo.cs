using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DesignPatternsTrain.Behavioral.Observer
{
    public class UserInfo:TrackedEntity
    {
        public UserInfo()
        {
            PropertyChanged += (sender, args) => Console.WriteLine($"{args.PropertyName}  -  was changed");
        }

        public UserInfo(string firstName, string lastName): this()
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                OnPropertyChanged(_firstName, value);
                _firstName = value;

            }
        }
        public string LastName 
        {
            get => _lastName;
            set
            {
                OnPropertyChanged(_lastName, value);
                _lastName = value;

            }
        }

    }
}
