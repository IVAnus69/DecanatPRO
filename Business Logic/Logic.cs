using Model;

namespace Business_Logic
{
    public class Logic
    {
        public List<Student> students = new List<Student>() 
        { new Student("Иван", "КИ21-13Б", "ИСИТ"), new Student("Тилек", "КИ21-12Б", "ИВТ") , new Student ("Кристина", "КИ20-13Б", "ПИ") };
        public void AddStudent(string name, string group, string speciality) => students.Add(new Student(name, group, speciality));
        public void DeleteStudent(int id) => students.RemoveAt(id);

        public List<string> GetAll()
        {
            List<string> list_of_stud = new List<string>();
            for (int i = 0; i < students.Count; i++)
            {
                string name = students[i].Name;
                string group = students[i].Group;
                string speciality = students[i].Speciality;
                list_of_stud.Add($"{name} {group} {speciality}");
            }
            return list_of_stud;
        }
    }
}