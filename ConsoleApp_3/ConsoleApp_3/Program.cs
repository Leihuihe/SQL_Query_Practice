

/*

1.Describe the problem generics address.
Generics address the need for writing reusable and type-safe code by enabling the creation of classes, interfaces, and methods that can work with any data type.

2. How would you create a list of strings, using the generic List class?
List<string> stringList = new List<string>();

3. How many generic type parameters does the Dictionary class have?
2

4. True/False. When a generic class has multiple type parameters, they must all match.
False

5. What method is used to add items to a List object?
Add()

6. Name two methods that cause items to be removed from a List.
Remove(), RemoveAt(int index)

7. How do you indicate that a class has a generic type parameter?
<T>

8. True/False. Generic classes can only have one generic type parameter.
False

9. True/False. Generic type constraints limit what can be used for the generic type.
True

10. True/False. Constraints let you use the methods of the thing you are constraining to.
True
 
 */



public class MyStack<T>
{
    List<T> list;

    public int Count() { return list.Count; }

    public T Pop() 
    {
        T res = list[0];
        list.RemoveAt(0);
        return res; 
    }

    public void Push(T item)
    {
        list.Insert(0, item);
    }
}


public class MyList<T>
{
    T[] list = new T[10];
    int size = 0;

    public void Add(T item)
    {
        if(size == list.Length)
        {
            T[] newList = new T[size*2];
            for(int i = 0; i < size; i++)
            {
                newList[i] = list[i];
            }
        }
        list[size] = item;
        size++;
    }

    public T Remove(int index)
    {
        T res = list[index];
        for(int i = index; i<this.size-1; i++)
        {
            list[i] = list[i+1];
        }
        this.size--;
        return res;
    }
     public bool Contains(T item)
    {
        for(int i = 0;i<this.size;i++)
        {
            if (list[i].Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        this.size = 0;
    }

    public void InsertAt(int index, T item)
    {
        if (size == list.Length)
        {
            T[] newList = new T[size * 2];
            for (int i = 0; i < size; i++)
            {
                newList[i] = list[i];
            }
        }

        for (int i=this.size - 1; i>=index; i--)
        {
            list[i+1] = list[i];
        }
        list[index] = item;
        this.size++;
    }

    public void DeleteAt(int index)
    {
        for (int i = index; i < this.size-1; i++)
        {
            list[i] = list[i + 1];
        }
        this.size--;
    }

    public T Find(int index)
    {
        if(index >= size - 1)
        {
            return default(T);
        }
        return list[index];

    }


}


public interface IRepository<T> where T : class
{
    public void Add(T item);
    public void Remove(T item);
    public void Save();
    public IEnumerable<T> GetAll();
    public T GetById(int id);
}

public interface IEntity
{    int Id { get; }
}
public class GenericRepository<T> : IRepository<T> where T: class, IEntity
{
    List<T> list;
    public void Add(T item)
    {
        list.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return list;
    }

    public T GetById(int id)
    {
        foreach (T item in list)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return default(T);
    }

    public void Remove(T item)
    {
        list.Remove(item);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
