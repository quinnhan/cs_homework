namespace Homework.Models
{
    public class Student : ObservableObject
    {
        private string name;
        private int age;
        private Gender gender;

        public string Name { get { return name; } set { SetProperty(ref name, value); } }
        public int Age { get { return age; } set { SetProperty(ref age, value); } }
        public Gender Gender { get { return gender; } set { SetProperty(ref gender, value); } }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
