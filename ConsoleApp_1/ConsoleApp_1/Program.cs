/*1.What type would you choose for the following “numbers”?
A person’s telephone number     char
A person’s height               float
A person’s age                  byte
A person’s gender (Male, Female, Prefer Not To Answer)  byte
A person’s salary               double
A book’s ISBN                   uint
A book’s price                  double
A book’s shipping weight        double
A country’s population          uint
The number of stars in the universe  ulong
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business)   ushort


2. What are the difference between value type and reference type variables? What is
boxing and unboxing? 
value type variables store the value in the stack
reference type variables store the memory address of the object in the heap

Boxing converts a Value Type variable into a Reference Type variable, and Unboxing achieves the vice-versa


3. What is meant by the terms managed resource and unmanaged resource in .NET
Managed resources are those that the .NET garbage collector automatically handles.
Unmanaged resources are usually used to describe something not directly under the control of the garbage collector.

4. Whats the purpose of Garbage Collector in .NET?
The garbage collector manages the allocation and release of memory for an application


1. When to use String vs. StringBuilder in C# ?
String is immutable. StringBuilder is designed to represent a mutable string of characters and is perfect for scenarios with numerous manipulations.

2. What is the base class for all arrays in C#?
Array

3. How do you sort an array in C#?
Array.sort()

4. What property of an array object can be used to get the total number of elements in
an array?
Array.length

5. Can you store multiple data types in System.Array?
Yes, user object array object[]

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
Copyto( ) copies the source array to desitination array
Clone() copies the array and returns the new object.

both methods perform shallow copies, so the objects within the arrays remain the same.
 */

/*int[] sourceArray = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 10 };
int[] destinationArray = new int[sourceArray.Length];

for (int i = 0; i < sourceArray.Length; i++) {
    destinationArray[i] = sourceArray[i];
}
Console.WriteLine($"[{string.Join(", ", sourceArray)}]");
Console.WriteLine($"[{string.Join(", ", destinationArray)}]");
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

/*List<string> itemList = new List<string>();
while(true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string item = Console.ReadLine();
    string[] itemName = item.Split(" ");
    if (itemName[0] == "+")
    {
        itemList.Add(itemName[1]);
    } else if (itemName[0] == "-")
    {
        int index = itemList.IndexOf(itemName[1]);
        if(index != -1) 
        {
            itemList.RemoveAt(index);
        }
        
    } else if (itemName[0] == "--")
    {
        itemList.Clear();
    }

    Console.WriteLine($"Your List is: {string.Join(", ", itemList)}");
}*/

/*static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();
    if(endNum < startNum || endNum < 0)
    {
        return null;
    }

    for(int i = startNum; i <= endNum; i++)
    {
        if(i == 1)
        {
            continue;
        }
        bool isPrime = true;
        for(int j = 2; j <= i/2; j++)
        {
            Console.WriteLine(i + " " + j);
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
            
        }
        if(isPrime)
        {
            primes.Add(i);
        }

    }
    return primes.ToArray();

}

Console.WriteLine(string.Join(", ", FindPrimesInRange(1, 100)));*/

/*Console.WriteLine("Enter an array:");
string item = Console.ReadLine();
Console.WriteLine("Enter rotate times:");
int k = int.Parse(Console.ReadLine());

string[] arr = item.Split(" ");
int[] sum = new int[arr.Length];
int[] rotate = new int[arr.Length];

for (int j = 0; j < arr.Length; j++)
{
    rotate[j] = int.Parse(arr[j]);
    // Console.WriteLine(rotate[j]);
}

for (int i = 1; i <= k; i++)
{
    int[] newRotate = new int[arr.Length];
    for (int j = 0; j < arr.Length; j++)
    {
        newRotate[(j + i) % arr.Length] = rotate[j];

        sum[(j + i) % arr.Length] += newRotate[(j + i) % arr.Length];
        // Console.WriteLine((j + i) % arr.Length + " " + newRotate[(j + i) % arr.Length] + " "+i);

    }
    //rotate = newRotate;
}

Console.WriteLine(string.Join(" ", sum));
*/

/*Console.WriteLine("Enter an array:");
string item = Console.ReadLine();
String[] strArr = item.Split(" ");

int[] num = new int[strArr.Length];

for (int j = 0; j < strArr.Length; j++)
{
    num[j] = int.Parse(strArr[j]);
    // Console.WriteLine(rotate[j]);
}

int index = 0, max = 0, count = 0;
for (int i = 1; i < strArr.Length; i++)
{
    if (strArr[i] == strArr[i - 1])
    {
        count++;
    } else
    {
        count = 0;
    }
    if (max < count + 1)
    {
        index = i - count;
        max = count + 1;
    }
    // Console.WriteLine(count + " " + max);
}
// Console.WriteLine(index +" "+ max);

Console.WriteLine($"Longest repeating Integers: {string.Join(" ", strArr.Skip(index).Take(max).ToArray())}");*/



