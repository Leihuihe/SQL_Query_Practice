namespace ConsoleApp_2;
public interface IPerson
{
    int Calculate(int age);

    string[] getAddress();

}

public interface IStudentService : IPerson
{


}

public interface InstructorService : IPerson
{
    decimal addBonus(decimal bonus);

}
