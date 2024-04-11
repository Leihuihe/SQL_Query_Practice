/*
 
1.What are the six combinations of access modifier keywords and what do they do? 
public: Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
private: Only code declared in the same class or struct can access this member.
protected: Only code in the same class or in a derived class can access this type or member.
internal: Only code in the same assembly can access this type or member.
protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.

2.What is the difference between the static, const, and readonly keywords when applied to
a type member?
Static:
When a member is declared as static, it means that it belongs to the type itself rather than to any instance of the type.
There will be only one instance of a static member shared across all instances of the type, and it can be accessed using the type name itself, without needing an instance of the type.
Static members are initialized only once, at the start of the program execution, and retain their value throughout the lifetime of the program.

Const:
Constants are implicitly static and cannot be modified after they are initialized.
They must be initialized at the time of declaration, and their value must be a compile-time constant.
They are typically used for values that are known at compile time and are not expected to change during the execution of the program.
Constants are often used for things like mathematical constants, fixed configuration values, or flags.

Readonly:
Readonly fields, like constants, cannot be modified after they are initialized, but they are not implicitly static.
They can be initialized either at the time of declaration or within the constructor of the type.
Readonly fields allow for more flexibility compared to constants because their value can be determined at runtime, allowing for initialization based on constructor parameters or other runtime conditions.
Readonly fields are often used when you want to ensure that a value can be set only once and then remains constant throughout the lifetime of the object.

3. What does a constructor do?
A constructor is a special method within a class that is called automatically when an instance of the class is created.

4. Why is the partial keyword useful?
The partial keyword in C# allows a class, struct, interface, or method to be defined in multiple files within the same namespace. 
It enables developers to split the definition of a type or method across multiple source files giving the benefits like collaborative development, separation of concerns.


5. What is a tuple?
A tuple is a data structure that allows you to group together a fixed number of elements of different types.

6. What does the C# record keyword do?
It is used to define a reference type that represents an immutable data structure. 

7. What does overloading and overriding mean?
Overloading refers to the ability to define multiple methods in the same class with the same name but different parameter lists. The methods must have different signatures, which means they can have different numbers or types of parameters.
Overriding refers to the ability of a subclass (derived class) to provide a specific implementation of a method that is already defined in its superclass (base class). The method in the derived class must have the same signature (name and parameter list) as the method in the base class.

8. What is the difference between a field and a property?
Fields are simple variables that store data directly within a class, while properties provide a more flexible and controlled way to access and manipulate the data stored in fields. Properties allow encapsulation of fields, enabling better control over how data is accessed and modified, and they are often preferred over fields for public members of a class.

9. How do you make a method parameter optional?
By providing a default value for the parameter in the method's declaration. Optional parameters must be specified after all required parameters in the method signature. 

10. What is an interface and how is it different from abstract class?
An interface defines a contract without providing any implementation, whereas an abstract class can provide both abstract (unimplemented) and concrete (implemented) methods.
A class can implement multiple interfaces but inherit from only one abstract class.
Interfaces are used to define polymorphic behavior across unrelated classes, while abstract classes are used to provide common behavior among related classes in an inheritance hierarchy.
Interfaces promote loose coupling by allowing classes to interact based on contracts, while abstract classes provide a base implementation that derived classes can extend.

11. What accessibility level are members of an interface?
All members of an interface are implicitly public.

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
True

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
True

14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
False

15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
False

16.True / False.Normal(non-abstract) methods can be used in an abstract class. 
True

17.True / False.
Derived classes can override methods that were virtual in the base class. 
True

18.True / False.
Derived classes can override methods that were abstract in the base class. 
True

19.True / False.
In a derived class, you can override a method that was neither virtual non abstract in the
base class.
False

20.True / False.A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
False

21.True / False.A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
True

22.True / False.A class can have more than one base class.
False

23.True / False.A class can implement more than one interface
True
 
 */



/*static int[] GenerateNumbers()
{
    return [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
}

static void PrintNumbers(int[] numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

static void Reverse(int[] numbers)
{
    Array.Reverse(numbers);
}


int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);*/



/*static int Fibonacci(int number)
{
    if (number <= 2)
    {
        return 1;
    }
    return Fibonacci(number - 1) + Fibonacci(number - 2);

    *//*int res = 1;
    int[] record = [1, 1];
    for (int i = 3; i <= number; i++)
    {
        res = record[0] + record[1];
        record[0] = record[1];
        record[1] = res;
    }
    return res;*//*
}

for (int i = 1; i <= 10; i++)
{
    Console.Write(Fibonacci(i) + ", ");
}*/