/*Console.WriteLine("Enter an array:");
string item = Console.ReadLine();
String[] strArr = item.Split(" ");

int[] num = new int[strArr.Length];
List<int> maxList = new List<int>();
Dictionary<int, int> dic = new Dictionary<int, int>();
int max = 1, index = num.Length;

for (int j = 0; j < strArr.Length; j++)
{
    num[j] = int.Parse(strArr[j]);
    // Console.WriteLine();
    if (dic.ContainsKey(num[j]))
    {
        dic[num[j]] = dic.GetValueOrDefault(num[j], 0) + 1;
        max = Math.Max(max, dic[num[j]]);
    } else
    {
        dic.Add(num[j], 1);
    }
    
}
// Console.WriteLine("max: "+ max);
foreach (var (k,v) in dic)
{
    if (v == max)
    {
        maxList.Add(k);
        index = Math.Min(item.IndexOf(k.ToString()),index);
        // Console.WriteLine(index);
    }
}
if(maxList.Count == 1)
{
    Console.WriteLine($"The number {maxList[0]} is the most frequent (occurs {max} times)");
} else if(maxList.Count > 1)
{
    Console.WriteLine($"The numbers {string.Join(",", maxList)} have the same maximal frequence (each occurs {max} times). The leftmost of them is {item.ToCharArray()[index]}");
}*/




/*Console.WriteLine("Enter a string:");
string str = Console.ReadLine();
char[] charArr = str.ToCharArray();
char[] res = new char[charArr.Length];
int len = charArr.Length;
for (int i = 0; i < charArr.Length; i++)
{
    res[i] = charArr[len - 1];
    len--;
}
Console.WriteLine("Reversed string:" + string.Join("", res));

Console.WriteLine("Enter a string:");
string str1 = Console.ReadLine();
int len1 = str1.Length;
Console.Write("Reversed string:");
for (int i = len1 - 1; i >= 0; i--)
{
    Console.Write(str.ElementAt(i));
}*/




string sentence = "C# is not C++, and PHP is not Delphi!";

// string separators = @".,:;=()&\[\]""'/!?  \.\,\:\;\=\(\)\&\[\]'\!\? ";
string[] words = Regex.Split(sentence, @"(!|\?|\.|,|:|=|\(|\)|&|\[|\]|\'|\s|\\|\/|"")");
string[] words2 = Regex.Split(sentence, @"[!|\?|\.|,|:|=|\(|\)|&|\[|\]|\'|\s|\\|\/|""|\t| ]");

List<string> separatorList = new List<string> { ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "\'", "\\", "/", "!", "?" };
string[] separators = new string[words.Length];
//Console.WriteLine(separators.Length);
Console.WriteLine(words2[words2.Length - 1]);
StringBuilder stringBuilder = new StringBuilder();
for(int i = 0; i< words.Length; i++)
{
    if(separatorList.IndexOf(words[i]) != -1 )
    {
        Console.WriteLine(i+" "+ words[i]);
        separators[i] = words[i];

    }
}
int count = 0, j = words2.Length - 1;
while (count < separators.Length && j>=0)
{
    if (separators[count] != null)
    {
        count++;
        continue;
    }
    if (words2[j] != " ") 
    {
        Console.WriteLine(count + " " + words2[j]);
        separators[count] = words2[j];
        count++;
        j--;
        separators[count] = " ";
        count++;
    }
}
/*for (int i = words2.Length-1; i>=0; i--)
{
    Console.WriteLine(words2[i]);
    
}*/
Console.WriteLine(string.Join("",separators));
//Console.WriteLine(string.Join("",words));



/*string sentence = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

string[] words = Regex.Split(sentence, @"[^a-zA-Z0-9]");

SortedSet<string> wordsList = new SortedSet<string>();

foreach (string word in words)
{
    if(word.Length == 1)
    {
        wordsList.Add(word);
    }
    else
    {
        bool flag = true;
        int i = 0, j = word.Length - 1;
        while (i < j)
        {
            if (word[i] != word[j])
            {
                flag = false;
                break;
            }
            i++;
            j--;
        }
        if (flag)
        {
            wordsList.Add(word);
        }
    }
}
Console.WriteLine(string.Join(", ",wordsList));
//Console.WriteLine(words.Length);*/



/*string sentence = "www.apple.com";

string[] words = sentence.Split("://");
//Console.WriteLine(string.Join("", words));
string protocol = "", server, resource = "";
if (words.Length == 1)
{
    string[] words2 = Regex.Split(words[0], @"[/]");
    server = words2[0];
    if (words2.Length == 2)
    {
        resource = words2[1];
    }


}
else
{
    protocol = words[0];
    string[] words2 = Regex.Split(words[1], @"[/]");
    server = words2[0];
    if (words2.Length == 2)
    {
        resource = words2[1];
    }
}

Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource}\"");*/