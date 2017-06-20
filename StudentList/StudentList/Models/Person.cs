using System;
using System.Collections.Generic;
using System.Linq;
using StudentList.ViewModels;
using System.Threading.Tasks;

namespace StudentList.Models
{
    class Person : ObservableObject
    {
        private string name;
        private int age;
        private Gender _gender;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChangedEvent("Name");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                RaisePropertyChangedEvent("Age");
            }
        }
        public Gender gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                RaisePropertyChangedEvent("gender");
            }
        }

        public enum Gender
        {
            Male,
            Female
        }
        
    }
}
