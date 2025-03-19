public class Group
    {
    public string Name;
    public string Shift;
    public Student[] Students;

    public Group(string name,string shift, int maxStudents)
    {
        Name = name;
        Shift = shift;
        Students = new Student[maxStudents];
    }
    public void AddStudent(Student student)
    {
        bool added = false;
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i] == null) 
            {
                Students[i] = student; 
                
                added = true;
                break;
            }
        }
        if (!added)
        {
            Console.WriteLine("Qrup dolub, tələbə əlavə oluna bilməz.");
        }
    }
    public void FindStudent(string Name)
    {
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null && Students[i].Name == Name)
                {
                    Console.WriteLine($"{Name} adlı telebe qrupda tapildi.");
                    return;
                }
                else
                {
                    Console.WriteLine("Bele bir telebe yoxdur!");
                }
            }
        }
    }
}

