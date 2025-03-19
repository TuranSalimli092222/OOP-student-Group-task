using System.Security.Cryptography.X509Certificates;

public class Student
    {
    public string Name;
    public string Surname;
    public string Gender;
    public int Age;
    public int PhoneNumber;
    public int Limit;
    public string Group;
   
   

    public Student(string name, string surname, string gender, int age, int _phoneNumber, int limit, string group)
    {
        Name = name; 
        Surname = surname; 
        Gender = gender;
        Age = age;
        this.PhoneNumber = _phoneNumber; 
        Limit = limit; 
        Group = group;
    }
    public void Absent()
    {
        if (Limit > 0)
        {
            Limit--;
            Console.WriteLine($"{Name},{Surname} dersde istrak etmir,Qalan qayib limiti {Limit}");
        }
        else if (Limit == 0)

        {
            Console.WriteLine("Tessufki kesildiniz(");
        }
        else
        {
            Console.WriteLine("qayib menifi ola bilmez");
        }
    }

}


