//using System.Collections.Generic;
//using System.Xml.Linq;
//using System;

//Note! this is additional task that requires understanding of HashSet, so please, read the article: HashSet before implementing the task.

//Implement class Student : add the constructor (with field initializations) and necessary methods into it.

//Add public static GetCommonStudents() method to Student class that returns a HashSet of common elements of two student lists.

//For example, for a given list1 [Student [Id=1, Name=Ivan], Student[Id = 2, Name = Petro], Student[Id = 3, Name = Stepan]] and list2[Student[Id = 1, Name = Ivan], Student[Id = 3, Name = Stepan], Student[Id = 4, Name = Andriy]] you should get [Student [Id=3, name=Stepan], Student[Id = 1, Name = Ivan]].

class Student
{
    public int Id { get; }
    public string Name { get; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public static HashSet<Student> GetCommonStudents(List<Student> list1, List<Student> list2)
    {
        HashSet<Student> commonStudents = new HashSet<Student>(list1);
        commonStudents.IntersectWith(list2);
        return commonStudents;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Student other = (Student)obj;
        return Id == other.Id && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }

    public override string ToString()
    {
        return $"Student [Id={Id}, Name={Name}]";
    }
}