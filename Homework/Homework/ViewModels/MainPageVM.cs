using Homework.Models;
using System.Collections.ObjectModel;

namespace Homework.ViewModels
{
    public class MainPageVM : ObservableObject
    {
        private ObservableCollection<Student> studentList;
        public ObservableCollection<Student> StudentList { get { return studentList; } set { SetProperty(ref studentList, value); } }

        private string newStudentName;
        private string newStudentAge;
        private bool newStudentIsMale;

        public string NewStudentName { get { return newStudentName; } set { SetProperty(ref newStudentName, value); } }
        public string NewStudentAge { get { return newStudentAge; } set { SetProperty(ref newStudentAge, value); } }
        public bool NewStudentIsMale { get { return newStudentIsMale; } set { SetProperty(ref newStudentIsMale, value); } }

        public MainPageVM()
        {
            StudentList = new ObservableCollection<Student>();
        }

        public void AddNewStudent()
        {
            var name = this.NewStudentName;

            if (string.IsNullOrEmpty(name))
                return;

            if (!int.TryParse(this.NewStudentAge, out int age))
                return;

            var gender = this.NewStudentIsMale ? Gender.Male : Gender.Female;

            this.StudentList.Add(new Student
            {
                Name = name,
                Age = age,
                Gender = gender
            });

            this.NewStudentName = string.Empty;
            this.NewStudentAge = string.Empty;
            this.NewStudentIsMale = false;
        }
    }
}
