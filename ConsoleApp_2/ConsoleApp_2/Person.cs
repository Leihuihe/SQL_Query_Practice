namespace ConsoleApp_2;
public abstract class Person
{
    public string name { get; set; }

    public ushort age { get; set; }

    public decimal salary { get; set; }

    public string[] addresses { get; set; }

}


public abstract class Student : Person
{
    public int studentId { get; set; }

}

public abstract class Instructor : Person
{
    public int instructorId { get; set; }

}

public abstract class Course
{
    public int courseId { get; set; }

}

public abstract class Department
{
    public int departmentId { get; set; }

}

