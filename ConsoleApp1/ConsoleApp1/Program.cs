Student student1 = new Student("Turan", "Salimli", "Kishi", 20, 050 - 867 - 00 - 77, 3, "KE023S2");
Console.WriteLine();

Group group1 = new Group("KE023S2", "Seher", 3);
Student student2 = new Student("Elshad", "Rzazade", "Kishi", 20, 010 - 724 - 42 - 21, 5, "RM023A1");
student1.Absent();
student1.Absent();
student1.Absent();
student1.Absent();

group1.AddStudent(student1);
group1.FindStudent("Turan");

group1.AddStudent(student2);
foreach (var student in group1.Students)
{
    if (student != null)
    {
        Console.WriteLine($"{student.Name},qrupa elave olundu:");
    }
    else
    {
        Console.WriteLine("Group doldu:");
    }
}

   