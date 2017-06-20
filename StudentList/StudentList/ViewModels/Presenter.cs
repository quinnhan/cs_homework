using System;
using System.Windows.Input;
using StudentList.ViewModels;
using StudentList.Models;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Presenter : ObservableObject
    {
        private ICommand ButtonCommand;
        private ICommand AddButtonCommand
        {
            get { return ButtonCommand; }
            set { ButtonCommand = value; }
        }

        private ObservableCollection<Person> studentList;
        public ObservableCollection<Person> StudentList
        {
            get{ return studentList;}
            set
            {
                studentList = value;
                RaisePropertyChangedEvent("StudentList");
            }
        }

        private string newPersonName;
        private string newAge;
        private bool newIsMale;

        public string NewPersonName
        {
            get { return newPersonName;}
            set
            {
                newPersonName = value;
                RaisePropertyChangedEvent("NewPersonName");
            }
        }

        public string NewAge
        {
            get { return newAge; }
            set
            {
                newAge = value;
                RaisePropertyChangedEvent("NewAge");
            }
        }

        public bool NewIsMale
        {
            get { return newIsMale; }
            set
            {
                newIsMale = value;
                RaisePropertyChangedEvent("NewIsMale");
            }
        }

        public Presenter()
        {
            StudentList = new ObservableCollection<Person>();
        }

        public void AddNewStudent()
        {
            var name = this.NewPersonName;

            if (string.IsNullOrEmpty(name))
                return;

            if (!int.TryParse(this.NewAge, out int age))
                return;

            var gender = this.NewIsMale ? Person.Gender.Male : Person.Gender.Female;

            this.StudentList.Add(new Person
            {
                Name = name,
                Age = age,
                gender = gender
            });

            this.NewPersonName = string.Empty;
            this.NewAge = string.Empty;
            this.NewIsMale = false;
        }
    }
}
